using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            // Pedir el nombre de usuario
            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine();

            // Pedir la edad
            Console.WriteLine("¿Cuántos años tienes?");
            int edad = int.Parse(Console.ReadLine());

            // Mostrar el nombre y la edad en la consola
            Console.WriteLine("Hola, " + nombre + ". Tienes " + edad + " años.");
        }
    }
}
