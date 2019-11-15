using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ADSS_MidTerm_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation() returns an array of lenght 2, containing objects (Adam and Eve)

            string name1, name2;
            Console.WriteLine("Enter names of the humans:");
            name1 = Console.ReadLine();
            name2 = Console.ReadLine();

            Human[] arr = Creation(name1, name2);

            using (StreamWriter sw = new StreamWriter("humans.json", false))
            {
                string output = JsonConvert.SerializeObject(arr, Formatting.Indented);
                sw.WriteLine(output);
            }


        }

        public static Human[] Creation(string name1, string name2)
        {
            Human[] arr = new Human[2];
            arr[0] = new Man()
            {
                name = name1
            };


            arr[1] = new Woman()
            {
                name = name2
            };
            return arr;
        }
    }
}
