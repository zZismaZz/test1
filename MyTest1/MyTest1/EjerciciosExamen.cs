using Ejemplo2;

namespace MyTest1
{
    class EjerciciosExamen
    {
        // Hacer una función que reciba dos numero enteros y devuelva la suma de los dos.

        public static int HacerSuma(int a, int b)
        {
            int result = a + b;
            return result;
        }

        // Hacer una función que de dos reales y delvuelva la resta de los dos reales.

        public static double HacerResta(double a, double b)
        {
            return a - b;
        }

        //Hacer dos funciones que reciba dos reales, una devuelva el mayor de los dos reales y la otra el menor.
        public static int ObtenerValorMaximo(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }                                       
        }

        public static double ObtenerValorMinimo(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        //Hacer una función que se le paseen tres enteros y que devuelva el mayor de los 3
        public static int GetMaxValue3Number(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }            
        }

        public static int OtraOpcionMaxValue(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        //Hacer una función que reciba dos enteros y devuelva -1, si el primero es mayor que el segundo, 1, si el segundo es mayor que el primero y 0 si son igual.

        public static int EjercicioExamen5(int a, int b)
        {
            if (a > b)
                return -1;
            else if (b > a) 
                return 1;
            else
                return 0;
        }

        //Hacer una función que reciba un codigo de error y muestre por pantalla, lo siguiente:
        //"error grave" si el error es 0
        //"error moderado" si el error es 1
        //"error leve" si el error es 2
        //"error desconocido" si el error es cualquier otro caso

        public static void PrintErrorCode(int code)
        {
            switch(code)
            {
                case 0:                    
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        //Hacer una función que reciba un número y en función de ese número escriba la siguiente serie: 0, 3, 6, 9, 12...

        public static void MakeSerie(int number)
        {
            int i = 0; 
            while(number >= i)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
            
                
            
        }
        //Hacer una función que reciba un número entero e imprima todos los números desde el 0 hasta ese número

        public static void PrintSerie(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                System.Console.Write(i + ",");
            }
        }
        //Hacer una función igual que la  anterior pero quitando la coma del final.

        public static void PrintSerie2(int n)
        {
            for(int i = 0; i <= n; i++)
            {
               
                System.Console.Write(i);
                if (i < n)
                    System.Console.Write(",");
            }
        }
        //Hacer una función que devuelva el mayor de seis enteros, la función debe ocupar una línea.

        public static int GetMaxNumOf6(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            return GetMaxValue3Number(ObtenerValorMaximo(n1, n2), ObtenerValorMaximo(n3, n4), ObtenerValorMaximo(n5, n6));
        }
        //Función que imprima asteriscos segun el numero entero que le pases
        public static void Asteriscos(int n)
        {
            for(int i = 0; i <= n; i++)
            {                
              System.Console.Write("*");
            }
        }
        //Función que imprima * y + segun el numero entero que le pases

        public static void AsteriscoSuma(int n)
        {
            for(int i = 0; i < n; i++)
            {
                if (Utils.IsEven(i))
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
        }

        //Función que imprima *, +, - segun el numero entero que le pases
        public static void AsteriSumaRestaDivision(int n)
        {
            for(int i = 0; i < n; i++)
            {
                switch(i % 4)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
        }
        //Función que imprima figuras con * segun el numero entero que le pases

        public static void FiguraAsterisco(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    System.Console.Write("*");
                System.Console.WriteLine();
            }
        }
        //Función que imprima ***+++*** segun el numero entero que le pases

        public static void FigurasAsteriSuma(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if((i % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                System.Console.WriteLine();
            }
        }

        public static void FigAstSumaDiagonal(int n)
        {
            for(int f = 0; f < n; f++)
            {
                for(int c = 0; c < n; c++)
                {
                    int s = f + c;
                    if ((s % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                    System.Console.WriteLine();
                }
            }
        }

        public static void EscaleraAster(int n)
        {
            for(int c = 0; c < n; c++)
            {
                for(int f = 0; f <= c; f++)
                {
                    System.Console.Write("*");
                   
                }
                System.Console.WriteLine();
            }
        }

        public static void InverEscaleraAster(int n)
        {
            for (int f = 0; f < n; f++)
            {
                int nespacios = n - f - 1;
                int nasteriscos = f + 1;
                for(int c = 0; c < nespacios; c++)
                {
                    System.Console.Write(" ");
                }               
                for(int c = 0; c < nasteriscos; c++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

        }

        public static void Piramide(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacio1 = n - f - 1;
                int nespacio2 = f * 2;
                for (int c = 0; c < nespacio1; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");
                for( int c = 0; c < nespacio2; c++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
    }





}
