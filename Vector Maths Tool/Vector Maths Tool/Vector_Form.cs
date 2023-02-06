using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using Ginoss_Tools;

#region To_Do

/* --- Main Function ---
* Line Created (X)
* Get start and end (X)
* Calculate Vector normal and magnitude (X)
* Click Select Vector button on sidebar (X)
* Loop through each pixel using Bresenham Algorithm going along the normal (X)
* Understand how exactly the algorithm works by doing it manually on paper specifically the reson the error value works and why adding the line vector that way make it move perfectly
* Store pixel locations under lines index value in SQL (X)
* When mouse moves check for the current mouse position coordinates in the file for associated line index (X)
* if coordinate exists in file and is linked to a line index get the line index (X)
* Show visual effect of line cursor is on (change color for now) (X)
* if mouse clicks while over line create context menu to the right of cursor position (X)
* Custom context menu should show information on line such as magnitude, normal, button for maths functions (X)
* Make elements of popup panel not close the popup panel set the popup to close when mouse enters canvas or side panel rather than leaves popup (X)
* Radius Around cursor selection (X)
* Brush drawing tool for freehand drawing and notes using the cursor radius (X)
* Make all draw brush graphics render on bitmap (X)
* if math button pressed create another pop up menu with different math functions tooltip on how to use (X)
* if math function pressed brief instruction on how to use (label will do) e.g. Select another line to add (X)
* Perform maths function on two lines and create a new line of result with line color with color dialouge popup (X)
* Select other line for math function remove temporary code for selecting: selected line index - 1 (X)
* Move and copy line functionality and choose resulting lines colour if nothing is chosen use last lines colour (X)
* Replace Multiply to scalar multiplication with a input for the multiplier (X)
* Add button for popup for dot/cross product then give result (X)
* Show selected line as guide colour permanently while selected and in select mode (X)
* Dot Spacing too far find out how to make circle draw closer to eachother (X)
*/

/* --- Visual/Graphical Elements ---
* Add glow effect around selected line
* Add deltaTime for animation functionality and possibly smooth mouse cursor while creating a line
* Add Scale up and Move animation using deltaTime
* Change the incrementor UI to be more visually appealing get rid of the basic incrementor with white up and down and possibly add small buttons for up and down
* Graphical representation of radius around cursor for selection area when select line button is enabled
* When no line is present or selected show popup for no line available instead ot the edit vector interface
* Change cursor depending on mode its on etc. Green for selecting line, Blue for creating, Red for freehand brush
* Animate minimizing side panel into side
* Correct scaling for ui buttons, labels etc. when window is resized to prevent overlapping ui elements
*/

/* --- Code Readability ---
* linePoints array in Vector_Shapes class change to start and end point variable to avoid confusion
* isDrawingVector and canDrawVector can most likely remove one and use the other and simplify the boolean checks
* Change label 1-6 to a more specific name to what it shows
* Change all the toggle booleans to a bool = bool ? false : true
* Create a function for each toggle state
* Move Toggle state false bool change to be a seperate function that turns all bools false and changes the bool pased into the function true GlobalToggleState(bool to turn true);
* Sort function regions into more useful groups
* Merge all Toggle state functions into one that takes the the bool to change ToggleState(bool stateBool)
*/

/* --- Quality of Life (Ease of Use) ---
* Visually show when the mouse exits and enters the line rather than just keeping the selected effect on when the cursor leaves -
  but keep the selected line subtly changed to indicate its still the selected line
* Make Line stats on sidebar update during guide line drawing
* Fix guide line being behind all the drawn lines
* Update all the keyboard shortcuts for new UI Added
* Offline Alternative to sql coordinates being stored such as xml or array
* Convert brush to lines with a specific level of precision chosen
* Previous and Next line index inside edit popup that moves popup to start coordinate of next selected line that moves cursor with the popup
* Manually input coordinates of line to create precise line using a seperate popup menu once a button is pressed
* Undo and redo keys using Z and X by removing the last in Vector List and puts into redo List and redo adds back to vector list from redo list
  (Define a "Change"/"Action" class that represents all the variables that causes a change when an action is performed for undo and redo needs to be saved to undo list when something like create line or draw 
  brush on screen then be able to move the current "Change" into redo and puts the Change from undo into the current state using "Stack")
*/

/* --- PERFORMANCE OPTIMISATION ---
* Make sql stored coordinate not slow down computer
* Group multiple coordinates to be moved into the sql command in one go rather than one by one with a batch command
* Store sql procedures to save compilation time
* Save screens of just the canvas and possibly change the for loop of creating lines to a background bitmap to save performance
* Add performance and memory boost to sql table queries by removing every other pixel stored for the line and creating a radius around each pixel in c# to -
  fill in the blanks depending on a threshold gap between pixels essentially halving or more the search speed and memory used in sql table but sacrificing accuracy the higher the value
* Change background worker to thread and dispose of thread when timer is stopped
*/

#endregion

namespace Vector_Maths_Tool
{
    public partial class Vector_Form : Form
    {

        #region Variables

        #region Non-Primitive Objects

        Color lineColor = Color.FromArgb(255, 16, 255, 8);
        Color guideColor = Color.FromArgb(64, 32, 120, 16);

        Brush drawBrush;
        Pen drawPen;

        Point startPoint;
        Point canvasCentre;
        Point canvasMousePos;
        Point originalWindowPos;

        Vector resultVector;

        Stopwatch runTimer = new Stopwatch();
        Stopwatch deltaTimer = new Stopwatch();

        List<Vector_Shapes> vectorList = new List<Vector_Shapes>();

        Image defImage = Properties.Resources.backgroundSpeed;
        Image clearImage = Properties.Resources.backgroundAbberate;

