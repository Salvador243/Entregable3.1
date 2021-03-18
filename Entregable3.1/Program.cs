using System;

namespace Entregable3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaTotal = 0;
            int multiplicacion = 1;
            Console.Write("Escriba un numero impar: ");
            int entrada = Int32.Parse(Console.ReadLine());
            if (entrada > 0 && entrada <= 19)
            {
                if (EsImpar(entrada) == false)
                {
                    Console.WriteLine("<<<--- LA SERIE EVALUADA --->>> ");
                    for (int i = 1; i <= entrada; i += 2)
                    {
                        Console.Write(i + " ");
                        sumaTotal += i;
                        multiplicacion *= i;
                    }
                    Console.WriteLine("\nLa suma de la serie es: " + sumaTotal);
                    Console.WriteLine("La multiplicacion de la serie es: " + multiplicacion);
                }
            }
            
            int serie = Int32.Parse(Console.ReadLine());
            double sumatoria = 0;
            for (int i = 1; i <= serie; i++)
            {
                sumatoria += (1 / Math.Pow(2,i));
            }
            Console.Write(sumatoria);
            
            
            
            for (double x = -500; x <= 500; x += 0.10) 
            {
                if (349.99 - x < ((5 * (400 - x)) / 6) && ((5 * (400 - x)) / 6) < 350.09 - x)
                {
                    Console.WriteLine("La aproximación es: " + x);
                    break;
                }
            }
            
            
            for (double x = -100; x <= 100; x++) 
            {
                if (15 * 3 == x)
                {
                    Console.WriteLine("La edad es: " + x);
                    break;
                }
            }


        }

        public static bool EsImpar(int numero)
        {
            return Convert.ToBoolean((numero % 2 == 0 ? true : false));
        }
    }
}