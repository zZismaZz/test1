
using System.IO;

namespace Ejemplo2
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
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

        public static int GetMaxValue(int a, int b)
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

        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
            
                return true;
            else
                return false;
        }

        public static bool IsPrime(int number)
        {
            int i = 2;
            while(i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
        

    }
}