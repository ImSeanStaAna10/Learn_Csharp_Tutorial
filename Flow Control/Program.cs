using System;
using System.Security.Cryptography.X509Certificates;

// ======================================================
// FLOW CONTROL IN C#
// ======================================================
//
// Flow Control
// - Controls the order of execution of statements in a program.
// - Determines what code will run, when it will run,
//   and how many times it will execute.
//
// Main Types of Flow Control:
// 1. Conditional Statements
//    -> Used for decision making.
//    -> Examples: if, else, else-if, switch
//
// 2. Loops / Iteration
//    -> Used for repeating code multiple times.
//    -> Examples: while, do-while, for, foreach
//
// ======================================================

namespace Flow_Control
{
    class Program
    {
        public static void Main(String[] args)
        {

            foodOrderSystem order = new foodOrderSystem();
            order.selectMenu();
            // ======================================================
            // CONDITIONAL STATEMENTS
            // ======================================================
            //
            // Conditional statements are used when a program
            // needs to make decisions based on conditions.
            //
            // Examples:
            // - if
            // - else
            // - else-if
            // - switch
            //
            // ======================================================

            #region -- IF / ELSE-IF / ELSE --

            // ------------------------------------------------------
            // CONSTANT VARIABLES
            // ------------------------------------------------------
            //
            // const
            // - Value cannot be changed once initialized.
            //
            // MAX_MINOR_AGE = maximum age for minors
            // MAX_SENIOR_AGE = minimum age for seniors
            //
            // ------------------------------------------------------

            const int MAX_MINOR_AGE = 17;
            const int MAX_SENIOR_AGE = 60;

            // ------------------------------------------------------
            // SAMPLE VARIABLES
            // ------------------------------------------------------
            //
            // isPWD
            // - true if person is a PWD
            //
            // age
            // - current age of customer
            //
            // ------------------------------------------------------

            var isPWD = true;
            var age = 25;

            Console.WriteLine("*************** EXAMPLE 1 **************");

            // ------------------------------------------------------
            // IF-ELSE IF-ELSE
            // ------------------------------------------------------
            //
            // if
            // - Executes if condition is TRUE
            //
            // else-if
            // - Checks another condition if previous condition is FALSE
            //
            // else
            // - Executes when all conditions are FALSE
            //
            // ------------------------------------------------------
            //
            // REQUIREMENT:
            // Give discounts to:
            // - Minors
            // - Seniors
            // - PWD
            //
            // ------------------------------------------------------

            if (age <= MAX_MINOR_AGE || age >= MAX_SENIOR_AGE)
            {
                // || means OR
                // TRUE if one condition is true

                Console.WriteLine("Add Minor and Senior Discount");
            }
            else if (isPWD)
            {
                Console.WriteLine("Give PWD Discount");
            }
            else
            {
                Console.WriteLine("Sorry, No Discount");
            }

            Console.WriteLine("*************** EXAMPLE 2 **************");

            // ------------------------------------------------------
            // USING NOT OPERATOR (!)
            // ------------------------------------------------------
            //
            // ! means NOT
            //
            // Requirement:
            // Adults only will NOT receive a 5 peso discount.
            //
            // Adult Age Range:
            // 18 - 59
            //
            // ------------------------------------------------------

            if (!(age < MAX_MINOR_AGE || age > MAX_SENIOR_AGE))
            {
                Console.WriteLine("No 5 Pesos Discount");
            }

            #endregion


            // ======================================================
            // SWITCH STATEMENT
            // ======================================================
            //
            // switch
            // - Used when checking multiple possible values.
            // - Cleaner alternative compared to many else-if statements.
            //
            // break
            // - Stops the switch after a matched case.
            //
            // default
            // - Executes if no case matches.
            //
            // ======================================================

            #region -- SWITCH --

            Console.WriteLine("*********** SWITCH EXAMPLE 1 *********************");

            var day = "WEDNESDAY";

            // ToLower()
            // - Converts all letters to lowercase
            // Example:
            // "WEDNESDAY" -> "wednesday"

            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("Today is Monday");
                    break;

                case "tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;

                case "wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;

                case "thursday":
                    Console.WriteLine("Today is Thursday");
                    break;

                case "friday":
                    Console.WriteLine("Today is Friday");
                    break;

                case "saturday":
                    Console.WriteLine("Today is Saturday");
                    break;

                case "sunday":
                    Console.WriteLine("Today is Sunday");
                    break;

                default:
                    Console.WriteLine("INVALID DAY");
                    break;
            }

            #endregion


            // ======================================================
            // WHILE LOOP
            // ======================================================
            //
            // while loop
            // - Repeats code while condition is TRUE.
            // - Condition is checked FIRST before execution.
            //
            // ======================================================

            #region -- WHILE LOOP --

            Console.WriteLine("WHILE LOOP");

            var count = 0;

            while (count < 3)
            {
                count++;

                Console.WriteLine(count);
            }

            #endregion


            // ======================================================
            // DO-WHILE LOOP
            // ======================================================
            //
            // do-while loop
            // - Executes code FIRST before checking condition.
            // - Guaranteed to run at least once.
            //
            // ======================================================

            #region -- DO WHILE --

            Console.WriteLine("DO-WHILE LOOP");

            var count2 = 0;

            do
            {
                Console.WriteLine("Print using DO WHILE");
                Console.WriteLine(count2);

                count2++;

            } while (count2 < 3);

            #endregion


            // ======================================================
            // FOR LOOP
            // ======================================================
            //
            // for loop
            // - Best used when number of repetitions is known.
            //
            // Structure:
            // for(initialization; condition; increment/decrement)
            //
            // index++
            // - Adds 1 to the current value
            //
            // ======================================================

            #region -- FOR LOOP --

