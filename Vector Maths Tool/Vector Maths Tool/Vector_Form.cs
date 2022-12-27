using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace Vector_Maths_Tool
{
    public partial class Vector_Form : Form
    {
        #region Variables

        Color currentColor = Color.FromArgb(128, 64, 220, 16);
        Point canvasCentre;
        Point startPoint;
        Point canvasMousePos;

        Stopwatch runTimer = new Stopwatch();

        List<Vector_Shapes> vectorList = new List<Vector_Shapes>();

        static PictureBox[] boolCheckers;
        static Label[] boolLabels;

        bool timerRunning = false;
        bool onCanvas = false;
        bool isDrawingVector = false;
        bool canvasPressed = false;
        bool canvasReleased = false;
        bool canCreateVector = false;
        bool isClearingScreen = false;

        string timerOut;

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
        }

        #region Graphics

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            canvasCentre = new Point(Canvas.Width / 2, Canvas.Height / 2);
            canvasMousePos = new Point(PointToClient(MousePosition).X - Canvas.Location.X, PointToClient(MousePosition).Y - Canvas.Location.Y);
            Pen drawPen = new Pen(currentColor);
            Brush drawBrush = new SolidBrush(currentColor);
            Point endPoint;

            if (isClearingScreen)
            {
                isClearingScreen = false;
                graphics.Clear(Canvas.BackColor);
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
        //Temp line top visualise line o be created
        void DrawGuideLine(Pen pen, Point lineStart, Point lineEnd, Graphics graphics)
        {
            graphics.DrawLine(pen, lineStart, lineEnd);

        }

        //Draw line and create a line object
        void Create_Line(Pen pen, Point lineStart, Point lineEnd)
        {
            canCreateVector = false;
            UpdateBoolChecker("Can_Create", canCreateVector, 2);
            Console.WriteLine("Line Count [{0}]", vectorList.Count);
            vectorList.Add(new Vector_Shapes(lineStart, lineEnd));

        }


        #endregion

        #region User_Input

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
            UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            Canvas.Refresh();

        }
        //Mouse over Canvas
        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            onCanvas = true;
            UpdateBoolChecker("On_Canvas", onCanvas, 3);

        }
        //Mouse leaves Canvas
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            onCanvas = false;
            canvasPressed = false;
            UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            UpdateBoolChecker("On_Canvas", onCanvas, 3);

        }

        //Mouse moved while over canvas
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawingVector) { Canvas.Refresh(); }

        }


        //Updates Bool checker UI box and label with index of ui
        void UpdateBoolChecker(string boolName, bool boolCheck, int boxIndex)
        {
            if (boolCheck) { boolCheckers[boxIndex].BackColor = currentColor; }
            else { boolCheckers[boxIndex].BackColor = Button_Panel.BackColor; }

            if (boolName.Length > 11)
            {
                boolName = boolName.Substring(0, 11);
            }
            boolLabels[boxIndex].Text = boolName;
            boolCheckers[boxIndex].Refresh();

        }

        #endregion

        #region Buttons

        //Closes App
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (TimerWorker.WorkerSupportsCancellation) { TimerWorker.CancelAsync(); }
            Application.Exit();

        }

        //Title text on click shows info
        private void HeaderText_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vector Tools by Gin0ss || V. 0.07");
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
        private void CreateVector_Click(object sender, EventArgs e)
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
            Canvas.Refresh();

        }

        #endregion

    }
}
