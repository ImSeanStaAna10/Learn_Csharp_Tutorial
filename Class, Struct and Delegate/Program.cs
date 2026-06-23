using System;
using System.Security.Cryptography.X509Certificates;

// Value Types: int, double, bool, char, enum, struct
// Reference Types: string, class, array, interface, delegate, object
// CLASS - Reference type 
// STRUCT - Value Type
// DELAGATE -  Reference type and is a type that reference to methods with a particular parameter list and  return type;
// DELAGATE - are used to pass methods as arguments to other methods;

namespace Class__Struct_and_Delegate
{
     class Program
    {
        static void Main(string[] args)
        {
            #region -- NOT USING CLASS -- 
            //not efficient
            string firstNameSean;
            string lastNameStaana;

            string firstNameJohn;
            string lastNameJohn;
            #endregion

            #region -- USING CLASS -- 
            // first version
            var sean = new Person();
            sean.FistName = "Sean";
            sean.LastName = "Sta Ana";

            // recommended version
            var cardo = new Person() {
                FistName = "Cardo",
                LastName = "Dalisay"
            };
            
            // using overloading properties
            var maria = new Person("Maria"){
                LastName = "Clara"
            };
            var frace = new Person("frace", "Marteja");
            #endregion

            #region -- SAMPLE --
            // accessing the person class attributes properties and methods
            var person = new Person("Sean", "Sta Ana") // instantiation ginamit yung constructor na may dalawang parameters since nag overloading sa constructor
            {
                NickName = "Chandrick",
                BirthDate = new DateTime(2004, 05, 10) 
            };
            person.NickNameHand1er += NickNameChanging; // 5. kapag nag raise ng event tatawagin rin si nickName changing  / += (subscribe) -+ (unsubs))
            person.Update( 21, "Ace");
            Console.WriteLine($@"
                                  Name:{person.FullName}
                                  AGE: {person.GetAge()}
                                  NickName: {person.NickName}
                                  SampleInt: {person.Sample}");

            #endregion

            #region -- STRUCT -- 
            // Object instantiation same as class
            var apple = new Fruit() {Name = "Apple" , Color = "Red"};
            var mango = new Fruit("Mango", "Yellow");



            #endregion


            #region -- DELEGATE --  
            var luffy = new Person("Luffy", "Monkey")
            {
                NickName = "Strawhat"
            };

            luffy.FavoritesFruits.Add(new Fruit("Mango", "Yellow"));
            luffy.AddFavoriteFruit(new Fruit("Apple", "Red"), AddNewFruit);
            luffy.DeleteFavoriteFruit(luffy.FavoritesFruits[0], (prutas) => { 
                Console.WriteLine($"DELETED FRUIT: {prutas.Name}");
                return 1;
            });

            Console.WriteLine($"List Of fruits");
            foreach (var allFruits in luffy.FavoritesFruits)
            {
                Console.WriteLine($"Fruits {allFruits.Name}");
            }
            #endregion


        }
        #region -- EVENT --
        private static void NickNameChanging(object sender, NickNameArgs args) // 4. eto yung subscriber method eto yung method na naghihintay ng notification or i ko call pag ka may event
        {
            Console.WriteLine($"NickName is Changing to: {args.NickName}");
        }
        #endregion

        #region -- DELEGATE -- 
        private static int AddNewFruit(Fruit prutas)
        {
            Console.WriteLine($"Added new Fruit {prutas.Name}");
            return 1;

        }
        #endregion
    }
}
