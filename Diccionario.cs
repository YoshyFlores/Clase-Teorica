using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Teorica
{
    class Diccionario
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> MembertList = new Dictionary<string, int>();

            //agregar elementos al diccionario
            MembertList.Add("José Wilson Flores García", 18);
            MembertList.Add("Olga Marina García", 45);
            MembertList.Add("Ana Gladis Villegas", 60);
            MembertList.Add("Yosselin Roxana Flores García", 20);

            foreach (KeyValuePair<string, int> employee in MembertList)

            {
                Console.WriteLine("Clave: {0}, Valor: {1}", employee.Key, employee.Value);
            }
            var dic = MembertList.Keys.ToList();

            dic.Sort();
            Console.WriteLine("Diccionario ordenado");
            Console.WriteLine("Los datos han sido ordenados por orden alfabetico.");
            foreach (var item in dic)
            {
                Console.WriteLine("{0}: {1}", item, MembertList[item]);
            }
            Console.ReadKey();
        }
    }
}

