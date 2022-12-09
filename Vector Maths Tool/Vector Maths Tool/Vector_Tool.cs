using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Maths_Tool
{
    public partial class Vector_Tool : Form
    {
        public Vector_Tool()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Color currentColor = Color.FromArgb(255, 16, 255, 8);
            Brush drawBrush = new SolidBrush(currentColor);
            Pen drawPen = new Pen(currentColor);

            Point screenCentre = new Point(Width / 2, Height / 2);
            Point position1 = new Point(64, 64);
            Point position2 = new Point(128, 128);
            Size drawSize = new Size(8, 8);

            graphics.DrawLine(drawPen, position1, screenCentre);
            graphics.FillEllipse(drawBrush, new Rectangle(screenCentre, drawSize));

        }
    }
}
