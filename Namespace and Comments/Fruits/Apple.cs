using System;
using System.Collections.Generic;
using System.Text;

namespace Namespace_and_Comments.Fruits
{
    internal class Apple
    {
        // PROPERTIES (data of the apple)
        public string Color { get; set; }
        public double WeightInGrams { get; set; }
        public bool IsRipe { get; set; }

        // CONSTRUCTOR - sets default values when object is created
        public Apple(string color, double weightInGrams, bool isRipe)
        {
            Color = color;
            WeightInGrams = weightInGrams;
            IsRipe = isRipe;
        }

        // METHOD - behavior of the apple
        public void Describe()
        {
            Console.WriteLine($"Apple Color: {Color}");
            Console.WriteLine($"Weight: {WeightInGrams}g");
            Console.WriteLine($"Is Ripe: {IsRipe}");
        }

        public void Eat()
        {
            if (IsRipe)
            {
                Console.WriteLine("You ate a sweet apple YUMMY!!!");
            }
            else
            {
                Console.WriteLine("This apple is not ripe yet!");
            }
        }
    }
}