        Bitmap renderImage;

        Graphics renderGraphics;

        #endregion

        //static Label[] boolLabels;
        //static PictureBox[] boolCheckers;

        #region Numbers

        int prevX;
        int prevY;
        int LineWidth;
        int mathLineID;
        int selectRadius;
        int selectedLineID;
        int originalCanvasWidth;
        int originalWindowWidth;
        int originalWindowHeight;

        float lerpTime;
        float deltaTime;
        float timeCounter;
        float resultFloat;
        float mathMultiplier = 2;

        #endregion

        #region Bool Checks

        bool onCanvas = false;
        bool isRunning = false;
        bool isBordered = false;
        bool isMaximized = false;
        bool timerRunning = false;
        bool isMovingLine = false;
        bool isCopyingLine = false;
        bool canvasPressed = false;
        bool canvasReleased = false;
        bool canCreateVector = false;
        bool isDrawingVector = false;
        bool isDrawingFreehand = false;
        bool isSelectingVector = false;
        bool isSidePanelVisible = true;

        #region Math Checks

        bool isAdding = false;
        bool isDividing = false;
        bool isSubtracting = false;
        bool isMultiplying = false;
        bool performingDotProduct = false;
        bool performingCrossProduct = false;

        #endregion

        #endregion

        #region String

        string timerOut;
        //string connectionString = "Server=Ginoss,6464; Database=Vector_Math_Tool;Trusted_Connection=True"; //Local faster
        string connectionString = "Server=31.54.59.212,6464; Database=Vector_Math_Tool; USER ID=AS; PASSWORD = 123"; //Server

        #endregion

        #endregion

        #region Tool Functions

        float Lerp(int value, int startVal, int endVal, int interpolationTime)
        {
            lerpTime += deltaTime;
            int result = (int)(startVal + (endVal - startVal) * (lerpTime / interpolationTime));

            return result;

        }

        float Lerp(float value, float startVal, float endVal, float interpolationTime)
        {
            lerpTime += deltaTime;
            float result = startVal + (endVal - startVal) * (lerpTime / interpolationTime);

            return result;

        }

        #endregion

        #region Initialisation

        public Vector_Form()
        {
            runTimer.Start();

            InitializeComponent();

            drawBrush = new SolidBrush(lineColor);
            drawPen = new Pen(lineColor);
            drawPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            drawPen.Width = selectRadius;

            renderImage = new Bitmap(Width, Height);

        }

        private void Vector_Form_Load(object sender, EventArgs e)
        {
            isRunning = true;

            //PictureBox[] a = { Bool_Check_0, Bool_Check_1, Bool_Check_2, Bool_Check_3 };
            //Label[] b = { Bool_Label_0, Bool_Label_1, Bool_Label_2, Bool_Label_3 };

            //boolCheckers = a;
            //boolLabels = b;

            CurrentGuideColor.Color = guideColor;
            CurrentLineColor.Color = lineColor;
            SelectedMathsPanel.BackColor = Color.FromArgb(100, 24, 14, 32);

            selectRadius = (int)SelectRadiusIncrementor.Value;
            LineWidth = LineWidth = (int)((float)LineThicknessIncrement.Value * 1.25f);
            drawPen.Width = selectRadius * 2;

            Thread updateThread = new Thread(async () =>
            {
                while (isRunning)
                {
                    deltaTimer.Start();
                    deltaTime = deltaTimer.Elapsed.Milliseconds * 0.001f;
                    deltaTimer.Stop();
                    timeCounter += deltaTime;
                    deltaTimer.Restart();

                    Thread.Sleep(16);

                }
            });
            updateThread.Start();

            using (MemoryStream ms = new MemoryStream(Properties.Resources.dot_Cursor)) Canvas.Cursor = new Cursor(ms);
            using (MemoryStream ms = new MemoryStream(Properties.Resources.solidDot_Cursor)) this.Cursor = new Cursor(ms);
            using (MemoryStream ms = new MemoryStream(Properties.Resources.eclipse_Cursor)) Button_Panel.Cursor = new Cursor(ms);
            using (MemoryStream ms = new MemoryStream(Properties.Resources.eclipse_Cursor)) SelectPopupPanel.Cursor = new Cursor(ms);
            using (MemoryStream ms = new MemoryStream(Properties.Resources.eclipse_Cursor)) VectorMathsPanel.Cursor = new Cursor(ms);

            originalCanvasWidth = Canvas.Width;
            originalWindowWidth = this.Width;
            originalWindowHeight = this.Height;
            originalWindowPos = this.Location;

            renderGraphics = Graphics.FromImage(renderImage);

            using (SqlConnection connection = new SqlConnection (connectionString))
            {
                connection.Open();

                using (SqlCommand initializeCommand = new SqlCommand("IF DB_ID('Vector_Math_Tool') IS NULL CREATE DATABASE Vector_Math_Tool", connection))
                    initializeCommand.ExecuteNonQuery();
                using (SqlCommand initializeCommand = new SqlCommand("USE Vector_Math_Tool; IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Points' and xtype='U') CREATE TABLE POINTS (Line_ID int, X int, Y int);", connection))
                    initializeCommand.ExecuteNonQuery();
                using (SqlCommand clearTableCommand = new SqlCommand("DELETE FROM Points", connection))
                    clearTableCommand.ExecuteNonQuery();

                    connection.Close();

            }

        }

        #endregion

        #region Graphics

        void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen guidePen = new Pen(guideColor, LineWidth);
            Brush guideBrush = new SolidBrush(guideColor);
            Point endPoint;

            canvasCentre = new Point(Canvas.Width / 2, Canvas.Height / 2);
            canvasMousePos = GetMousePositionToCanvas();
            guidePen.Width = LineWidth;

