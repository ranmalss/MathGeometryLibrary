using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Point3D
    {
        private double X;
        private double Y;
        private double Z;
        public Point3D(double[] data);
        public Point3D(double x, double y, double z);
        public static Vector3D operator -(Point3D lhs, Point3D rhs);
        public static Point3D operator -(Point3D p, Vector3D v);
        public static bool operator !=(Point3D left, Point3D right);
        public static Point3D operator +(Point3D p, Vector3D v);
        public static bool operator ==(Point3D left, Point3D right);
        public static Point3D Origin { get; }
        public static Point3D Centroid(IEnumerable<Point3D> points);
        public static Point3D Centroid(params Point3D[] points);
        public double DistanceTo(Point3D p);
        public override bool Equals(Object other);
        public bool Equals(Point3D other);
        public bool Equals(Point3D other, double tolerance);
        //public static Point3D IntersectionOf(Plane plane, Ray3D ray);
        //public static Point3D IntersectionOf(Plane plane1, Plane plane2, Plane plane3);
        //public Point3D MirrorAbout(Plane plane);
        //public Point3D ProjectOn(Plane plane);
        public static Point3D MidPoint(Point3D p1, Point3D p2);
        public static Point3D Parse(string s);
        public Point3D Rotate(Vector3D aboutVector, double angle);
        public override string ToString();
        public Vector3D ToVector3D();
        public Vector3D VectorTo(Point3D p);
    }
}
