using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    interface IWeapon
    {
        string Name { get; set; }
        string type { get; }
        string silencer { get; set; }

        int UpdateClipsize(int newClipSize);

    }


    class Weapon : IWeapon
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
        [JsonConstructor]
        public Weapon(string name, decimal caliber, int clipSize)
        {
            this.Name = name;
            this.clipSize = clipSize;
            this.Caliber = caliber;
        }


        public string Name { get; set; }

        public decimal Caliber { get; private set; }

        public string type { get; set; }

        public string silencer { get; set; }


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

        public override string ToString()
        {
            string returnvalue = $"Name = {Name}{ Environment.NewLine}";
            returnvalue += $"clipsize = {clipSize} {Environment.NewLine}";
            returnvalue += $"Cliber = {Caliber}{ Environment.NewLine}";
            
            return returnvalue;
        }

    }
    class Handgun : IWeapon
    {
        public string Name { get; set; }
        public decimal Caliber { get; private set; }
        private int clipSize;

        public Handgun(int clipSize, decimal caliber)
        {
            this.Name = string.Empty;
            this.Caliber = caliber;
            this.clipSize = clipSize;
        }

        public Handgun(string name, decimal caliber)
        {
            this.Name = name;
            this.clipSize = 30;
            this.Caliber = caliber;
        }
        [JsonConstructor]
        public Handgun(string name, decimal caliber, int clipSize)
        {
            this.Name = name;
            this.clipSize = clipSize;
            this.Caliber = caliber;
        }


        public string type { get; set; }

        public string silencer { get; set; }

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

        public override string ToString()
        {
            string returnvalue = $"Name = {Name} {Environment.NewLine}";
            returnvalue += $"clipsize = {clipSize} {Environment.NewLine}";
            returnvalue += $"Caliber = {Caliber} {Environment.NewLine}";

            return returnvalue;
        }
    }
    
}