            if (canvasPressed && isDrawingVector)
            {
                DrawGuideLine(guidePen, startPoint, canvasMousePos, e.Graphics);

            }

            if (canvasReleased)
            {
                canvasReleased = false;
                if (canCreateVector)
                {
                    canCreateVector = false;
                    endPoint = canvasMousePos;

                    Create_Line(startPoint, endPoint);

                }

            }

            if (isSelectingVector)
            {
                DrawCircle(graphics, guideBrush, canvasMousePos.X, canvasMousePos.Y, selectRadius, false);
                Button_Panel.Refresh();

            }

            if (isDrawingFreehand)
            {
                guidePen = new Pen(guideColor, selectRadius * 2);

                DrawCircle(graphics, guideBrush, canvasMousePos.X, canvasMousePos.Y, selectRadius, false);
                graphics.DrawLine(guidePen, startPoint, canvasMousePos);
                startPoint = canvasMousePos;

            }

            if (isMovingLine || isCopyingLine)
            {
                Point currentLineVector = resultVector + new Vector(canvasMousePos);

                DrawGuideLine(guidePen, canvasMousePos, currentLineVector, graphics);

            }

            if (isAdding || isSubtracting || isMultiplying || isDividing || performingDotProduct || performingCrossProduct)
            {
                Vector lefthandVector = vectorList[mathLineID].lineVector;
                Vector righthandVector = vectorList[selectedLineID].lineVector;

                if (isAdding || isSubtracting || isMultiplying || isDividing)
                {
                    DrawGuideLine(guidePen, canvasMousePos, new Point(resultVector.X + canvasMousePos.X, resultVector.Y + canvasMousePos.Y), graphics);

                    MathsLeftLabel.Text = String.Format("Line: [{0}] \n({1} : {2})", mathLineID, lefthandVector.X, lefthandVector.Y);
                    if (isAdding || isSubtracting) MathsRightLabel.Text = String.Format("Line: [{0}] \n({1} : {2})", selectedLineID, righthandVector.X, righthandVector.Y);
                    if(isMultiplying || isDividing) MathsRightLabel.Text = String.Format("{0}", mathMultiplier);
                    MathsResultLabel.Text = String.Format("Result: \n({0} : {1})", resultVector.X, resultVector.Y);

                }
                if (performingCrossProduct || performingDotProduct)
                {
                    MathsLeftLabel.Text = String.Format("[Line: {0}] \n({1} * {2})", mathLineID, lefthandVector.X, righthandVector.X);
                    MathsRightLabel.Text = String.Format("[Line: {0}] \n({1} * {2})", selectedLineID, lefthandVector.Y, righthandVector.Y);
                    MathsResultLabel.Text = String.Format("Result \n{0}", resultFloat);

                }

            }

            for (int i = 0; i < vectorList.Count; i++)
            {
                DeselectLineGraphics(i);
                if (i == selectedLineID && isSelectingVector) vectorList[selectedLineID].drawPen = guidePen;
                graphics.DrawLine(vectorList[i].drawPen, vectorList[i].linePoints[0], vectorList[i].linePoints[1]);

            }

        }

        void DrawGuideLine(Pen pen, Point lineStart, Point lineEnd, Graphics graphics)
        {
            graphics.DrawLine(pen, lineStart, lineEnd);

        }

        void Create_Line(Point lineStart, Point lineEnd)
        {
            canCreateVector = false;
            //UpdateBoolChecker("Can_Create", canCreateVector, 2);
            Vector_Shapes newShape = new Vector_Shapes(lineStart, lineEnd, LineWidth, lineColor);
            vectorList.Add(newShape);
            BresenhamLine(newShape);

            selectedLineID = vectorList.Count - 1;

            UpdateVectorStatsLabels(newShape);

        }

        //void UpdateBoolChecker(string boolName, bool boolCheck, int boxIndex)
        //{
        //    if (boolCheck) { boolCheckers[boxIndex].BackColor = guideColor; }
        //    else { boolCheckers[boxIndex].BackColor = Button_Panel.BackColor; }

        //    if (boolName.Length > 11)
        //    {
        //        boolName = boolName.Substring(0, 11);
        //    }
        //    boolLabels[boxIndex].Text = boolName;
        //    boolCheckers[boxIndex].Refresh();

        //}

        void UpdateVectorStatsLabels(Vector_Shapes shape)
        {
            label6.Text = "Gradient: " + shape.lineGradient;
            label5.Text = "Line Count: " + vectorList.Count;
            label4.Text = "Start: " + shape.linePoints[0];
            label3.Text = "End: " + shape.linePoints[1];
            label2.Text = "Magnitude: " + shape.lineVector.Magnitude();
            label1.Text = "Normal: {" + shape.lineVector.X + ", " + shape.lineVector.Y + "}";

        }

        void UpdateOperatorLabel(int operatorIndex)
        {
            switch (operatorIndex)
            {
                case 0:
                    MathOperationLabel.Text = "+";
                    return;

                case 1:
                    MathOperationLabel.Text = "-";
                    return;

                case 2:
                    MathOperationLabel.Text = "*";
                    return;

                case 3:
                    MathOperationLabel.Text = "/";
                    return;

            }

        }

        void SelectLinePopup()
        {
            SelectPopupPanel.Visible = true;
            SelectPopupPanel.Enabled = true;
            SelectPopupPanel.Location = new Point(canvasMousePos.X - 16, canvasMousePos.Y - 8);
            PopupClampToScreen(SelectPopupPanel);
            SelectPopupLabel.Text = "Selected Line : " + (selectedLineID + 1);

        }

