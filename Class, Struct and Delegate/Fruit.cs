using System;
using System.Collections.Generic;
using System.Text;



namespace Class__Struct_and_Delegate
{
    public struct Fruit
    {
        //PROPERTIES
        public string Name { get; set; }
        public string Color { get; set; } //bawal sa struck mag set ng inital value sa properties sa class lang yun pwede

        //CONSTRUCTOR
        public Fruit(String name , string color)
        {
            Name = name;
            Color = color; 
        }
    }
}
