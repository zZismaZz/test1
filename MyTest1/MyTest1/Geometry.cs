
namespace Ejemplo2
{
    class Geometry
    {
        public static double CalculateVectorLenght(double vx, double vy)
        {
            double aux = vx * vx + vy * vy;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateDistance2D(double x1, double x2, double y1, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return CalculateVectorLenght(vx, vy);
        }
        public static double CalculateVectorLenght3D(double vx, double vy, double vz)
        {
            double aux = vx * vx + vy * vy + vz * vz;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateDistance3D(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            double vz = z2 - z1;

            return CalculateVectorLenght3D(vx, vy, vz);
        }

        public static double GetCircleArea(double r)
        {
            double aux = System.Math.PI;
            return aux * r * r;
        }

        public static double GetVolumeSphere(double r)
        {
            double aux = System.Math.PI;
            return (4 * aux * r * r * r) / 3.0;
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