        void DeselectLinePopup()
        {
            SelectPopupPanel.Enabled = false;
            SelectPopupPanel.Visible = false;
            VectorMathsPanel.Visible = false;
            VectorMathsPanel.Enabled = false;
            ProductPopupPanel.Visible = false;
            ProductPopupPanel.Enabled = false;

            DeselectLineGraphics(selectedLineID);

        }

        void DrawCircle(Graphics graphics, Brush brush, int centreX, int centreY, int radius, bool isFilled)
        {
            while (radius > 0)
            {
                int x = radius;
                int y = 0;
                int p = 1 - x;

                while (x >= y)
                {

                    if (p <= 0) p += 2 * y + 1;
                    else
                    {
                        x--;
                        p += 2 * y - 2 * x + 1;

                    }

                    #region Quadrant Circle Pixels

                    graphics.FillRectangle(brush, centreX + x, centreY + y, 2, 2);
                    graphics.FillRectangle(brush, centreX + x, centreY - y, 2, 2);

                    graphics.FillRectangle(brush, centreX + y, centreY + x, 2, 2);
                    graphics.FillRectangle(brush, centreX + y, centreY - x, 2, 2);

                    graphics.FillRectangle(brush, centreX - x, centreY + y, 2, 2);
                    graphics.FillRectangle(brush, centreX - x, centreY - y, 2, 2);

                    graphics.FillRectangle(brush, centreX - y, centreY + x, 2, 2);
                    graphics.FillRectangle(brush, centreX - y, centreY - x, 2, 2);

                    #endregion

                    y++;
                }

                if (!isFilled) break;
                radius--;

            }

        }

        void ResizeCanvas()
        {
            Bitmap backBuffer = new Bitmap(Width, Height);
            using (Graphics graphics = Graphics.FromImage(backBuffer))
            {
                graphics.DrawImage(renderImage, 0, 0);

            }
            renderImage = backBuffer;
            Canvas.Image = renderImage;

            Canvas.Refresh();

        }

        void PopupFollowMouse(Panel panel)
        {
            int distanceOverEdge = GetMousePositionToCanvas().Y + (panel.Size.Height - this.Size.Height);
            int x = panel.Location.X;
            int y = GetMousePositionToCanvas().Y + panel.Size.Height < this.Size.Height ? GetMousePositionToCanvas().Y : GetMousePositionToCanvas().Y - distanceOverEdge;

            panel.Location = new Point(x, y);

        }

        void PopupClampToScreen(Panel panel)
        {
            int xDistanceFromEdge = GetMousePositionToCanvas().X + (panel.Size.Width - this.Size.Width);
            int yDistanceOverEdge = GetMousePositionToCanvas().Y + (panel.Size.Height - this.Size.Height);

            int x = panel.Location.X + panel.Size.Width < this.Size.Width ? panel.Location.X : GetMousePositionToCanvas().X - xDistanceFromEdge;
            int y = panel.Location.Y + panel.Size.Height < this.Size.Height ? panel.Location.Y : GetMousePositionToCanvas().Y - yDistanceOverEdge;

            panel.Location = new Point(x, y);

        }

        #endregion

        #region Selection

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

