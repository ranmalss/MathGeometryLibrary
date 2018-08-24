using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Point2D
    {
        private double X;
        private double Y;
        public Point2D(double[] data);
        public Point2D(double x, double y);
        public static Point2D CreatePoint2D(double r, double radianTheta);
        public static Vector2D operator -(Point2D lhs, Point2D rhs);
        public static Point2D operator -(Point2D point, Vector2D vector);
        public static bool operator !=(Point2D left, Point2D right);
        public static Point2D operator +(Point2D point, Vector2D vector);
        public static bool operator ==(Point2D left, Point2D right);
        public static Point2D Origin { get; }
        public static Point2D Centroid(IEnumerable<Point2D> points);
        public static Point2D Centroid(params Point2D[] points);
        public double DistanceTo(Point2D otherPoint);
        public override bool Equals(object obj);
        public bool Equals(Point2D other);
        public bool Equals(Point2D other, double tolerance);
        public static Point2D MidPoint(Point2D point1, Point2D point2);
        public static Point2D Parse(string value);
        public Point3D ToPoint3D();
        public override string ToString();
        public Vector2D ToVector2D();
        public Vector2D VectorTo(Point2D otherPoint);
    }
}
