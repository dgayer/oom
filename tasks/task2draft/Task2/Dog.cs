using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public enum Currency
    {
        EUR,
    }
    class Dog
    {
        private int Age;
        private string Race;
        private decimal price;


        public Dog(int age, string race, decimal price) //contrsuctor
        {
            Age = age;
            Race = race;
            this.price = price;
        }

        public Dog(int age) //contrsuctor
        {
            Age = age;
            Race = "unspecified";
            price = 0;
        }

        public Dog() //contrsuctor
        {
            Age = 1;
            Race = "unspecified";
            price = 0;
        }

        public decimal Price
        {
            get
            {
                return price;
            }
        }




        public void DOGcheck() // function
        {
            Console.WriteLine("The selected dog: Age: {0}, Name: {1} Price: {2}",Age, Race, price);
            
        }
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0) throw new Exception();
            price = newPrice;
        }


    }
}