        //Needs Optimising over internet connection and possibly an offline alternative
        async void StoreSelectCoordinate(int lineID, int startX, int startY)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("USE Vector_Math_Tool; INSERT INTO POINTS (Line_ID, X, Y) VALUES ( @lineID, @X, @Y );", connection))
                {
                    command.Parameters.AddWithValue("@lineID", lineID);
                    command.Parameters.AddWithValue("@X", startX);
                    command.Parameters.AddWithValue("@Y", startY);

                    await command.ExecuteNonQueryAsync().ConfigureAwait(false);

                }

                connection.Close();

            }

        }

        void SelectLine()
        {
            Vector_Shapes selectedLine = new Vector_Shapes(Point.Empty, Point.Empty, 1, Color.Lime);
            if (selectedLineID - 1 > 0 && selectedLineID + 1 < vectorList.Count) selectedLine = vectorList[selectedLineID];
            else return;

            int selectWidth = selectedLine.LineWidth;
            Color selectColor = selectedLine.LineColor;

            selectWidth = (int)(selectWidth * 0.8f);
            selectColor = Color.FromArgb(180, selectColor.R, selectColor.G, selectColor.B);
            Pen selectPen = new Pen(selectColor, selectWidth);

            selectedLine.drawPen = selectPen;

            UpdateVectorStatsLabels(selectedLine);

            Canvas.Refresh();

        }

        void DeselectLineGraphics(int lineID)
        {
            if (lineID < vectorList.Count)
            {
                int originalWidth = vectorList[lineID].LineWidth;
                Color originalColor = vectorList[lineID].LineColor;

                vectorList[lineID].drawPen = new Pen(originalColor, originalWidth);

            }

        }

        void RemoveLine()
        {
            selectedLineID = vectorList.Count > 0 ? selectedLineID : 0;
            selectedLineID = vectorList.Count > selectedLineID ? selectedLineID : vectorList.Count - 1;

            if (vectorList.Count > 0)
            {
                vectorList.Remove(vectorList[selectedLineID]);
                label5.Text = "Line Count: " + vectorList.Count;

                if(vectorList.Count == 1) UpdateVectorStatsLabels(new Vector_Shapes((Point)Vector.Zero, (Point)Vector.Zero, LineWidth, lineColor));

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("USE Vector_Math_Tool; DELETE FROM POINTS WHERE Line_ID = @selectedLineID; UPDATE Points SET Line_ID = Line_ID - 1 WHERE Line_ID > @selectedLineID", connection);

                    command.Parameters.AddWithValue("@selectedLineID", selectedLineID);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                DeselectLineGraphics(selectedLineID);
                SelectLine();
                DeselectLinePopup();
                Canvas.Refresh();

            }

        }

        void CursorCircleSelect(int radius)
        {
            int x = radius;
            int y = 0;
            int decision = 1 - x;

            int mousePosX = canvasMousePos.X;
            int mousePosY = canvasMousePos.Y;
            int searchX = mousePosX;
            int searchY = mousePosY;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int i = 0;

                while (x > y && mousePosX == canvasMousePos.X && mousePosY == canvasMousePos.Y)
                {
                    y++;

                    if (decision <= 0) decision += 2 * y + 1;
                    else
                    {
                        x--;
                        decision += 2 * y - 2 * x;

                    }

                    switch (i)
                    {
                        case 0:
                            searchX = canvasMousePos.X + x;
                            searchY = canvasMousePos.Y + y;
                            break;
                        case 1:
                            searchX = canvasMousePos.X - x;
                            searchY = canvasMousePos.Y + y;
                            break;
                        case 2:
                            searchX = canvasMousePos.X + x;
                            searchY = canvasMousePos.Y - y;
                            break;
                        case 3:
                            searchX = canvasMousePos.X - x;
                            searchY = canvasMousePos.Y - y;
                            break;
                        case 4:
                            searchX = canvasMousePos.X + y;
                            searchY = canvasMousePos.Y + x;
                            break;
                        case 5:
                            searchX = canvasMousePos.X - y;
                            searchY = canvasMousePos.Y + x;
                            break;
                        case 6:
                            searchX = canvasMousePos.X + y;
                            searchY = canvasMousePos.Y - x;
                            break;
                        case 7:
                            searchX = canvasMousePos.X - y;
                            searchY = canvasMousePos.Y - x;
                            break;
                            
                    }

                    i++;

                        //Needs batch command to speed up select performance
                        using (SqlCommand searchCommand = new SqlCommand("IF EXISTS(SELECT Line_ID FROM Points WHERE X = @currentSearchX AND Y = @currentSearchY) SELECT Line_ID FROM Points WHERE X = @currentSearchX AND Y = @currentSearchY", connection))
                        {
                            searchCommand.Parameters.AddWithValue("@currentSearchX", searchX);
                            searchCommand.Parameters.AddWithValue("@currentSearchY", searchY);

                            #region Select LineID

                            var result = searchCommand.ExecuteScalar();

                            if (vectorList.Count > 0)
                            {
                                selectedLineID = selectedLineID < 0 ? 0 : selectedLineID;

                                if (result != null)
                                {
                                    selectedLineID = selectedLineID <= vectorList.Count - 1 ? (int)result : vectorList.Count - 1;
                                    SelectLine();

                                }
                                else DeselectLineGraphics(selectedLineID);

                            }

                            #endregion

                        }
                    }

                connection.Close();
            }

        }

        #endregion

        #region Tool Mode States

        void ToggleSelectMode()
        {
            Vector vector = mathLineID < vectorList.Count ? vectorList[mathLineID].lineVector : Vector.One;

            isSelectingVector = !isSelectingVector;

            if (isSelectingVector)
            {
                isDrawingVector = false;
                canCreateVector = false;
                isDrawingFreehand = false;
                isMovingLine = false;
                isCopyingLine = false;

                //UpdateBoolChecker("Drawing Line", isDrawingVector, 0);
                //UpdateBoolChecker("Can_Create", canCreateVector, 2);


            }
            else using (MemoryStream ms = new MemoryStream(Properties.Resources.dotSelect_Cursor)) Canvas.Cursor = new Cursor(ms);

            if (isAdding || isSubtracting || isMultiplying || isDividing)
            {
                resultVector = vector;
                DeselectLinePopup();

            }
            if(performingCrossProduct || performingDotProduct)
            {
                resultFloat = 0;
                DeselectLinePopup();

            }

            //UpdateBoolChecker("Select_Line", isSelectingVector, 3); 
            using (MemoryStream ms = new MemoryStream(Properties.Resources.dotSelect_Cursor)) Canvas.Cursor = new Cursor(ms);

            Canvas.Refresh();

        }

        void ToggleCreateLineState()
        {
            isDrawingVector = !isDrawingVector;

            if (isDrawingVector) 
            { 
                canCreateVector = true; 
                isSelectingVector = false;
                isDrawingFreehand = false;
                isMovingLine = false;
                isCopyingLine = false;

            }
            else canCreateVector = false; 

            //UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            //UpdateBoolChecker("Can_Create", canCreateVector, 2);
            //UpdateBoolChecker("Select_Line", isSelectingVector, 3);

        }

        void ToggleFreehandState() 
        {
            isDrawingFreehand = !isDrawingFreehand;

            if (isDrawingFreehand)
            {
                isDrawingVector = false;
                canCreateVector = false;
                isSelectingVector = false;

                startPoint = canvasMousePos;
                
                //UpdateBoolChecker("Drawing Line", isDrawingVector, 0);
                //UpdateBoolChecker("Can_Create", canCreateVector, 2);
                //UpdateBoolChecker("Select_Line", isSelectingVector, 3);

                Canvas.Cursor = Cursors.Cross;

            }
            else 
            { 
                using (MemoryStream ms = new MemoryStream(Properties.Resources.dot_Cursor)) Canvas.Cursor = new Cursor(ms); 
            
            }

            Canvas.Refresh();

            Button_Panel.Refresh();

        }

        void ToggleMoveState()
        {
            isMovingLine = !isMovingLine;

            if (isMovingLine)
            {
                isDrawingVector = false;
                canCreateVector = false;
                isSelectingVector = false;

                resultVector = vectorList[selectedLineID].lineVector;
                RemoveLine();

                //UpdateBoolChecker("Drawing Line", isDrawingVector, 0);
                //UpdateBoolChecker("Can_Create", canCreateVector, 2);
                //UpdateBoolChecker("Select_Line", isSelectingVector, 3);

                DeselectLinePopup();

            }

            Canvas.Refresh();

        }

        void ToggleCopyState()
        {
            isCopyingLine = !isCopyingLine;

            if (isCopyingLine)
            {
                isDrawingVector = false;
                canCreateVector = false;
                isSelectingVector = false;

                resultVector = vectorList[selectedLineID].lineVector;

                //UpdateBoolChecker("Drawing Line", isDrawingVector, 0);
                //UpdateBoolChecker("Can_Create", canCreateVector, 2);
                //UpdateBoolChecker("Select_Line", isSelectingVector, 3);

                DeselectLinePopup();

            }

            Canvas.Refresh();

        }

        void ToggleAddState()
        {
            isAdding = vectorList.Count > 1 ? !isAdding : isAdding;

            if (isAdding)
            {
                UpdateOperatorLabel(0);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;

                DeselectLinePopup();
                DeselectLineGraphics(selectedLineID);
                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        void ToggleSubtractState()
        {
            isSubtracting = vectorList.Count > 1 ? !isSubtracting : isSubtracting;

            if (isSubtracting && vectorList.Count > 1)
            {
                UpdateOperatorLabel(1);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;
                DeselectLinePopup();

                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        void ToggleMultiplyState()
        {
            isMultiplying = vectorList.Count > 1 ? !isMultiplying : isMultiplying ;

            if (isMultiplying && vectorList.Count > 1)
            {
                UpdateOperatorLabel(2);
                MathsRightLabel.Text = String.Format("{0})", mathMultiplier);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;
                MathTrackBar.Visible = true;
                MathTrackBar.Enabled = true;
                DeselectLinePopup();

                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        void ToggleDivideState()
        {
            isDividing = vectorList.Count > 1 ? !isDividing : isDividing;

            if (isDividing && vectorList.Count > 1)
            {
                UpdateOperatorLabel(3);
                MathsRightLabel.Text = String.Format("{0})", mathMultiplier);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;
                MathTrackBar.Visible = true;
                MathTrackBar.Enabled = true;
                DeselectLinePopup();

                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        void ToggleDotProductState()
        {
            performingDotProduct = vectorList.Count > 1 ? !performingDotProduct : performingDotProduct;

            if (performingDotProduct && vectorList.Count > 1)
            {
                UpdateOperatorLabel(0);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;
                DeselectLinePopup();

                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        void ToggleCrossProductState()
        {
            performingCrossProduct = vectorList.Count > 1 ? !performingCrossProduct : performingCrossProduct;

            if (performingCrossProduct && vectorList.Count > 1)
            {
                UpdateOperatorLabel(1);

                SelectedMathsPanel.Visible = true;
                SelectedMathsPanel.Enabled = true;
                DeselectLinePopup();

                mathLineID = selectedLineID;
                ToggleSelectMode();

            }

        }

        #endregion

        #region User_Input

        Point GetMousePositionToCanvas()
        {
            int x = PointToClient(MousePosition).X - Canvas.Location.X;
            int y = PointToClient(MousePosition).Y - Canvas.Location.Y;

            prevX = PointToClient(MousePosition).X - Canvas.Location.X;
            prevY = PointToClient(MousePosition).Y - Canvas.Location.Y;

            return new Point(x, y); 
        
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            int delta = (int)(e.Delta * 0.01f);

            if (SelectRadiusIncrementor.Value + delta <= SelectRadiusIncrementor.Maximum && SelectRadiusIncrementor.Value + delta >= SelectRadiusIncrementor.Minimum)
            {
                if (isSelectingVector || isDrawingFreehand) SelectRadiusIncrementor.Value += delta;

                if (isDrawingVector) LineThicknessIncrement.Value += delta;

            }

            Canvas.Refresh();

        }

        private void Canvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Create Mode
            if (e.KeyCode == Keys.Space)
            {
                ToggleCreateLineState();
                DeselectLinePopup();

            }

            //Select Mode
            if (e.KeyCode == Keys.Z) ToggleSelectMode();

            //Delete Line
            if (e.KeyCode == Keys.X)
            {
                if (vectorList.Count > 0)
                {
                    RemoveLine();

                }

            }

            //Colour change
            if (e.KeyCode == Keys.C)
            {
                CurrentLineColor.ShowDialog();
                lineColor = CurrentLineColor.Color;
                LineColorButton.ForeColor = lineColor;

            }

            //Freehand Brush
            if(e.KeyCode == Keys.B) ToggleFreehandState();

            //Line Width
            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.ShiftKey ) && LineThicknessIncrement.Value < LineThicknessIncrement.Maximum) { LineThicknessIncrement.Value += 1; }
            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.ControlKey ) && LineThicknessIncrement.Value > LineThicknessIncrement.Minimum) { LineThicknessIncrement.Value -= 1; }

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canvasPressed = true;

            if (isDrawingVector)  startPoint = canvasMousePos;

            if (isSelectingVector)
            {
                UpdateVectorStatsLabels(vectorList[selectedLineID]);
                SelectLinePopup();
                isSelectingVector = false;

            }

            if (isDrawingFreehand) 
            {
                drawBrush = new SolidBrush(lineColor);
                DrawCircle(Graphics.FromImage(renderImage), drawBrush, canvasMousePos.X, canvasMousePos.Y, selectRadius, true);

            }
            else using (MemoryStream ms = new MemoryStream(Properties.Resources.pressed_Cursor)) Canvas.Cursor = new Cursor(ms);

            if(isAdding || isSubtracting || isMultiplying || isDividing || isMovingLine || isCopyingLine || performingDotProduct || performingCrossProduct)
            {
                Color originalColor = lineColor;

                if (isAdding || isSubtracting || isMultiplying || isDividing || isMovingLine || isCopyingLine)
                {
                    CurrentLineColor.ShowDialog();
                    lineColor = CurrentLineColor.Color;

                    Create_Line(canvasMousePos, new Point(resultVector.X + canvasMousePos.X, resultVector.Y + canvasMousePos.Y));

                }

                SelectedMathsPanel.Visible = false;
                SelectedMathsPanel.Enabled = false;
                MathTrackBar.Visible = false;
                MathTrackBar.Enabled = false;

                lineColor = originalColor;
                isAdding = false;
                isSubtracting = false;
                isMultiplying = false;
                isDividing = false;
                performingDotProduct = false;
                performingCrossProduct = false;
                isMovingLine = false;
                isCopyingLine = false;

                Canvas.Refresh();

            }

            //UpdateBoolChecker("Mouse_Down", canvasPressed, 1);

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            canvasReleased = true;
            canvasPressed = false;
            isDrawingVector = false;

            //UpdateBoolChecker("Select_Line", isSelectingVector, 3);
            //UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            //UpdateBoolChecker("DrawingLine", isDrawingVector, 0);

            if (!isDrawingFreehand) using (MemoryStream ms = new MemoryStream(Properties.Resources.dot_Cursor)) Canvas.Cursor = new Cursor(ms);

            Canvas.Refresh();

        }

        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            onCanvas = true;
            Canvas.Focus();
            DeselectLinePopup();

        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            onCanvas = false;
            canvasPressed = false;
            //UpdateBoolChecker("Mouse_Down", canvasPressed, 1);
            //UpdateBoolChecker("DrawingLine", isDrawingVector, 0);
            Button_Panel.Focus();

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseXLabel.Text = "MouseX: " + canvasMousePos.X;
            mouseYLabel.Text = "MouseY: " + canvasMousePos.Y;

            canvasMousePos = GetMousePositionToCanvas();

            if (isSelectingVector)
            {
                if (isAdding) resultVector = vectorList[mathLineID].lineVector + vectorList[selectedLineID].lineVector;

                if (isSubtracting) resultVector = vectorList[mathLineID].lineVector - vectorList[selectedLineID].lineVector;

                if (isMultiplying && mathMultiplier != 0) resultVector = vectorList[mathLineID].lineVector * mathMultiplier;

                if (isDividing && mathMultiplier != 0) resultVector = vectorList[mathLineID].lineVector / mathMultiplier;

                if (performingDotProduct) resultFloat = Vector.DotProduct(vectorList[mathLineID].lineVector, vectorList[selectedLineID].lineVector);
                if (performingCrossProduct) resultFloat = Vector.CrossProduct(vectorList[mathLineID].lineVector, vectorList[selectedLineID].lineVector);

                CursorCircleSelect(selectRadius);
                Canvas.Refresh();

            }

            if (isDrawingFreehand)
            {
                if (canvasPressed)
                {
                    Graphics graphics = Canvas.CreateGraphics();
                    drawPen.Color = lineColor;
                    graphics.DrawLine(drawPen, startPoint, canvasMousePos);
                    renderGraphics.DrawLine(drawPen, startPoint, canvasMousePos);

                    startPoint = canvasMousePos;

                }

            }

            if (isDrawingVector || (isDrawingFreehand && !canvasPressed) || isAdding || isSubtracting || isMultiplying || isDividing || isMovingLine || isCopyingLine || performingDotProduct || performingCrossProduct) Canvas.Refresh();

        }

        private void SelectPopupPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (VectorMathsPanel.Visible)
            {
                PopupFollowMouse(VectorMathsPanel);

            }
        }

        private void VectorMathsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProductPopupPanel.Visible)
            {
                PopupFollowMouse(ProductPopupPanel);

            }
        }

        #endregion

        #region UI Input

        #region Timer

        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (timerRunning) { timerRunning = false; }
            else { timerRunning = true; }
            if (!TimerWorker.IsBusy) { TimerWorker.RunWorkerAsync(); }
            //UpdateBoolChecker("Timer_Run", timerRunning, 2);

            Button_Panel.Refresh();

        }

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

        private void timerWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TimerButton.Text = timerOut;
        }

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            isRunning = false;

            if (TimerWorker.WorkerSupportsCancellation) { TimerWorker.CancelAsync(); }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USE Vector_Math_Tool; DELETE FROM POINTS", connection);
                command.ExecuteNonQuery();

            }

            Application.Exit();

        }

        private void HeaderText_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vector Tools by Gin0ss || V. 1");

            HeaderText_1.Refresh();
        }

        private void CreateVectorButton_Click(object sender, EventArgs e)
        {
            ToggleCreateLineState();

            Button_Panel.Refresh();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            renderImage = new Bitmap(Width, Height);
            Canvas.Image = renderImage;
            renderGraphics = Graphics.FromImage(renderImage);

            mathLineID = 0;
            selectedLineID = 0;

            vectorList.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USE Vector_Math_Tool; DELETE FROM POINTS", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            label5.Text = "Line Count: 0";

            DeselectLinePopup();
            Canvas.Refresh();
            Button_Panel.Refresh();

        }

        private void GuideColorButton_Click(object sender, EventArgs e)
        {
            CurrentGuideColor.ShowDialog();
            guideColor = CurrentGuideColor.Color;
            GuideColorButton.ForeColor = guideColor;

            Button_Panel.Refresh();

        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            CurrentLineColor.ShowDialog();
            lineColor = CurrentLineColor.Color;
            LineColorButton.ForeColor = lineColor;

            Button_Panel.Refresh();

        }

        private void SelectVectorButton_Click(object sender, EventArgs e)
        {
            ToggleSelectMode();

            Button_Panel.Refresh();

        }

        private void DeleteVectorButton_Click(object sender, EventArgs e)
        {
            RemoveLine();

            Button_Panel.Refresh();

        }

        private void SidePanelMinimizeButton_Click(object sender, EventArgs e)
        {
            isSidePanelVisible = isSidePanelVisible ? false : true;

            if(isSidePanelVisible)
            {
                Button_Panel.Visible = true;
                Button_Panel.Enabled = true;
                SidePanelMinimizeButton.Text = "-";
                SidePanelMinimizeButton.BackColor = Color.DarkRed;

                Canvas.Width = this.ClientSize.Width - Button_Panel.Size.Width - 29;

            }

            else
            {
                Button_Panel.Visible = false;
                Button_Panel.Enabled = false;
                SidePanelMinimizeButton.Text = "+";
                SidePanelMinimizeButton.BackColor = Color.Red;

                Canvas.Width = this.ClientSize.Width - 24;

            }

            Button_Panel.Refresh();

        }

        private void MaximizeScreenButton_Click(object sender, EventArgs e)
        {
            isMaximized = !isMaximized;
            isBordered = false;

            if (isMaximized)
            {
                originalWindowWidth = this.Width;
                originalWindowHeight = this.Height;
                originalWindowPos = this.Location;

                this.Location = new Point(0, 0);
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;

            }
            else
            {
                if (originalWindowPos != Point.Empty)
                {
                    this.Location = originalWindowPos;
                    this.Width = originalWindowWidth;
                    this.Height = originalWindowHeight;

                }
                else
                {
                    this.Width = 1280;
                    this.Height = 720;

                }
            }

            renderImage = new Bitmap(renderImage, Width, Height);
            Canvas.Image = renderImage;

            Button_Panel.Refresh();
        }

        private void ToggleBorderButton_Click(object sender, EventArgs e)
        {
            isBordered = !isBordered;
            isMaximized = false;

            if (isBordered)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;

                if (isMaximized)
                {
                    this.Location = originalWindowPos;
                    this.Width = originalWindowWidth;
                    this.Height = originalWindowHeight;

                }
            }

            else { this.FormBorderStyle = FormBorderStyle.None; }

            renderImage = new Bitmap(renderImage, Width, Height);
            Canvas.Image = renderImage;

            Button_Panel.Refresh();

        }

        private void FreehandBrushButton_Click(object sender, EventArgs e)
        {
            ToggleFreehandState();

        }

        private void SelectRadiusIncrementor_ValueChanged(object sender, EventArgs e)
        {
            selectRadius = (int)SelectRadiusIncrementor.Value;
            drawPen.Width = selectRadius * 2;

            Button_Panel.Refresh();

        }

        private void LineThicknessIncrement_ValueChanged(object sender, EventArgs e)
        {
            LineWidth = (int)((float)LineThicknessIncrement.Value * 1.25f);

            Button_Panel.Refresh();

        }

        private void Vector_Form_Resize(object sender, EventArgs e)
        {
            ResizeCanvas();

        }

        #region Popup UI

        private void PopupVectorMathsButton_Click(object sender, EventArgs e)
        {
            VectorMathsPanel.Location = new Point((SelectPopupPanel.Width + SelectPopupPanel.Location.X), GetMousePositionToCanvas().Y);

            VectorMathsPanel.Visible = true;
            VectorMathsPanel.Enabled = true;

        }

        private void VectorMathsButton_Click(object sender, EventArgs e)
        {
            VectorMathsPanel.Location = new Point(Button_Panel.Location.X - VectorMathsPanel.Width, GetMousePositionToCanvas().Y);

            VectorMathsPanel.Visible = true;
            VectorMathsPanel.Enabled = true;

        }

        private void PopupMoveLineButton_Click(object sender, EventArgs e)
        {
            ToggleMoveState();
            DeselectLinePopup();

        }

        private void PopupCopyLineButton_Click(object sender, EventArgs e)
        {
            ToggleCopyState();
            DeselectLinePopup();

        }

        private void AddVectorButton_Click(object sender, EventArgs e)
        {
            ToggleAddState();

        }

        private void SubtractVectorButton_Click(object sender, EventArgs e)
        {
            ToggleSubtractState();

        }

        private void MultiplyVectorButton_Click(object sender, EventArgs e)
        {
            ToggleMultiplyState();

        }

        private void DivideVectorButton_Click(object sender, EventArgs e)
        {
            ToggleDivideState();

        }

        private void DotProductButton_Click(object sender, EventArgs e)
        {
            ToggleDotProductState();

        }

        private void CrossProductButton_Click(object sender, EventArgs e)
        {
            ToggleCrossProductState();

        }

        private void ProductVectorButton_Click(object sender, EventArgs e)
        {
            ProductPopupPanel.Location = new Point(VectorMathsPanel.Location.X + VectorMathsPanel.Width, GetMousePositionToCanvas().Y);

            ProductPopupPanel.Visible = true;
            ProductPopupPanel.Enabled = true;

        }

        private void MathTrackBar_Scroll(object sender, EventArgs e)
        {
            mathMultiplier = MathTrackBar.Value * 0.1f;
            MathsRightLabel.Text = "" + mathMultiplier;
            MathsRightLabel.Text = String.Format("{0})", mathMultiplier);

            Canvas.Refresh();

        }

        #endregion

        #endregion

    }

}
