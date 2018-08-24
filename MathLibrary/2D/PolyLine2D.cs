using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class PolyLine2D
    {
        private List<Point2D> Points;
        public PolyLine2D(List<Point2D> points);
        public int Count { get; }
        public double Length { get; }
        public Point2D this[int key] { get; }
        public Point2D ClosestPointTo(Point2D p);
        public IEnumerator<Point2D> GetEnumerator();
        public Point2D GetPointAtFractionAlongCurve(double fraction);
        public Point2D GetPointAtLengthFromStart(double lengthFromStart);
    }
}
