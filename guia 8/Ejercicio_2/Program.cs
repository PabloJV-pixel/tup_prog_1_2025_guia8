using Microsoft.Win32;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Edad0 = 0;
            int Edad1 = 0;
            int Edad2 = 0;
            int Edad3 = 0;
            double Monto = 0;
            double Porcentaje0 = 0;
            double Porcentaje1 = 0;
            double Porcentaje2 = 0;
            double Porcentaje3 = 0;
            double Monto0 = 0;
            double Monto1 = 0;
            double Monto2 = 0;
            double Monto3 = 0;


            Console.WriteLine("ingrese el monto a repartir: ");
            Monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la edad de la nena 1: ");
            Edad0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la edad de la nena 2 ");
            Edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la edad de la nena 3 ");
            Edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la edad de la nena 4 ");
            Edad3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Porcentaje0 = 1.0 * Edad0 / (Edad0 + Edad1 + Edad2 + Edad3);
            Porcentaje1 = 1.0 * Edad1 / (Edad0 + Edad1 + Edad2 + Edad3);
            Porcentaje2 = 1.0 * Edad2 / (Edad0 + Edad1 + Edad2 + Edad3);
            Porcentaje3 = 1.0 * Edad3 / (Edad0 + Edad1 + Edad2 + Edad3);
            Monto0 = Porcentaje0 * Monto;
            Monto1 = Porcentaje1 * Monto;
            Monto2 = Porcentaje2 * Monto;
            Monto3 = Porcentaje3 * Monto;

            Console.WriteLine($"a la nena 1 le tenes que pagar: {Math.Round(Monto0, 2)} pesos" );
            Console.WriteLine($"a la nena 2 le tenes que pagar: {Math.Round(Monto1, 2)} pesos");
            Console.WriteLine($"a la nena 3 le tenes que pagar: {Math.Round(Monto2, 2)} pesos");
            Console.WriteLine($"a la nena 4 le tenes que pagar: {Math.Round(Monto3, 2)} pesos");



        }
    }
}
