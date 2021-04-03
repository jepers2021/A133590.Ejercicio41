using System;

namespace A133590.Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 41");
            Console.WriteLine("Programa que recibe una palabra y la presenta al revés.");
            Console.Write("Por favor, ingrese una palabra: ");
            char[] palabra = Console.ReadLine().ToCharArray();
            Array.Reverse(palabra);
            Console.WriteLine($"Palabra invertida: {new string(palabra)}");
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
