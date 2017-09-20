using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldTheDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard(10, "Puppy");
            Console.WriteLine("The name of wizard is " + wizard.Name + "  The magic he/she has is " + wizard.Magic);
        }
    }
}
