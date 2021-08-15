using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escriba un ciclo que permita calcular los valores a almecenar
            // en el arreglo de numbers con un tama;o de 10
            loops();
            Console.ReadLine();
        }

        public static void loops()
        {
            {
                int[] arraynumbers = new int[10];

                int r = 0;

                while (r < arraynumbers.Length)
                {
                    Console.WriteLine(" Ingresar datos {0} ", r);
                    arraynumbers[r] = Convert.ToInt32(Console.ReadLine());
                    r++;
                }
                Console.WriteLine();




                int i = 0;
                Console.WriteLine("Utilizando el ciclo While:");
                while (i < arraynumbers.Length)
                {
                    Console.WriteLine(arraynumbers[i]);
                    i++;
                }
            }

        }
    }
}
