using Ejemplo2;
using System;

namespace MyTest1
{
    class Ejercicios
    {
        //Ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99.
        //Salvo que lo pida explicitamente. No se pone Console.WriteLine en este caso lo pide.

        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador++;
            }
        }
        //Ejercicio: Haz una función que imprima todos los números pares desde el 0 hasta n.
        
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                     System.Console.WriteLine(i);
                i++;
            }
        }
    }
}
