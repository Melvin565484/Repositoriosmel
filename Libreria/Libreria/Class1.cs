using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Class1
    {  //Librería que permita crear una lista de numeros enteros y mostrar el promedio
        public static void SortedListCollection()
    {
        //Definir tama;o de la lista
        Console.Write("Cuantos elementos agregara a la lista");
        var numbers = Convert.ToInt32(Console.ReadLine());

        //Declarar arrays vacios
        Object[] key = new object[numbers];
        object[] value = new object[numbers];

        //Declarar la lista
        SortedList<object, object> srtList = new SortedList<object, object>();
        int a = 0;

        while (a < numbers)
        {
            Console.WriteLine("Escriba elementos a agregar {0}");

            //Lenar los arrays 
            Console.Write("numeros enteros: ");
            key[a] = Console.ReadLine();

            //Llenar lista
            srtList.Add(key[a], value[a]);

            a++;
            Console.WriteLine("Promedio: ", a / numbers);

        }
    }

}
}