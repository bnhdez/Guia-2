using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pago;
            double sueldo, retencion, porcent;
            
            Console.WriteLine("Ingrese 'mensual' o 'quincenal' dependiendo de su sueldo");
            pago = Console.ReadLine();

            switch (pago)
                {
                case ("mensual"):
                    Console.WriteLine("Es mensual");
                    break;
                case ("quincenal"):
                    Console.WriteLine("Es quincenal");
                    break;
            }

        }
    }
}
