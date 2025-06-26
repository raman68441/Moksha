using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a[] = new int[3];
            a[0] = 1;
            a[1] = "string";
            Custormer c = new Custormer();
            c.Name = "moin";
            c.Id = 99;
            Array[2] = c;
            foreach(object obj in Array)
            {
                Console.WriteLine(obj);
            }

        }
        public class Custormer
        {

            public int Id(get, set);
            public string Name(get, set);
        }
    }
}
