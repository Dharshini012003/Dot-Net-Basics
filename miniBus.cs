using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class miniBus : Bus
    {
        public miniBus(int wheel) : base(wheel) 
        { 

        }

        public new void func() //new keyword to hide the same fxn in base class otherwise error
        {
            Console.WriteLine("i am a fxn");
        }
        public override void PrintBusDetails()
        {
            Console.WriteLine($"Mini Bus has {Wheel} wheels");
        }
    }
}
