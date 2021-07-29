using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese un numero entero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero entero: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("El numero mayor es: " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("El numero mayor es: " + b);
            }
            if (a == b)
            {
                Console.WriteLine("Los numeros son iguales");
            }
        }
    }
}
