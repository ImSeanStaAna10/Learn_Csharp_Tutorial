using Namespace_and_Comments.BasketballPlayers.NBA;
using Namespace_and_Comments.BasketballPlayers.PBA;
using Namespace_and_Comments.Fruits;
using System;
using System.Collections;

/*
    NAMESPACES - used to organize code and avoid naming conflicts,
    similar to a folder structure in a file explorer. It can be nested
    and used across multiple files. It can also be aliased to prevent
    confusion between classes with the same name in different namespaces.

    COMMENTS - used to explain code and make it more readable.
    Types of comments:
        - Single-line comment //
        - Multi-line comment /* ... */
        

// ALIAS - used to differentiate same class names from different namespaces
using NbaBanchero = Namespace_and_Comments.BasketballPlayers.NBA.Banchero;
using PbaBacnhero = Namespace_and_Comments.BasketballPlayers.PBA.Banchero;

namespace Namespace_and_Comments
{
    class Program
    {
       
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");

            var queue = new Queue();

            #region FRUITS

            var banana = new Banana();
            var apple = new Apple("red", 180 , true);
            apple.Describe();
            apple.Eat();
            

            #endregion

            #region PBA PLAYERS

            var fajardo = new Fajardo();
            var banchero = new BasketballPlayers.PBA.Banchero();
            var pbaBanchero = new PbaBacnhero();

            #endregion

            #region NBA PLAYERS

            var james = new James();
            var durant = new Durantcs();
            var curry = new Curry();
            var nbaBanchero = new NbaBanchero();

            #endregion

            Fruities eatFruits = new Fruities();
            eatFruits.eatFruits();

           
            var brownlee = new Brownlee("Sean");
            brownlee.Describe();

           

        }


        class Fruities
        {
            string Fruit1 = "banana";
            public void eatFruits()
            {
                Console.WriteLine($"I love eating {Fruit1}");
            }
        }
    }



    class Veggies
    {
        // PROPERTY
        // Stores the value/name of the vegetable.
        // { get; set; } allows the value to be read and changed.
        // "lettuce" is the default value.
        public string vegetable1 { get; set; } = "lettuce";

        // METHOD
        // A behavior/action of the Veggies class.
        // This method displays a message using the vegetable1 property.
        public void EatVeggies()
        {
            Console.WriteLine($"I Love to eat {vegetable1}");
        }

        // TOSTRING() METHOD OVERRIDE
        // Overrides the default ToString() behavior of objects.
        // Instead of displaying:
        // Namespace_and_Comments.Veggies
        // it will now display the value of vegetable1.
        public override string ToString()
        {
            return vegetable1;
        }
    }
}