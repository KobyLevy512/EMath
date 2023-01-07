

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

        /// <summary>
        /// Return the magnitude of this vector
        /// </summary>
        public double Magnitude
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        /// <summary>
        /// Return Normalize vector from this vector
        /// </summary>
        /// <returns></returns>
        public Vector2 Normalize()
        {
            double mag = Math.Sqrt(X * X + Y * Y);
            return new Vector2(X / mag, Y / mag);
        }

        /// <summary>
        /// Return the Dot Product between this vector to other vector
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Dot(Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }
        /// <summary>
        /// Return the Cross Product between this vector to other vector
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Cross(Vector2 other)
        {
            return X * other.Y - Y * other.X;
        }

        /// <summary>
        /// Return the angle of this vector with other
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Angle(Vector2 other)
        {
            return Math.Atan2(Y - other.Y, X - other.X);
        }

        /// <summary>
        /// Return distance from this vector to other
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public double Distance(Vector2 other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Rotate this vector around{0,0} origin by angle
        /// </summary>
        /// <param name="angle"></param>
        public void Rotate(double angle)
        {
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double dx = X * cos + Y * -sin;
            Y = X * sin + Y * cos;
            X = dx;
        }
        /// <summary>
        /// Return Linear Interpolation between this vector to other
        /// </summary>
        /// <param name="other"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public Vector2 Lerp(Vector2 other,double ratio)
        {
            return new Vector2(X + ratio * (other.X - X), Y + ratio * (other.Y - Y));
        }

        public static implicit operator Vector2(double f)
        {
            return new Vector2(f, f);
        }
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector2 operator +(Vector2 v1, double d)
        {
            return new Vector2(v1.X + d, v1.Y + d);
        }
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vector2 operator -(Vector2 v1, double d)
        {
            return new Vector2(v1.X - d, v1.Y - d);
        }
        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vector2 operator *(Vector2 v1, double d)
        {
            return new Vector2(v1.X * d, v1.Y * d);
        }
        public static Vector2 operator /(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X / v2.X, v1.Y / v2.Y);
        }
        public static Vector2 operator /(Vector2 v1, double d)
        {
            return new Vector2(v1.X / d, v1.Y / d);
        }
        public static Vector2 operator %(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X % v2.X, v1.Y % v2.Y);
        }
        public static Vector2 operator %(Vector2 v1, double d)
        {
            return new Vector2(v1.X % d, v1.Y % d);
        }
        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return v1.X != v2.X || v1.Y != v2.Y;
        }
    }
}
