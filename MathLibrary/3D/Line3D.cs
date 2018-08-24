using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Line3D
    {
        private Point3D EndPoint;
        private Point3D StartPoint;
        public Line3D(Point3D startPoint, Point3D endPoint);
        public static bool operator !=(Line3D left, Line3D right);
        public static bool operator ==(Line3D left, Line3D right);
        public Vector3D Direction { get; }
        public double Length { get; }
        public Tuple<Point3D, Point3D> ClosestPointsBetween(Line3D other);
        public Tuple<Point3D, Point3D> ClosestPointsBetween(Line3D other, bool mustBeOnSegments);
        public Point3D ClosestPointTo(Point3D p, bool mustBeOnSegment);
        public bool Equals(Line3D other);
        public override bool Equals(object obj);
        //public Point3D? IntersectionWith(Plane plane, double tolerance = 4.94066e-324);
        //public Line3D ProjectOn(Plane plane);
        public bool IsParallelTo(Line3D other);
        public bool IsParallelTo(Line3D other, double angleTolerance);
        public Line3D LineTo(Point3D p, bool mustStartBetweenStartAndEnd);
        public static Line3D Parse(string startPoint, string endPoint);
        public override string ToString();
    }
}
