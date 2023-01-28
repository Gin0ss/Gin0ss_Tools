using System;
using System.Drawing;

namespace Ginoss_Tools
{
    public struct Vector
    {

        #region Variables

        private float x;
        private float y;

        //Properties
        public float fX
        {
            get { return x; }
            set { x = value; }
        }

        public float fY
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return (int)x; }
            set { x = value; }
        }

        public int Y
        {
            get { return (int)y; }
            set { y = value; }
        }

        public static Vector One { get { return new Vector(1, 1); } }

        public static Vector Zero { get { return new Vector(0, 0); } }

        public static Vector Right { get { return new Vector(1, 0); } }

        public static Vector Up { get { return new Vector(0, 1); } }

        #endregion

        #region Constructors

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

        #endregion

        #region Functions

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

        public float DotProduct(Vector a, Vector b)
        {
            return (a.X * b.X) + (a.Y * b.Y);

        }

        public float CrossProduct(Vector a, Vector b)
        {
            return (a.X * b.X) - (a.Y * b.Y);

        }

        #endregion

        #region Operator Overloads

        public static Vector operator+(Vector a, Vector b)
        {
            float x = a.X + b.X;
            float y = a.Y + b.Y;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator+(Vector a, float b)
        {
            float x = a.X + b;
            float y = a.Y + b;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator+(Vector a, int b)
        {
            float x = a.X + b;
            float y = a.Y + b;

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

        public static Vector operator-(Vector a, float b)
        {
            float x = a.X - b;
            float y = a.Y - b;

            Vector result = new Vector(x, y);
            return result;


        }

        public static Vector operator-(Vector a, int b)
        {
            float x = a.X - b;
            float y = a.Y - b;

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

        public static Vector operator*(Vector a, float b)
        {
            float x = a.X * b;
            float y = a.Y * b;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator*(Vector a, int b)
        {
            float x = a.X * b;
            float y = a.Y * b;

            Vector result = new Vector(x, y);
            return result;

        }

        public static Vector operator/(Vector a, Vector b)
        {
            if (a.X != 0|| a.Y != 0|| b.X != 0|| b.Y != 0)
            {
                float x = a.X / b.X;
                float y = a.Y / b.Y;

                Vector result = new Vector(x, y);
                return result;
            }
            else
            {
                Console.WriteLine("Returning (1, 1) !!!Can't divide by zero!!!");
                return Vector.One;

            }

        }

        public static Vector operator/(Vector a, float b)
        {
            if (a.X != 0|| a.Y != 0|| b != 0)
            {
                float x = a.X / b;
                float y = a.Y / b;

                Vector result = new Vector(x, y);
                return result;
            }
            else
            {
                Console.WriteLine("Returning (1, 1) !!!Can't divide by zero!!!");
                return Vector.One;

            }

        }

        public static Vector operator/(Vector a, int b)
        {
            if (a.X != 0|| a.Y != 0|| b != 0)
            {
                float x = a.X / b;
                float y = a.Y / b;

                Vector result = new Vector(x, y);
                return result;
            }
            else
            {
                Console.WriteLine("Returning (1, 1) !!!Can't divide by zero!!!");
                return Vector.One;

            }

        }
        
        public static Boolean operator==(Vector a, Vector b)
        {
            return (a.X == b.X && a.Y == b.Y);

        }

        public static Boolean operator!=(Vector a, Vector b)
        {
            return (a.X != b.X && a.Y != b.Y);

        }

        public static implicit operator Point(Vector vector)
        {
            return new Point((int)vector.X, (int)vector.Y);

        }

        #endregion

    }
}