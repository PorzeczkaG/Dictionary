using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>(); //Definicja
            dictionary.Add(1, "Tomasz"); //Pierwsza wartość klucz
            dictionary.Add(2, "Jan");

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }


    }
}
