using System;
using System.Drawing;
using Ginoss_Tools;

namespace Vector_Maths_Tool
{
    public class Vector_Shapes
    {
        public int index;
        public int LineWidth { get; }

        public Color LineColor { get; }
        public Pen drawPen;
        public Brush drawBrush;

        public Point[] linePoints;

        public Vector lineVector;

        public Vector_Shapes(Point startPoint, Point endPoint, int lineWidth, Color lineColor)
        {
            LineColor = lineColor;
            drawPen = new Pen(lineColor, lineWidth);
            drawBrush = new SolidBrush(lineColor);

            Console.Write("Line at ( " + startPoint + " : " + endPoint + " ) Created");
            Console.WriteLine(" with Line Width: " + lineWidth);
            linePoints = new Point[] { startPoint, endPoint };
            LineWidth = lineWidth;

            lineVector = new Vector();

        }

    }
}
