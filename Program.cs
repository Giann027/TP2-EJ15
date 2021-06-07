using System;

namespace TP2_EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenass");
            Console.Title = "Número negativo o positivo";

            float Número;

            Console.Write("Ingrese el Número a verificar: ");
            Número = Convert.ToSingle(Console.ReadLine());

            if (Número >= 0)

                Console.Write($"El Número es positivo");

            else
                Console.Write("El Número es negativo");
        }
    }
}
