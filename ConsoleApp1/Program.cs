using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pedro";
            string apellido;
            int edad;
            Console.WriteLine("Proyecto de consola con .NET Framework....");
            Console.WriteLine("Buenos días:{0}", nombre);
            Console.WriteLine("Ingrese Apellido: {0}", nombre);
            apellido = Console.ReadLine();
            Console.WriteLine("Buenos días:{0} {1}", nombre, apellido);
            Console.WriteLine("Ingrese Edad:");
            edad = int.Parse(Console.ReadLine());
            // Forma ALternativa: edad = Convert.ToInt32(edad);
            Console.WriteLine("Buenos días:{0} {1} usted tiene {2} años.", nombre, apellido, edad);
            Console.ReadLine();
        }
    }
}
