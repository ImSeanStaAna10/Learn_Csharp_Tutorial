using System;
using System.Collections.Generic;
using System.Text;
namespace Namespace_and_Comments.BasketballPlayers.PBA
{
    internal class Brownlee
    {

        public string Name { get; set; }

        // CONSTRUCTOR
        public Brownlee(string Name)
        {
            this.Name = Name;
        }
        public void Describe()
        {

            Console.WriteLine("Brownlee is a PBA player.");
            Veggies veggies = new Veggies();
            veggies.EatVeggies();

            Console.WriteLine($"I am {Name} and I love to eat {veggies}");

        }
    }
}
