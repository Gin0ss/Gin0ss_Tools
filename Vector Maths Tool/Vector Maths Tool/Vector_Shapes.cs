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
        public Color currentColor = Color.FromArgb(255, 16, 255, 8);
        public Pen drawPen = new Pen(Color.FromArgb(255, 16, 255, 8));
        public Brush drawBrush = new SolidBrush(Color.FromArgb(255, 16, 255, 8));

        public int index;

        public Point[] linePoints;

        public Vector_Shapes(Point startPoint, Point endPoint)
        {
            Console.WriteLine("Line at ( " + startPoint + " : " + endPoint + " ) Created"); //Debug Line CoOrds
            linePoints = new Point[] { startPoint, endPoint };

        }

    }
}
