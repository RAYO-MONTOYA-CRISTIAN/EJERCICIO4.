using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tiempo de revisión en minutos para el salón A:");
            int tiempoSalonA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo de revisión en minutos para el salón B:");
            int tiempoSalonB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo de revisión en minutos para el salón C:");
            int tiempoSalonC = Convert.ToInt32(Console.ReadLine());

            int tiempoTotalMinutos = tiempoSalonA + tiempoSalonB + tiempoSalonC;

            int horas = tiempoTotalMinutos / 60;
            int minutos = tiempoTotalMinutos % 60;

            Console.WriteLine($"El instructor tardará {horas} horas y {minutos} minutos en revisar los exámenes de todos los salones.");
        }
    }
}
