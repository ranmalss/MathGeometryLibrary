using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Plane
    {
        private double A;
        private double B;
        private double C;
        private double D;

        public Vector3D Normal;
        public readonly Point3D RootPoint;

        public Plane(Point3D rootPoint, Point3D normal);
        public Plane(Point3D normal, double offset = 0);
        public Plane(Point3D normal, Point3D rootPoint);
        public Plane(Point3D p1, Point3D p2, Point3D p3);
        public Plane(double a, double b, double c, double d);
        public static bool operator !=(Plane left, Plane right);
        public static bool operator ==(Plane left, Plane right);
        public double AbsoluteDistanceTo(Point3D point);
        public override bool Equals(object obj);
        public bool Equals(Plane other);
        public Point3D? IntersectionWith(Line3D line, double tolerance = 1.4013e-045);
        public Point3D MirrorAbout(Point3D p);
        public static Plane Parse(string s);
        public static Point3D PointFromPlanes(Plane plane1, Plane plane2, Plane plane3);
        public Line3D Project(Line3D line3DToProject);
        public Point3D Project(Point3D p, Vector3D projectionDirection = null);
        public Plane Rotate(Vector3D aboutUnitVector, double angle);
        public double SignedDistanceTo(Plane otherPlane);
        public double SignedDistanceTo(Point3D point);
        public override string ToString();
    }
}
