using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ejer3dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> MembertList = new Dictionary<string, int>();

            //agregar elementos al diccionario
            MembertList.Add("Santiago Mendoza", 17);
            MembertList.Add("Melissa Rodriguez", 30);
            MembertList.Add("Angeline Valeska", 19);
            MembertList.Add("Elmer Mendoza", 21);

            foreach (KeyValuePair<string, int> employee in MembertList)

            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }
            var dic = MembertList.Keys.ToList();

            dic.Sort();
            Console.WriteLine("Diccionario");
            Console.WriteLine("Los datos se muestran en orden alfabetico.");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, MembertList[item]);
            }
            Console.ReadKey();
        }
    }
}
