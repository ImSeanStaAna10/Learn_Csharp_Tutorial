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
            var brownlee = new Brownlee();

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
            eatFruits.eat();
 

            
        }
    }

    class Fruities
    {
        public void eat()
        {
            Console.WriteLine("Eating fruits...");
        }
    }
}