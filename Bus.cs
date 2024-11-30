using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class Bus
    {
        public int Wheel { get; set; }

        public Bus(int wheel) 
        {
            Wheel = wheel;
        }



        public void func()
        {
            Console.WriteLine("i am a fxn");
        }

        public virtual void PrintBusDetails()
        {
            Console.WriteLine($"Bus has {Wheel} wheels");
        }
    }
}
