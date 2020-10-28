using MyTest1;
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

            double Max1, Max2, Max3;
            Max1 = Utils.GetMaxValue(15, 2);

            Max2 = Utils.GetMaxValue(5, 65);

            Max3 = Utils.GetMaxValue(560, 786);

            bool Even1, Even2, Even3;
            Even1 = Utils.IsEven(58);

            Even2 = Utils.IsEven(97);

            Even3 = Utils.IsEven(781);

            //Ejercicio Contador del 0 al 99

            Ejercicios.Ejercicio1();

            //Ejercicio Contador Numeros pares

            Ejercicios.Ejercicio2(20);

            Ejercicios.Ejercicio3(10);

            //Ejercicio Serie Fabonnacci

            Ejercicios.SerieFibonacci();

            //Ejercicio tabla Ascii

            Ejercicios.ImprimirAscii();

            EjerciciosExamen.HacerSuma(523, 7);
            EjerciciosExamen.HacerSuma(100, 20);
            EjerciciosExamen.HacerSuma(25, 25);

            double result = EjerciciosExamen.HacerResta(3, 2);
            System.Console.WriteLine(result);
            double result1 = EjerciciosExamen.HacerResta(10, 8);
            System.Console.WriteLine(result1);
            double result2 = EjerciciosExamen.HacerResta(250, 230);
            System.Console.WriteLine(result2);
            double result3 = EjerciciosExamen.HacerResta(10, 210);
            System.Console.WriteLine(result3);


        }
    }
}
