using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        { //Crear un programa en C# que escriba un saludo y muestre su nombre (ej. "Hola, Alberto")
            string nombre = " "; 
            Console.WriteLine("¿Como te llamas?"); 
            Console.WriteLine("--------------------------------------------------------------");
            nombre = Console.ReadLine(); 
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Hola {0}", nombre); 
           
        }
    }
}