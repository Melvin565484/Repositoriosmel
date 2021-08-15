using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e imprimir el promedio de los numeros almacenados en el array
            loops();
            Console.ReadLine();
        }
        public static void loops()
        {
            {
                int[] arraynumeros = new int[10];

                int suma = 0;
                double promedio;

                int r = 0;
              

                while (r < arraynumeros.Length)
                {
                    Console.WriteLine("Ingresar dato para la posicion {0}", r);
                    arraynumeros[r] = Convert.ToInt32(Console.ReadLine());
                    r++;
                }
                Console.WriteLine();

                int i = 0;
                Console.WriteLine("Utilizando el ciclo While");
                while (i < arraynumeros.Length)
                {
                    Console.WriteLine(arraynumeros[i]);
                    i++;
                }
                Console.WriteLine();


                for (int num = 0; num < 10; num++)
                {
                    suma = suma + arraynumeros[num];
                }
                promedio = suma / arraynumeros.Length;

                Console.WriteLine("El promedio de los datos ingresados es: {0}", promedio);

            }
        }
    }
}

