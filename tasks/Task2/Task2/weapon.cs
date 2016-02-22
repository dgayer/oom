using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Weapon
    {

        private int clipSize;
      
        

        public Weapon(int clipSize, decimal caliber)
        {
            this.Name = string.Empty;
            this.Caliber = caliber;
            this.clipSize = clipSize;
        }

        public Weapon(string name, decimal caliber)
        {
            this.Name = name;
            this.clipSize = 30;
            this.Caliber = caliber;
        }

        public Weapon(string name, decimal caliber, int clipSize)
        {
            this.Name = name;
            this.clipSize = clipSize;
            this.Caliber = caliber;
        }

       

        public string Name { get; set; }
        public decimal Caliber { get; private set; }


        public int UpdateClipsize(int newClipSize)
        {
            if (clipSize <= 0)
            {
                Console.WriteLine("new clipsize must not be 0!");
                return clipSize;
            }
            else
            {
                clipSize = newClipSize;
                return newClipSize;
            }
        }
    }
}
