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

        Graphics graphics;
        Brush drawBrush;
        Pen drawPen;

        Color currentColor;

        Point windowCentre;
        Point screenCentre;
        Size drawSize;

        Stopwatch runTimer = new Stopwatch();

        bool timerRunning = false;
        bool isDrawing = false;
        string timerOut;

        #endregion

        public Vector_Form()
        {
            runTimer.Start();
            InitializeComponent();

        }

        #region Graphics
        private void Vector_Graphics_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            currentColor = Color.FromArgb(255, 16, 255, 8);
            drawBrush = new SolidBrush(currentColor);
            drawPen = new Pen(currentColor);

            screenCentre = new Point(Screen.FromPoint(Point.Empty).Bounds.Width / 2, Screen.FromPoint(Point.Empty).Bounds.Height / 2);
            windowCentre = new Point(Width / 2, Height / 2);
            drawSize = new Size(8, 8);

            Cursor.Position = screenCentre;
            ClearScreen();

        }

        public void UpdateLine()
        {
            ClearScreen();
            Cursor.Position = screenCentre;
            isDrawing = true;
            currentColor = Color.FromArgb(128, 12, 220, 12);
            graphics.DrawLine(drawPen, new Point(MousePosition.X - windowCentre.X, MousePosition.Y - windowCentre.Y), windowCentre);

        }

        public void ClearScreen(PaintEventArgs e)
        {
            graphics.Clear(BackColor);
            //Other graphical constants

        }

        #endregion

        #region User_Input
        private void Vector_Form_Click(object sender, EventArgs e)
        {
            if (isDrawing)
            {
                currentColor = Color.FromArgb(255, 16, 255, 8);
                graphics.DrawLine(drawPen, new Point(MousePosition.X - windowCentre.X, MousePosition.Y - windowCentre.Y), windowCentre);
                isDrawing = false;
            }
        }

        #endregion

        #region Buttons
        //Closes App
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (timerWorker.WorkerSupportsCancellation) { timerWorker.CancelAsync(); }
            Application.Exit();

        }

        //Title text on click shows info
        private void HeaderText_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vector Tools by Gin0ss || V. 0.03");
        }

        #region Timer
        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (timerRunning) { timerRunning = false; }
            else { timerRunning = true; }
            if (!timerWorker.IsBusy) { timerWorker.RunWorkerAsync(); }

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

        #endregion

        private void CreateVector_Click(object sender, EventArgs e)
        {
            UpdateLine();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

    }
}
