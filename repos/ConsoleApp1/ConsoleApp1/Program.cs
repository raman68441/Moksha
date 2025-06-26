using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void MyMehtod(String fname,int ge)
        {
            Console.WriteLine(fname+ "is "+ge);
                
        }
        static void Main(string[] args)
        {
            MyMehtod("kahtirki", 3);

            MyMehtod("veeresh", 5);
            MyMehtod("ramnaji", 6);


        }
    }
}
