using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


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
            Console.WriteLine();

            Handgun h1 = new Handgun("Desert Eagle", 6.75m, 7);
            h1.silencer = "No";
            Console.WriteLine($"New Handgun with the name {h1.Name}. Silencer availablle:  {h1.silencer}");
            Console.WriteLine();

            IWeapon[] guns = new IWeapon[4];
            guns[0] = w1;
            guns[1] = w2;
            guns[2] = w3;
            guns[3] = h1;
            

            foreach (var gun in guns)
            {
                Console.WriteLine(gun.Name);
                
            }
            Console.WriteLine($"The ClipSize of {h1.Name} has been updated to {h1.UpdateClipsize(12)}");
            foreach (var gun in guns)
            {
                Console.WriteLine(gun);
            }

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(guns, settings));

            var text = JsonConvert.SerializeObject(guns, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "guns.json");
            File.WriteAllText(filename, text);

            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IWeapon[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) Console.WriteLine($"{x.type}, {x.Name}");

            //Handgun h2 = new Handgun("Galil AR", 7.45m, 35);
            //File.WriteAllText(@"C:\Users\vermillion\Desktop\oom\tasks\Task2", JsonConvert.SerializeObject(guns));

            //using (StreamReader file = File.OpenText(@"C:\Users\vermillion\Desktop\oom\tasks\Task2"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    Handgun h3 = (Handgun)serializer.Deserialize(file, typeof(Handgun));
            //    foreach (var x in itemsFromFile) Console.WriteLine($"
            //}
        }
    }

}
