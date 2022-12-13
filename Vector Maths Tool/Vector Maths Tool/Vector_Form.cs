using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vector_Maths_Tool
{
    public partial class Vector_Form : Form
    {
        #region Variables

        Graphics graphics = null;

        Color currentColor = Color.FromArgb(255, 16, 255, 8);
        Point canvasCentre;
        Point startPoint;

        Stopwatch runTimer = new Stopwatch();

        static PictureBox[] boolCheckers;
        static Label[] boolLabels;

        bool timerRunning = false;
        bool isDrawingVector = false;
        bool canvasPressed = false;

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
            PictureBox[] a = { Bool_Check_0, Bool_Check_1, Bool_Check_2 };
            Label[] b = { Bool_Label_0, Bool_Label_1, Bool_Label_2 };

            boolCheckers = a;
            boolLabels = b;
        }

        #region Graphics

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            canvasCentre = new Point(Canvas.Width / 2, Canvas.Height / 2);
            Pen drawPen = new Pen(currentColor);
            Brush drawBrush = new SolidBrush(currentColor);

            Console.WriteLine(canvasPressed);
            if (canvasPressed && isDrawingVector)
            {
                drawLine(drawPen, ref startPoint, Cursor.Position);

            }

        }

        void drawLine(Pen pen, ref Point lineStart, Point lineEnd)
        {
            Point[] linePoints =
            {
                lineStart,
                lineEnd

            };
            graphics.DrawLine(pen, linePoints[0], linePoints[1]);
            lineStart = lineEnd;

        }


        #endregion

        #region User_Input

        //Vector Canvas clicked on
        private void Canvas_Click(object sender, EventArgs e)
        {
            Canvas.Refresh();
            if (!canvasPressed)
            {
                canvasPressed = true;
                isDrawingVector = false;
                canvasPressed = false;
                UpdateBoolChecker("Create_Vector", isDrawingVector, 0);

            }

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
            Console.WriteLine("Vector Tools by Gin0ss || V. 0.05");
        }

        #region Timer
        //Timer Button CLicked
        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (timerRunning) { timerRunning = false; }
            else { timerRunning = true; }
            if (!TimerWorker.IsBusy) { TimerWorker.RunWorkerAsync(); }

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

        private void CreateVector_Click(object sender, EventArgs e)
        {
            if (!isDrawingVector) { isDrawingVector = true; }
            else { isDrawingVector = false; }
            UpdateBoolChecker("Create_Vector", isDrawingVector, 0);
            Canvas.Refresh();
        }

        //Clears Screen
        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
