using System;
using System.Drawing;

namespace Ginoss_Tools
{
    public struct Vector
    {
        private float x;
        private float y;

        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;

        }

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public Vector(Point point)
        {
            Vector result = new Vector(point.X, point.Y);

            x = result.X;
            y = result.Y;

        }

        public Vector(Point point1, Point point2)
        {
            Vector result = new Vector(point2.X - point1.X, point2.Y - point1.Y);

            x = result.X;
            y = result.Y;

        }

        //Property Set
        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector CreateFromPoints(Point point1, Point point2)
        {
            return new Vector(point2.X - point1.X, point2.Y - point1.Y);

        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((this.X * this.X) + (this.Y * this.Y));

        }

        public Vector Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0) { return new Vector(this.X / magnitude, this.Y / magnitude); }
            else 
            {
                Console.WriteLine("!!! Error Magnitude is 0 !!!");
                return this;
            
            }

        }

        #region Operator Overloads

        public static Vector operator+(Vector a, Vector b)
        {
            float x = a.X + b.X;
            float y = a.Y + b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator-(Vector a, Vector b)
        {
            float x = a.X - b.X;
            float y = a.Y - b.Y;

            Vector result = new Vector(x, y);
            return result;


        }

        public static Vector operator*(Vector a, Vector b)
        {
            float x = a.X * b.X;
            float y = a.Y * b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator/(Vector a, Vector b)
        {
            float x = a.X / b.X;
            float y = a.Y / b.Y;

            Vector result = new Vector(x, y);
            return result;

        }
        
        public static Boolean operator==(Vector a, Vector b)
        {
            return (a.X == b.X && a.Y == b.Y);

        }

        public static Boolean operator!=(Vector a, Vector b)
        {
            return (a.X != b.X && a.Y != b.Y);

        }

        #endregion

    }
}