namespace Ejercicio_1
{
    internal class Program

    {
        static int acumulador = 0;
        static int cantidad;
        static int valor;
        static double promedio = 0;
        static int maxValor = int.MinValue;
        static int minValor = int.MaxValue;


        static void RegistrarValor(int valor)
        {
            acumulador += valor;
        }

        static double CalcularPromedio()
        {
            return Convert.ToDouble(acumulador) / Convert.ToDouble(cantidad); ;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("@\t\t Ejercicio 1 \t\t" +
                "1- Procesar un solo número\r\n" +
                "2- Procesar varios números\r\n" +
                "3- Mostrar máximo y mínimo.\r\n" +
                "4- Mostrar promedio.\r\n" +
                "5- Mostrar cantidad de números ingresados.\r\n" +
                "6- Reiniciar variables\r\n"+
                "7- Finalizar Programa\r\n"
                );

            return Convert.ToInt32( Console.ReadLine() );
        }

        static void SolicitarIngresarCantidadDeNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de numeros a entrar.");
            cantidad = Convert.ToInt32(Console.ReadLine());
        }
        static void SolicitarIngresarValor(int n)
        {
            Console.Clear();
            Console.WriteLine($"ingrese el valor del num. {n + 1}");
            valor = Convert.ToInt32(Console.ReadLine());

            RegistrarValor(valor);

            if (valor == 0 || valor > maxValor)
            {
                maxValor = valor;
            }

            if (valor == 0 || valor < minValor)
            {
                minValor = valor;
            }
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();

            for (int n = 0; n < cantidad; n++)
            {
                SolicitarIngresarValor(n);

            }
        }

        static void MostrarPantallaMinimoYMaximo()
        {
            Console.Clear();
            if (cantidad > 0)
            {

                Console.WriteLine("Valor minimo: " + minValor);
                Console.WriteLine("Valor minimo: " + minValor);
            }
            else
            {
                Console.WriteLine("No se han ingresado valores");
            }
        }

        static void MostrarPantallaPromedio()
        {
            Console.Clear();
            if (cantidad > 0)
            {
                Console.WriteLine("Valor promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("No se han ingresado valores");
            }
        }

        static void MostrarCantidadDeNumerosIngresados()
        {
            Console.Clear();
            Console.WriteLine("Cantidad de numeros ingresados: "+ cantidad);
        }

        static void ReiniciarVariables()
        {
            Console.Clear();
              acumulador = 0;
              valor = 0;
              cantidad =0 ;
              promedio = 0;
              maxValor = int.MinValue;
              minValor = int.MaxValue;
        }
        static void Main(string[] args)
        {
            int opcion = -1;

            do
            {

                opcion =MostrarPantallaSolicitarOpcionMenu();

                if (opcion < 0 || opcion > 7)
                    Console.WriteLine("SELECCIONE UNA OPCION VALIDA\n");
                else
                {
                    switch (opcion)
                    {

                        case 1:
                            SolicitarIngresarValor(1);
                            Console.ReadKey();
                            break;
                        case 2:
                            SolicitarIngresarCantidadDeNumeros();
                            MostrarPantallaSolicitarVariosNumeros();
                            Console.ReadKey();
                            break;
                        case 3:
                            MostrarPantallaMinimoYMaximo();
                            Console.ReadKey();
                            break;
                        case 4:
                            MostrarPantallaPromedio();
                            Console.ReadKey();
                            break;
                        case 5:
                            MostrarCantidadDeNumerosIngresados();
                            Console.ReadKey();
                            break;
                        case 6:
                            ReiniciarVariables();
                            Console.ReadKey();
                            break;
                         

                    }
                }
            } while( opcion > 0 || opcion < 6 || opcion!=7);


           
        }
    }
}

