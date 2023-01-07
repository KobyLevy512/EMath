

using System;

namespace ConsoleApp3.ExtendMath
{
    internal struct Vector2
    {
        public double X, Y;

        public Vector2(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public double Magnitude
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public static implicit operator Vector2(double f)
        {
            return new Vector2(f, f);
        }
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
    }
}
