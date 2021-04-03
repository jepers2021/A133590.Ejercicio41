using System;
using System.Collections.Generic;

namespace A133590.Ejercicio41
{
    class Program
    {
        static DateTime validarIngreso(string ingreso)
        {
            DateTime fecha;
            while (!DateTime.TryParse(ingreso, out fecha))
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
                ingreso = Console.ReadLine();
            }

            return fecha;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 39");
            Console.WriteLine("Programa que recibe una serie de fechas y luego las presenta en orden ascendente.");
            List<DateTime> lista = new List<DateTime>();
            string seguir = "";
            do
            {
                Console.Write("Por favor, ingrese una fecha: ");
                lista.Add(validarIngreso(Console.ReadLine()));
                Console.Write("¿Desea ingresar otra fecha? (y/n): ");
                seguir = Console.ReadLine().Trim();
            } while (seguir.Equals("y"));

            Console.WriteLine("Lista invertida:");
            lista.Sort();
            foreach (DateTime elemento in lista)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
