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
        public static double ObtenerValorMaximo(double a, double b)
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
    }


}
