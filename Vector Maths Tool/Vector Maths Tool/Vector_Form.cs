using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ginoss_Tools;

/* TO DO:
 * Line Created (X)
 * Get start and end (X)
 * Calculate Vector normal and magnitude (X)
 * Click Select Vector button on sidebar (X)
 * Loop through each pixel using Bresenham Algorithm going along the normal (X)
 * (Understand how exactly the algorithm works by doing it manually on paper specifically the reson the error value works and why adding the line vector that way make it move perfectly)
 * Store pixel locations under lines index value in SQL (X)
 * When mouse moves check for the current mouse position coordinates in the file for associated line index (X)
 * if coordinate exists in file and is linked to a line index get the line index
 * Show visual effect of line cursor is on (change color for now)
 * (Add glow effect around line)
 * if mouse clicks while over line create context menu to the right of cursor position
 * Custom context menu should show information on line such as magnitude, normal, button for maths functions
 * (Add Scale up and Move animation using deltaTime)
 * if math button pressed create another pop up menu with different math functions tooltip on how to use
 * if math function pressed brief instruction on how to use (label will do) e.g. Select another line to add
 * Select another line to add together and create the resulting line color with color dialouge popup
 * (Add deltaTime for animation functionality and possibly smooth mouse cursor while creating a line)
 * (linePoints array in Vector_Shapes class change to start and end point variable to avoid confusion)
 * (Make Line stats on sidebar update during guide line drawing)
 * (Keyboard shortcut for creating a vector)
 * (Expand Vector struct overloads and math functionality such ad dot product method)
 * (Undo and redo keys using Z and X by removing the last in Vector List and puts into redo List and redo adds back to vector list from redo list)
 * (Save screens of just the canvas and possibly change the for loop of creating te lines to a background bitmap to save performance)
 * (Fullscreen on Canvas with miniside bar or pop out and hide function)
 * (Fix guide line being behind all the drawn lines)
 * (Add performance and memory boost to sql table queries by removing every other pixel stored for the line and creating a radius around each pixel in c# to -
 * fill in the blanks depending on a threshold gap between pixels essentially halving or more the search speed and memory used in sql table but sacrificing accuracy the higher the value)
 */

namespace Vector_Maths_Tool
{
    public partial class Vector_Form : Form
    {
        #region Variables

        Color guideColor = Color.FromArgb(64, 32, 120, 16);
        Color lineColor = Color.FromArgb(255, 16, 255, 8);
        Point canvasCentre;
        Point startPoint;
        Point canvasMousePos;

        Stopwatch runTimer = new Stopwatch();

        List<Vector_Shapes> vectorList = new List<Vector_Shapes>();
        List<Vector> temp = new List<Vector>();

        Image backgroundImage = Properties.Resources.backgroundAbberate;

        static PictureBox[] boolCheckers;
        static Label[] boolLabels;

        int LineWidth;

        bool onCanvas = false;
        bool timerRunning = false;
        bool canvasPressed = false;
        bool canvasReleased = false;
        bool canCreateVector = false;
        bool isDrawingVector = false;
        bool isClearingScreen = false;
        bool isSelectingVector = false;

        string timerOut;
        string connectionString = "Server=.\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        #endregion

        public Vector_Form()
        {
            runTimer.Start();

            InitializeComponent();

        }

        //Initialise all bool checkboxes and label into array on load
        private void Vector_Form_Load(object sender, EventArgs e)
        {
            PictureBox[] a = { Bool_Check_0, Bool_Check_1, Bool_Check_2, Bool_Check_3 };
            Label[] b = { Bool_Label_0, Bool_Label_1, Bool_Label_2, Bool_Label_3 };

            boolCheckers = a;
            boolLabels = b;

            CurrentGuideColor.Color = guideColor;
            CurrentLineColor.Color = lineColor;
            LineWidth = (int)LineThicknessIncrement.Value;

        }

        #region Graphics

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            canvasCentre = new Point(Canvas.Width / 2, Canvas.Height / 2);
            canvasMousePos = GetMousePositionToCanvas();
            Pen drawPen = new Pen(guideColor, LineWidth);
            Brush drawBrush = new SolidBrush(guideColor);
            Point endPoint;

            if (isClearingScreen)
            {
                isClearingScreen = false;
                graphics.DrawImage(backgroundImage, Canvas.Location);
                return;

            }

            if (canvasPressed && isDrawingVector)
            {

                DrawGuideLine(drawPen, startPoint, canvasMousePos, e.Graphics);

            }

