using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Vector3D
    {
        private double X;
        private double Y;
        private double Z;

        public Vector3D(double[] data);
        public Vector3D(double x, double y, double z);

        public static Vector3D operator -(Vector3D v);
        public static Vector3D operator -(Vector3D v1, Vector3D v2);
        public static bool operator !=(Vector3D left, Vector3D right);
        public static Vector3D operator *(double d, Vector3D v);
        public static double operator *(Vector3D left, Vector3D right);
        public static Vector3D operator /(Vector3D v, double d);
        public static Vector3D operator +(Vector3D v1, Vector3D v2);
        public static bool operator ==(Vector3D left, Vector3D right);
        public double Length { get; }
        public Vector3D Add(Vector3D v);
        public double AngleTo(Vector3D v);
        public Vector3D CrossProduct(Vector3D inVector3D);
        public double DotProduct(Vector3D v);
        public bool Equals(Vector3D other);
        public bool Equals(Vector3D other, double tolerance);
        
        public bool IsParallelTo(Vector3D othervector, double tolerance = 1e-010);
        public bool IsPerpendicularTo(Vector3D othervector, double tolerance = 1e-006);
        public Vector3D Negate(); 
        public static Vector3D Parse(string s);
        public Vector3D ProjectOn(Vector3D unitVector);
        public Vector3D Rotate(Vector3D about, double angle);
        public Vector3D ScaleBy(double scaleFactor);
        public double SignedAngleTo(Vector3D v, Vector3D about);
        public Vector3D Subtract(Vector3D v);
        public Point3D ToPoint3D();
        public override string ToString();
    }
}
    

