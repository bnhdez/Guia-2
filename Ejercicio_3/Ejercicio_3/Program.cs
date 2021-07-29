using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            
            Console.WriteLine("Ingrese los valores para 'x', 'y' y 'z'");
            Console.WriteLine("X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Z: ");
            z = int.Parse(Console.ReadLine());

            if ((2*x) + (20*y) - (40*z) > 585)
            {
                Console.WriteLine("CORRECTO");
            }
            else
                {
                Console.WriteLine("INCORRECTO");
            }
        }
    }
}
