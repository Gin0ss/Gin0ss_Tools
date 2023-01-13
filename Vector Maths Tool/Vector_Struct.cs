using System;
using System.Drawing;

namespace Ginoss_Tools
{
    public struct Vector
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;

        }

        public Vector(Point point1, Point point2)
        {
            X = 0;
            Y = 0;

            Vector result = GetVectorFromPoints(point1, point2);

            X = result.X;
            Y = result.Y;


        }

        public Vector GetVectorFromPoints(Point point1, Point point2)
        {
            return new Vector(point2.X - point1.X, point2.Y - point1.Y);

        }

        public float Magnitude(Vector vector)
        {
            return (float)Math.Sqrt((vector.X * vector.X) + (vector.Y * vector.Y));

        }

        public Vector Normalize(Vector vector)
        {
            float magnitude = Magnitude(vector);

            return new Vector(vector.X / magnitude, vector.Y / magnitude);

        }

        #region Operator Overloads

        public static Vector operator +(Vector a, Vector b)
        {
            float x = a.X + b.X;
            float y = a.Y + b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator -(Vector a, Vector b)
        {
            float x = a.X - b.X;
            float y = a.Y - b.Y;

            Vector result = new Vector(x, y);
            return result;


        }

        public static Vector operator *(Vector a, Vector b)
        {
            float x = a.X * b.X;
            float y = a.Y * b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator /(Vector a, Vector b)
        {
            float x = a.X / b.X;
            float y = a.Y / b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        #endregion

    }
}