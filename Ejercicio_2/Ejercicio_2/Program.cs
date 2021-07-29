using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ingrese 3 numeros enteros diferentes: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c) && (b > c))
            {
                Console.WriteLine("El numero es mayor " + a);
                Console.WriteLine("El numero medio es " + b);
                Console.WriteLine("El numero pequeño es " + c);
            }
            else if ((a > b) && (a > c) && (c >b))
            {
                Console.WriteLine("El numero es mayor " + a);
                Console.WriteLine("El numero medio es " + c);
                Console.WriteLine("El numero pequeño es " + b);
            }

            if ((b > a) && (b > c) && (a > c))
            {
                Console.WriteLine("El numero es mayor " + b);
                Console.WriteLine("El numero medio es " + a);
                Console.WriteLine("El numero pequeño es " + c);
            }
            else if ((b > a) && (b > c) && (c>a))
            {
                Console.WriteLine("El numero es mayor " + b);
                Console.WriteLine("El numero medio es " + c);
                Console.WriteLine("El numero pequeño es " + a);
            }

            if ((c > a) && (c > b) && (a > b))
            {
                Console.WriteLine("El numero es mayor " + c);
                Console.WriteLine("El numero medio es " + a);
                Console.WriteLine("El numero pequeño es " + b);
            }
            else if ((c > a) && (c > b) && (b>a))
            {
                Console.WriteLine("El numero es mayor " + c);
                Console.WriteLine("El numero medio es " + b);
                Console.WriteLine("El numero pequeño es " + a);
            }

        }
    }
}
