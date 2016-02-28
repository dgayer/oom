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
            Dog e1 = new Dog(3, "German Shephard", 1500); //create values and get class ready to be used
            Dog e2 = new Dog(6, "Pit Bull", 1200);
            e1.DOGcheck();
            e2.DOGcheck();
            Dog e3 = new Dog();
            e3.DOGcheck();
            Dog e4 = addDog();
            
         

        }

        public static Dog addDog()
        {
            Console.WriteLine("Please enter the age of the dog: ");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the name of the dog: ");
             var Race = Console.ReadLine();
            Console.WriteLine("Please enter a price: ");
            var price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You added a new dog. Age: {0} and Name: {1} and price: {2}", Age, Race, price);

            Dog newDog = new Dog(Age, Race, price);
            return null;

        }

    }
}
