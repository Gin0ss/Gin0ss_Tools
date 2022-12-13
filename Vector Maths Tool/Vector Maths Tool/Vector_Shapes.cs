using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Maths_Tool
{
    public class Vector_Shapes
    {
        public Color currentColor;
        public Pen drawPen = new Pen(Color.FromArgb(255, 16, 255, 8));
        public Brush drawBrush = new SolidBrush(Color.FromArgb(255, 16, 255, 8));

        public int index;

        public Point[] linePoints;

        public Vector_Shapes(Point[] points, Graphics g)
        {
            linePoints = points;

        }

        public void Draw_Line()
        {
            currentColor = Color.FromArgb(255, 16, 255, 8);

            Pen drawPen = new Pen(currentColor);
            Brush drawBrush = new SolidBrush(currentColor);

        }

    }
}
