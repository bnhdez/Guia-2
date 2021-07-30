﻿using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pago;
            double sueldo, retencion, cuota, porcent;
            
            Console.WriteLine("Ingrese 'mensual' o 'quincenal' dependiendo de su sueldo");
            pago = Console.ReadLine();

            switch (pago)
                {
                case ("mensual"):
                    {
                        Console.WriteLine("Ingrese su sueldo");
                        sueldo = double.Parse(Console.ReadLine());

                        if ((sueldo >= 0.01) && (sueldo <= 472.00))
                        { 
                            Console.WriteLine("SIN RETENCION");
                        }
                        else if ((sueldo > 472.00) && (sueldo <= 895.24))
                        {
                            porcent = (sueldo * 0.1);
                            cuota = 17.67;
                            retencion = porcent + cuota;

                            Console.WriteLine("La retencion es de: " + retencion);
                        }
                        else if ((sueldo > 895.24) && (sueldo <= 2038.10))
                        {
                            porcent = (sueldo * 0.2);
                            cuota = 60.00;
                            retencion = porcent + cuota;

                            Console.WriteLine("La retencion es de: " + retencion);
                        }
                        else if (sueldo > 2038.10)
                        {
                            porcent = (sueldo * 0.3);
                            cuota = 288.57;
                            retencion = porcent + cuota;

                            Console.WriteLine("La retencion es de: " + retencion);
                        }
                        break;
                    }

                case ("quincenal"):

                    Console.WriteLine("Ingrese su sueldo");
                    sueldo = double.Parse(Console.ReadLine());

                    if ((sueldo >= 0.01) && (sueldo <= 236.00))
                    {
                        Console.WriteLine("SIN RETENCION");
                    }
                    else if ((sueldo > 236.00) && (sueldo <= 447.62))
                    {
                        porcent = (sueldo * 0.1);
                        cuota = 8.83;
                        retencion = porcent + cuota;

                        Console.WriteLine("La retencion es de: " + retencion);
                    }
                    else if ((sueldo > 447.62) && (sueldo <= 1019.05))
                    {
                        porcent = (sueldo * 0.2);
                        cuota = 30.00;
                        retencion = porcent + cuota;

                        Console.WriteLine("La retencion es de: " + retencion);
                    }
                    else if (sueldo > 1019.06)
                    {
                        porcent = (sueldo * 0.3);
                        cuota = 144.28;
                        retencion = porcent + cuota;

                        Console.WriteLine("La retencion es de: " + retencion);
                    }

                    break;
            }

        }
    }
}
