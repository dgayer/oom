using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon w1 = new Weapon("M-16", 7.25m, 30);
            Weapon w2 = new Weapon(25, 7.25m);
            Weapon w3 = new Weapon("AK-47", 6.40m);

            Console.WriteLine($"Weapon 1 Caliber: {w1.Caliber}");
            Console.WriteLine($"Weapon 2 Name: {w2.Name}");
            w2.Name = "Five-Seven";
            Console.WriteLine($"Weapon 2 Name: {w2.Name}");
            Console.WriteLine($"Clipsize in Weapon 2 upated to {w2.UpdateClipsize(30)}");

        }
    }
}