            if (canvasReleased)
            {
                canvasReleased = false;
                if (canCreateVector)
                {
                    canCreateVector = false;
                    endPoint = canvasMousePos;

                    Create_Line(drawPen, startPoint, endPoint);

                }

            }

            for (int i = 0; i < vectorList.Count; i++)
            {
                graphics.DrawLine(vectorList[i].drawPen, vectorList[i].linePoints[0], vectorList[i].linePoints[1]);

            }

        }

        //Temp line top visualise line to be created
        void DrawGuideLine(Pen pen, Point lineStart, Point lineEnd, Graphics graphics)
        {
            graphics.DrawLine(pen, lineStart, lineEnd);

        }

        //Draw line and create a line object
        void Create_Line(Pen pen, Point lineStart, Point lineEnd)
        {
            canCreateVector = false;
            UpdateBoolChecker("Can_Create", canCreateVector, 2);
            Vector_Shapes newShape = new Vector_Shapes(lineStart, lineEnd, LineWidth, lineColor);
            vectorList.Add(newShape);
            BresenhamLine(newShape);

            label6.Text = "Gradient: " + newShape.lineGradient;
            label5.Text = "Line Count: " + vectorList.Count;
            label4.Text = "Start: " + newShape.linePoints[0];
            label3.Text = "End: " + newShape.linePoints[1];
            label2.Text = "Magnitude: " + newShape.lineVector.Magnitude();
            label1.Text = "Normal: {" + newShape.lineVector.X + ", " + newShape.lineVector.Y + "}";

        }

        //Something wrong in while loop never reaches first if statement
        void BresenhamLine(Vector_Shapes shape)
        {
            int startX = shape.linePoints[0].X;
            int startY = shape.linePoints[0].Y;
            int endX = shape.linePoints[1].X;
            int endY = shape.linePoints[1].Y;
            int deltaX = Math.Abs((int)endX - startX);
            int deltaY = Math.Abs((int)endY - startY);
            int sX = startX > endX ? -1 : 1;
            int sY = startY > endY ? -1 : 1;
            int err = deltaX - deltaY;

            while (true)
            {
                if (startX == endX && startY == endY) break;

                int err2 = 2 * err;

                if (err2 > -deltaY)
                {
                    err -= deltaY;
                    startX += sX;

                }
                if (err2 < deltaX)
                {
                    err += deltaX;
                    startY += sY;

                }

                StoreSelectCoordinate(vectorList.Count - 1, startX, startY);

            }

        }

        void StoreSelectCoordinate(int lineID, int startX, int startY)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string createTable = ("IF OBJECT_ID(N'POINTS', N'U') IS NULL CREATE TABLE POINTS (Line_ID int, Start_X int, Start_Y int); ");
                string addCoordinate = (String.Format("INSERT INTO POINTS (Line_ID, Start_X, Start_Y) VALUES ( '{0}', '{1}', '{2}' );", lineID, startX, startY));