            Console.WriteLine("FOR LOOP");

            for (var index = 0; index <= 5; index++)
            {
                Console.WriteLine($"Displaying Index {index}");
            }

            #endregion


            // ======================================================
            // FOREACH LOOP
            // ======================================================
            //
            // foreach loop
            // - Used for looping through collections or arrays.
            // - Automatically accesses each item one by one.
            //
            // ======================================================

            #region -- FOREACH LOOP --

            Console.WriteLine("FOREACH LOOP");

            var fruits = new[] { "apple", "banana", "orange" };

            foreach (var mgaPrutas in fruits)
            {
                Console.WriteLine($"Mga Prutas: {mgaPrutas}");
            }

            #endregion

            #region -- ACTIVITY: SIMPLE FOOD ORDER SYSTEM --

            // ======================================================
            // ACTIVITY: SIMPLE FOOD ORDER SYSTEM
            // ======================================================
            //
            // Concepts used:
            // - while loop (menu repetition)
            // - switch (menu selection)
            // - variables (cart / total)
            // - user input
            //
            // ======================================================

            //bool isRunning = true;
            //double totalBill = 0;

            //while (isRunning)
            //{
            //    Console.WriteLine("\n==================================");
            //    Console.WriteLine("      SIMPLE FOOD ORDER SYSTEM");
            //    Console.WriteLine("==================================");

            //    Console.WriteLine("[1] Burger  - 50 Pesos");
            //    Console.WriteLine("[2] Fries   - 35 Pesos");
            //    Console.WriteLine("[3] Drinks  - 25 Pesos");
            //    Console.WriteLine("[4] View Total");
            //    Console.WriteLine("[5] Exit");

            //    Console.Write("\nEnter Choice: ");
            //    var choice = Console.ReadLine();

            //    Console.WriteLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter Quantity: ");
            //            int burgerQty = Convert.ToInt32(Console.ReadLine());

            //            double burgerTotal = burgerQty * 50;
            //            totalBill += burgerTotal;

            //            Console.WriteLine($"Subtotal: {burgerTotal} Pesos");
            //            break;

            //        case "2":
            //            Console.Write("Enter Quantity: ");
            //            int friesQty = Convert.ToInt32(Console.ReadLine());

            //            double friesTotal = friesQty * 35;
            //            totalBill += friesTotal;

            //            Console.WriteLine($"Subtotal: {friesTotal} Pesos");
            //            break;

            //        case "3":
            //            Console.Write("Enter Quantity: ");
            //            int drinksQty = Convert.ToInt32(Console.ReadLine());

            //            double drinksTotal = drinksQty * 25;
            //            totalBill += drinksTotal;

            //            Console.WriteLine($"Subtotal: {drinksTotal} Pesos");
            //            break;

            //        case "4":
            //            Console.WriteLine("==================================");
            //            Console.WriteLine($"TOTAL BILL: {totalBill} Pesos");
            //            Console.WriteLine("==================================");
            //            break;

            //        case "5":
            //            Console.WriteLine("Exiting Program...");
            //            Console.WriteLine($"Final Bill: {totalBill} Pesos");
            //            isRunning = false;
            //            break;

            //        default:
            //            Console.WriteLine("INVALID MENU OPTION");
            //            break;
            //    }
            //}

            //Console.WriteLine("\nProgram Terminated...");
            #endregion
        }
             #region -- FOOD ORDER SYSTEM(MY APPROACH) --
        class foodOrderSystem
        {
            bool isRunning = true;
            double totalBill = 0;

            public void selectMenu()
            {
                while (isRunning)
                {

                    Console.WriteLine("[1] Burger  - 50 Pesos");
                    Console.WriteLine("[2] Fries   - 35 Pesos");
                    Console.WriteLine("[3] Drinks  - 25 Pesos");
                    Console.WriteLine("[4] View Total");
                    Console.WriteLine("[5] Exit");

                    Console.Write("\nEnter your Choice:");
                    var choice = Console.ReadLine();
                    var menuChoice = Convert.ToInt32(choice);

                    switch (menuChoice)
                    {
                        case 1:
                            menu1();
                        break;

                        case 2:
                            menu2();
                            break;

                        case 3:
                            menu3();
                            break;

                        case 4:
                            menu4();
                            break;

                        case 5:
                            menu5();
                            break;
                        default:
                            Console.WriteLine("INVALID CHOICE");
                            break;

                    }
                }
                Console.WriteLine("PROGRAM TERMINATED.......");
            }

            public void menu1()
            {
                Console.Write("Enter Quantity: ");
                int burgerQty = Convert.ToInt32(Console.ReadLine());
                double burgerTotal = burgerQty * 50;
                totalBill += burgerTotal;
                Console.WriteLine($"Subtotal: {burgerTotal} Pesos");
            }

            public void menu2()
            {
                Console.Write("Enter Quantity: ");
                int friesQty = Convert.ToInt32(Console.ReadLine());
                double friesTotal = friesQty * 35;
                totalBill += friesTotal;
                Console.WriteLine($"Subtotal: {friesTotal} Pesos");

            }
            public void menu3()
            {
                Console.Write("Enter Quantity: ");
                int drinksQty = Convert.ToInt32(Console.ReadLine());
                double drinksTotal = drinksQty * 25;
                totalBill += drinksTotal;
                Console.WriteLine($"Subtotal: {drinksTotal} PESOS");
            }

            public void menu4()
            {
                Console.WriteLine($"TOTAL BILL IS: {totalBill} PESOS!");

            }

            public void menu5()
            {
                Console.WriteLine("Exiting the program");
                Console.WriteLine($"Your total bill is: {totalBill} PESOS");
                isRunning = false;
            }
            #endregion
        }
    }
}