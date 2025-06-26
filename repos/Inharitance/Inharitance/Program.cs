using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitance
{
    internal class Program
    {
        String name;
        int id;
        int salary;
        static void Main(string[] args)
        {

            Program b= new Program();

            b.name = "kathriki Ramanjaneyulu";
            b.id = 1;
            b.salary = 30000;
            b.name


            Program b1 = new Program();
            b1.color = "redd";
            b.color = "greeen";
            Console.WriteLine(b1);
            Console.WriteLine(b.color);     
             


        }
    }
}
