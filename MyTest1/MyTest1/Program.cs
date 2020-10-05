using System;

namespace Ejemplo2
{
    class Program
    {

        static void Main(string[] args)
        {
            double solution, solution1, solution2, solution3;
            solution = EquationSolvers.SolveEquation2(1.0, -2.0, 3.0);
            Console.WriteLine("Hello World!");

            solution1 = EquationSolvers.SolveEquation1(3.0, 3.0);

            solution2 = EquationSolvers.SolveEquation1(2.0, 10.0);

            solution3 = EquationSolvers.SolveEquation2(3.0, -14.0, 1.0);

            double l1, l2, l3, l4;
            l1 = Geometry.CalculateVectorLenght3D(5.0, -4.0, 6.0);

            l2 = Geometry.CalculateDistance3D(0.0, 0.0, 1.0, 1.0, 2.0, 1.0);

            l3 = Geometry.CalculateDistance3D(1.0, 2.0, 3.0, 4.0, 5.0, 5.0);

            l4 = Geometry.CalculateDistance3D(5.0, 24.0, 12.0, 6.0, 1.0, 3.0);

            double A1, A2;
            A1 = Geometry.GetCircleArea(3.0);

            A2 = Geometry.GetCircleArea(8.5);

            double V1, V2;
            V1 = Geometry.GetVolumeSphere(5.0);

            V2 = Geometry.GetVolumeSphere(6.3);

            double R1, R2, R3;
            R1 = Geometry.GetRectangleArea(6.0, 3.0);

            R2 = Geometry.GetRectangleArea(12.0, 21.5);

            R3 = Geometry.GetRectangleArea(5.1, 83.9);

            double Min1, Min2, Min3;
            Min1 = Utils.GetMinValue(2, 5);

            Min2 = Utils.GetMinValue(7, 1);

            Min3 = Utils.GetMinValue(8, 5);

        }
    }
}
