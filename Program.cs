using System;

namespace excepciones3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool intentar = false;


            Console.WriteLine("Comprobar si un numero es positivo, negativo o cero");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Ingrese un numero:");

            while (!intentar)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    intentar = true;
                }
                catch (Exception ex) when (ex.GetType() != typeof(FormatException) && ex.GetType() != typeof(OverflowException))
                {
                    Console.WriteLine("Haz cometido un error");
                    Console.WriteLine("Tipo de error: " + ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Error:");
                    Console.WriteLine("Has cometido una excepción. Ingresaste letras");
                    Console.WriteLine("Vuelva a intentarlo");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Ingrese un numero:");
                 
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Error:");
                    Console.WriteLine("La cantidad que ingreso sobrepasa el limite de int");
                    Console.WriteLine("Vuelva a intentarlo");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Ingrese un numero:");

                }
            }

            if (num > 0)
                Console.WriteLine("El numero que ingreso es positivo");
            else if (num < 0)
                Console.WriteLine("El numero que ingreso es negativo");
            else
                Console.WriteLine("El numero que ingreso es cero");

        }
    }
}
