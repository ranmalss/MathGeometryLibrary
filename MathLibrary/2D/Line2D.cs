using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Line2D
    {
        private Point2D EndPoint;
        private Point2D StartPoint;
        public Line2D(Point2D startPoint, Point2D endPoint);
        public static Line2D operator -(Line2D line, Vector2D offset);
        public static bool operator !=(Line2D left, Line2D right);
        public static Line2D operator +(Line2D line, Vector2D offset);
        public static Line2D operator +(Vector2D offset, Line2D line);
        public static bool operator ==(Line2D left, Line2D right);
        public Vector2D Direction { get; }
        public double Length { get; }
        public Point2D ClosestPointTo(Point2D p, bool mustBeOnSegment);
        public bool Equals(Line2D other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public Point2D IntersectWith(Line2D other);
        public Point2D IntersectWith(Line2D other, double parallelTolerance);
        public bool IsParallelTo(Line2D other);
        public bool IsParallelTo(Line2D other, double angleTolerance);
        public Line2D LineTo(Point2D p, bool mustStartBetweenAndEnd);
        public static Line2D Parse(string startPointString, string endPointString);
        public override string ToString();
    }
}
