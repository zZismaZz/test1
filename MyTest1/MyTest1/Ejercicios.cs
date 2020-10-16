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
        //Ejercicio: Hacer una función que imprima por pantalla si un número es primo o no.
        //El ejercicio se separa en dos partes.

        public static void Ejercicio3(int numero)
        {
            bool es_primo = Utils.IsPrime(numero);
            if (es_primo)
                System.Console.WriteLine("El numero " + numero + " es primo");
            else
                System.Console.WriteLine("El numero " + numero + " NO es primo");
        }

        //Ejercicio: Hacer una función que imprima la serie Fibonacci.

        public static void SerieFibonacci()
        {

            int i = 0;
            int a = 1;
            int aa = 0;

            Console.WriteLine(aa);
            Console.WriteLine(a);
            
            while(i < 100)
            {
                System.Console.WriteLine(a + aa);
                    int aux = aa;
                    aa = a;
                    a = aux + a;
                i++;
            }

        }
    }
}
