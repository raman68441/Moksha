using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.TurnoffCar();
            obj.TurnoffCar();
            
        }
    }
    public class Car
    {

        public void TurnonCar()
        {
            Console.WriteLine("turn on manul corneer");

        }
        public void TurnoffCar()
        {
            Console.WriteLine("turn off the enumal carr");

        }
       private void charge_pistal_speed()
        {
            Console.WriteLine("charge pistal speed implementation");
        }
       private void move_break_pads()
        {

            Console.WriteLine("move break pad implementation");
        }
    }

}
