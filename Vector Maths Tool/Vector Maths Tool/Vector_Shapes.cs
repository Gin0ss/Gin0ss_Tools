using System;
using System.Drawing;
using Ginoss_Tools;

namespace Vector_Maths_Tool
{
    public class Vector_Shapes
    {
        public int LineWidth { get; }
        public float lineGradient { get; }

        public Color LineColor { get; }
        public Pen drawPen;
        public Brush drawBrush;

        public Point[] linePoints; //May need to change this so it isn't as confusing to code below and change code accessing variable
        //public Point startPoint;
        //public Point endPoint;

        public Vector lineVector;

        public Vector_Shapes(Point startPoint, Point endPoint, int lineWidth, Color lineColor)
        {
            LineColor = lineColor;
            drawPen = new Pen(lineColor, lineWidth);
            drawBrush = new SolidBrush(lineColor);

            linePoints = new Point[] { startPoint, endPoint };
            LineWidth = lineWidth;

            lineVector = new Vector(startPoint, endPoint);

            if (startPoint != endPoint) { lineGradient = lineVector.Y / lineVector.X; }
            else { lineGradient = 0; }


        }

    }
}
