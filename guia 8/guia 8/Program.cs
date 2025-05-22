namespace Ejercicio_1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int cantidad;
            int valor;
            double promedio = 0;
            int maxValor = int.MinValue;
            int minValor = int.MaxValue;


            Console.WriteLine("Ingrese la cantidad de numeros a entrar.");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine($"ingrese el valor del num. {n + 1}");
                valor = Convert.ToInt32(Console.ReadLine());

                acumulador += valor;

                if (valor == 0 || valor > maxValor)
                {
                    maxValor = valor;
                }

                if (valor == 0 || valor < minValor)
                {
                    minValor = valor;
                }

            }

            if (acumulador != 0)
            {
                promedio = Convert.ToDouble(acumulador) / Convert.ToDouble(cantidad);
                Console.WriteLine("Valor minimo: " + minValor);
                Console.WriteLine("Valor maximo: " + maxValor);
                Console.WriteLine("Valor promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("no se ingresaron numeros.");
            }
        }
    }
}