                SqlCommand command = new SqlCommand(createTable + addCoordinate, connection);
                command.ExecuteNonQuery();

            }

        }

        #endregion

        #region User_Input

        //Canvas Keyboard Input
        void Canvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!isDrawingVector) { isDrawingVector = true; canCreateVector = true; }
                else { isDrawingVector = false; canCreateVector = false; }
                UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
                UpdateBoolChecker("Can_Create", canCreateVector, 2);

            }

            if (e.KeyCode == Keys.C)
            {
                CurrentLineColor.ShowDialog();
                lineColor = CurrentLineColor.Color;
                LineColorButton.ForeColor = lineColor;

            }

            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.ShiftKey ) && LineThicknessIncrement.Value < LineThicknessIncrement.Maximum) { LineThicknessIncrement.Value += 1; }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.ControlKey ) && LineThicknessIncrement.Value > LineThicknessIncrement.Minimum) { LineThicknessIncrement.Value -= 1; }

        }

        //Mouse button down over canvas
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canvasPressed = true;
            if (isDrawingVector) { startPoint = canvasMousePos; }
            UpdateBoolChecker("Mouse_Down", canvasPressed, 1);

        }

        //Mouse button released over canvas
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canvasReleased = true;
            canvasPressed = false;
            isDrawingVector = false;
            isSelectingVector = false;
            UpdateBoolChecker("Select_Line", isSelectingVector, 3);
            UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            Canvas.Refresh();

        }
        //Mouse over Canvas
        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            onCanvas = true;
            Canvas.Focus();

        }

        //Mouse leaves Canvas
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            onCanvas = false;
            canvasPressed = false;
            UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            Button_Panel.Focus();

        }

        //Mouse moved while over canvas
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            bool mouseOnX = false;

            canvasMousePos = GetMousePositionToCanvas();

            if (isDrawingVector) { Canvas.Refresh(); }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand mouseXCommand = new SqlCommand("SELECT Start_X FROM POINTS WHERE Start_X = @mousePosX", connection))
                    {
                        mouseXCommand.Parameters.AddWithValue("@mousePosX", canvasMousePos.X);

                        var result = mouseXCommand.ExecuteScalar();
                        mouseOnX = result != null ? ((int)result == canvasMousePos.X) : false;
                        Console.WriteLine(result);

                    }
                    if (mouseOnX)
                    {
                        Console.WriteLine("Mouse X on Line");
                        //if y in sql table is mouse cursor y then get line index

                    }

                    connection.Close();

                }

            }

        }


        //Updates Bool checker UI box and label with index of ui
        void UpdateBoolChecker(string boolName, bool boolCheck, int boxIndex)
        {
            if (boolCheck) { boolCheckers[boxIndex].BackColor = guideColor; }
            else { boolCheckers[boxIndex].BackColor = Button_Panel.BackColor; }

            if (boolName.Length > 11)
            {
                boolName = boolName.Substring(0, 11);
            }
            boolLabels[boxIndex].Text = boolName;
            boolCheckers[boxIndex].Refresh();

        }

        #endregion

        #region UI Input

        //Closes App
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (TimerWorker.WorkerSupportsCancellation) { TimerWorker.CancelAsync(); }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM POINTS", connection);
                command.ExecuteNonQuery();

            }

            Application.Exit();

        }

        //Title text on click shows info
        private void HeaderText_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vector Tools by Gin0ss || V. 0.25");
        }

        #region Timer
        //Timer Button CLicked
        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (timerRunning) { timerRunning = false; }
            else { timerRunning = true; }
            if (!TimerWorker.IsBusy) { TimerWorker.RunWorkerAsync(); }
            UpdateBoolChecker("Timer_Run", timerRunning, 2);

        }

        //Timer Button Async Thread
        private void timerWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int ms = 0;
            int seconds = 0;
            int mins = 0;
            int hours = 0;

            while (timerRunning)
            {
                System.Threading.Thread.Sleep(10);
                ms++;
                timerOut = Convert.ToString(seconds);

                timerOut = hours + ":" + ConvertTime(ref mins, ref hours, 60) + ":" + ConvertTime(ref seconds, ref mins, 60) + "." + ConvertTime(ref ms, ref seconds, 100);
                worker.ReportProgress(seconds);

            }

        }

        //Converts Time unit to another in string
        string ConvertTime(ref int currentInt, ref int newInt, int maxValue)
        {
            if (currentInt >= maxValue)
            {
                currentInt = 0;
                newInt++;
                return Convert.ToString(newInt);
            }
            else { return Convert.ToString(currentInt); }

        }

        //Async thread reported to main thread for UI to process
        private void timerWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimerButton.Text = timerOut;
        }
        #endregion
        //Create Vector/Line Button
        private void CreateVectorButton_Click(object sender, EventArgs e)
        {
            if (!isDrawingVector) { isDrawingVector = true; canCreateVector = true; }
            else { isDrawingVector = false; }
            UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            UpdateBoolChecker("Can_Create", canCreateVector, 2);
        }

        //Clears Screen
        private void ClearButton_Click(object sender, EventArgs e)
        {
            isClearingScreen = true;
            vectorList.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM POINTS", connection);
                command.ExecuteNonQuery();

            }

            label5.Text = "Line Count: 0";
            Canvas.Refresh();

        }

        private void LineThicknessIncrement_ValueChanged(object sender, EventArgs e)
        {
            LineWidth = (int)((float)LineThicknessIncrement.Value * 1.25f);

        }

        private void GuideColorButton_Click(object sender, EventArgs e)
        {
            CurrentGuideColor.ShowDialog();
            guideColor = CurrentGuideColor.Color;
            GuideColorButton.ForeColor = guideColor;

        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            CurrentLineColor.ShowDialog();
            lineColor = CurrentLineColor.Color;
            LineColorButton.ForeColor = lineColor;

        }

        private void SelectVectorButton_Click(object sender, EventArgs e)
        {
            if (!isDrawingVector) 
            {
                isSelectingVector = true;
                UpdateBoolChecker("Select_Line", isSelectingVector, 3);


            }

        }

        #endregion

        Point GetMousePositionToCanvas() { return new Point(PointToClient(MousePosition).X - Canvas.Location.X, PointToClient(MousePosition).Y - Canvas.Location.Y); }

    }
}
