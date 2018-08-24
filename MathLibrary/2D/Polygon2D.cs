using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Polygon2D
    {
        private List<Point2D> points;
        public Polygon2D(IEnumerable<Point2D> points);
        public static Polygon2D operator +(Polygon2D poly, Vector2D shift);
        public static Polygon2D operator +(Vector2D shift, Polygon2D poly);
        public int Count { get; }
        public Point2D this[int key] { get; }
        public static bool ArePolygonVerticesColliding(Polygon2D a, Polygon2D b);
        
        public bool EnclosesPoint(Point2D p);
        
        public static Polygon2D GetConvexHullFromPoints(IEnumerable<Point2D> pointList, bool clockWise = true);
        public IEnumerator<Point2D> GetEnumerator();
        
        public static bool IsPointInPolygon(Point2D p, Polygon2D poly);
        public Polygon2D ReduceComplexity(double singleStepTolerance);
        public Polygon2D Rotate(double angle);
        public Polygon2D RotateAround(double angle, Point2D center);
        public PolyLine2D ToPolyLine2D();
    }
}
