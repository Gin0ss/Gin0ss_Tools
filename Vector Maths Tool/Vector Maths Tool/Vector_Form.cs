using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vector_Maths_Tool
{
    public partial class Vector_Form : Form
    {
        Graphics graphics;
        Brush drawBrush;
        Pen drawPen;

        Color currentColor;

        Point windowCentre;
        Point screenCentre;
        Size drawSize;

        public Vector_Form()
        {
            InitializeComponent();
        }

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
            graphics.DrawLine(drawPen, new Point(MousePosition.X - windowCentre.X, MousePosition.Y - windowCentre.Y), windowCentre);

        }

        public void ClearScreen()
        {
            graphics.Clear(BackColor);
            graphics.FillEllipse(drawBrush, new Rectangle(windowCentre, drawSize));

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void HeaderText_1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vector Tools by Gin0ss || V. 0.01");
        }
    }
}
