using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Vector2D
    {
        private double X;
        private double Y;
        public Vector2D(double[] data);
        public Vector2D(double x, double y);
        public static Vector2D CreateVector2D(double r, double radianTheta);
        public static Vector2D operator -(Vector2D v);
        public static Vector2D operator -(Vector2D v1, Vector2D v2);
        public static bool operator !=(Vector2D left, Vector2D right);
        public static Vector2D operator *(double d, Vector2D v);
        public static Vector2D operator *(Vector2D v, double d);
        public static Vector2D operator /(Vector2D v, double d);
        public static Vector2D operator +(Vector2D v1, Vector2D v2);
        public static bool operator ==(Vector2D left, Vector2D right);
        public double Length { get; }
        public static Vector2D XAxis { get; }
        public static Vector2D YAxis { get; }
        public Vector2D Add(Vector2D v);
        public double AngleTo(Vector2D toVector2D);
        public double CrossProduct(Vector2D other);
        public double DotProduct(Vector2D other);
        public bool Equals(Vector2D other);
        public bool Equals(Vector2D other, double tolerance);
        public bool IsParallelTo(Vector2D othervector, double tolerance = 1e-010);
        public bool IsPerpendicularTo(Vector2D othervector, double tolerance = 1e-010);
        public Vector2D Negate();
        public Vector2D Normalize();
        public static Vector2D Parse(string value);
        public Vector2D ProjectOn(Vector2D other);
        public Vector2D Rotate(double angle);
        public Vector2D ScaleBy(double d);
        public double SignedAngleTo(Vector2D v2, bool clockWise, bool returnNegative = false);
        public Vector2D Subtract(Vector2D v);
        public override string ToString();
    }
}
