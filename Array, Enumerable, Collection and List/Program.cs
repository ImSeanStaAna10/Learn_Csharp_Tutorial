using System;
using System.Collections.Generic;
// ======================================================
// ARRAY IN C#
// ======================================================
//
// Array
// - A collection of multiple values stored in ONE variable.
// - All elements inside an array must have the SAME data type.
// - Each value inside the array is called an ELEMENT.
// - Every element has an INDEX NUMBER.
// - Index always starts at 0.
//
// Arrays are FIXED in size.
// - Meaning: once the size is set,
//   it cannot be changed later.
//
// Used when:
// - You need to store many related values.
// - Example:
//      Student names
//      Scores
//      Numbers
//      Products
//
// Syntax:
// dataType[] arrayName = new dataType[size];
//

namespace Array_Enumerable_Collection_List
{
    using Microsoft.VisualBasic;
    using System;

    class Program
    {
        static void Main()
        {

            #region ====================== ARRAY ======================

            // ======================================================
            // 1D ARRAY (ONE-DIMENSIONAL ARRAY)
            // ======================================================

            #region -- 1 DIMENSIONAL ARRAY --

            // One-dimensional array
            // Fixed size (10 elements)
            // Stores values in a single line

            int[] number = new int[10];

            number[0] = 2;
            Console.WriteLine(number[0]);

            // One-dimensional array with initial values
            // Auto-sized based on number of elements

            int[] numbersWithInit = new int[] {1, 2, 3};

            Console.WriteLine("\n------------------ 1 DIMENSIONAL ARRAY ------------------");

            // ======================================================
            // ACCESSING ARRAY USING FOR LOOP
            // ======================================================

            Console.WriteLine("\n----- Accessing Array using FOR LOOP -----");

            for (int index = 0; index < numbersWithInit.Length; index++)
            {
                Console.WriteLine($"Index: {index}");
                Console.WriteLine(numbersWithInit[index]);
            }

            // ======================================================
            // ACCESSING ARRAY USING FOREACH LOOP
            // ======================================================

            Console.WriteLine("\n----- Accessing Array using FOREACH LOOP -----");

            foreach (int newNumber in numbersWithInit)
            {
                Console.WriteLine(newNumber);
            }

            #endregion


            // ======================================================
            // JAGGED ARRAY (ARRAY OF ARRAYS)
            // ======================================================

            #region -- JAGGED ARRAY (ARRAY OF ARRAYS) --

            // Jagged array = array of arrays
            // [3] = number of OUTER ARRAYS (rows)
            // Fixed ang outer size
            // Flexible ang laman ng bawat row

            int[][] multiNumbers = new int[3][]
            {
            new int[] { 1, 2, 3 },         // Row 0
            new int[] { 4, 5, 6 },         // Row 1
            new int[] { 7, 8, 9, 10 }      // Row 2
            };

            Console.WriteLine("\n------------------ JAGGED ARRAY ------------------");

            // ======================================================
            // JAGGED ARRAY EXAMPLE 1 (FOREACH LOOP)
            // ======================================================

            Console.WriteLine("\n----- Jagged Array Example 1 (FOREACH) -----");

            foreach (int[] row in multiNumbers)
            {
                foreach (int value in row)
                {
                    Console.WriteLine(value);
                }
            }

            // ======================================================
            // JAGGED ARRAY EXAMPLE 2 (FOR LOOP)
            // ======================================================

            Console.WriteLine("\n----- Jagged Array Example 2 (FOR LOOP) -----");

            var rowAndCells = new int[3][]
            {
            new[] { 1, 2, 3 }, // Row 0
            new[] { 4, 5, 6 }, // Row 1
            new[] { 7, 8, 9 }  // Row 2
            };

            // Outer loop = rows
            for (int row = 0; row < rowAndCells.Length; row++)
            {
                Console.WriteLine($"Row: {row}");

                // Inner loop = values inside row
                foreach (int cell in rowAndCells[row])
                {
                    Console.WriteLine($"Value: {cell}");
                }
            }

            // IMPORTANT:
            // - Outer array = fixed
            // - Inner arrays = flexible
            // - Kaya "jagged" dahil pwede iba-iba ang length ng bawat row

            #endregion


            // ======================================================
            // 2D / MULTIDIMENSIONAL ARRAY
            // ======================================================

            #region -- 2D / MULTIDIMENSIONAL ARRAY --

            // Multidimensional Array (2D)
            // [rows, columns]
            // Fixed rows and columns

            string[,] cars = new string[3, 2];

            Console.WriteLine("\n------------------ 2D ARRAY ------------------");

            // ======================================================
            // ASSIGNING VALUES
            // ======================================================

            cars[0, 0] = "Honda";
            cars[0, 1] = "Mitsubishi";

            cars[1, 0] = "Ford";
            cars[1, 1] = "Bugatti";

            cars[2, 0] = "Ferrari";
            cars[2, 1] = "Porsche";
            /*
                              COLUMNS
                         [0]          [1]
                     ┌──────────┬──────────────┐
            ROW [0] │  Honda   │  Mitsubishi  │
                     ├──────────┼──────────────┤
            ROW [1] │  Ford    │   Bugatti    │
                     ├──────────┼──────────────┤
            ROW [2] │ Ferrari  │   Porsche    │
                     └──────────┴──────────────┘
             
             */
            // ======================================================
            // ITERATING 2D ARRAY
            // ======================================================

            // GetLength(0) = rows
            for (int row = 0; row < cars.GetLength(0); row++)
            {
                Console.WriteLine($"\nRow: {row}");

                // GetLength(1) = columns
                for (int col = 0; col < cars.GetLength(1); col++)
                {
                    Console.WriteLine($"[{row},{col}] = {cars[row, col]}");
                }
            }

            // ======================================================
            // 2D ARRAY SHORTCUT EXAMPLE
            // ======================================================

            // 3 rows, 2 columns

            int[,] otherNumbers2 =
            {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

            #endregion


            // ======================================================
            // SAMPLE ARRAY EXAMPLES
            // ======================================================

            #region -- SAMPLE ARRAY --

            // ======================================================
            // IMPLICIT TYPE (SHORTCUT)
            // ======================================================

            Console.WriteLine("\n************** IMPLICIT TYPE EXAMPLE **************");

            var names = new[]
            {
            "Sean",
            "Chandrick",
            "Sta Ana"
        };

            Console.WriteLine("\n----- Before Update -----");

            foreach (var myName in names)
            {
                Console.WriteLine(myName);
            }

            // Reassign specific index
            names[0] = "Seansaints";

            Console.WriteLine("\n----- After Update -----");

            foreach (var newName in names)
            {
                Console.WriteLine(newName);
            }

            // ======================================================
            // EXPLICIT TYPE (NON-SHORTCUT)
            // ======================================================

            Console.WriteLine("\n************** EXPLICIT TYPE EXAMPLE **************");

            string[] fruits = new string[]
            {
            "apple",
            "banana",
            "orange"
            };

            Console.WriteLine("\n----- Before Update -----");

            foreach (string myFruit in fruits)
            {
                Console.WriteLine(myFruit);
            }

            // Update specific index
            fruits[2] = "watermelon";

            Console.WriteLine("\n----- After Update -----");

            foreach (string myFruit in fruits)
            {
                Console.WriteLine(myFruit);
            }

            Console.WriteLine($"\nFruit in index 2: {fruits[2]}");

            #endregion


            #region -- ENUMERABLE , COLLECTION , LIST --
            #region -- ENUMERABLE --

            //enumerable is READ ONLY  reassigning is not allowerd
            var countries = new[] { "Philippines", "japan", "Korea", "China" };
            IEnumerable<string> enumCountries = countries;
            //enumCountries[0] = "America"; - NOT ALLOWED
            // access it using for each
            Console.WriteLine("\n-----ENUMERABLE-----------");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
            #endregion


            #region -- COLLECTION --
            Console.WriteLine("\n-----COLLECTION-----------");
            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Add("America");
            colCountries.Remove("China");
            Console.WriteLine("**************************");
            //colCountries[2] = "Sample"; - di pwede mag access ng index sa collection
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }

            #endregion



            #region -- LIST --
            var listCountries = new List<string>(countries); // with inital value from array
            var listInitCountries = new List<string>() // with inital value
            {
                "Phillippines",
                "USA"
            };

            var listCountriesNew = new List<string>();
            listCountriesNew.Add("Philippines");
            listCountriesNew.Add("USA");
            listCountriesNew.AddRange(new[] { "Canada", "Australia" });
            listCountriesNew.Remove("Philipines");
            listCountriesNew[0] = "America";

            Console.WriteLine("\n-----LIST -----------");

            for (var index = 0; index < listCountriesNew.Count; index++)
            {
                Console.WriteLine($"{index}: {listCountriesNew[index]}");
            };


            #endregion



            #endregion
            #endregion

        }
    }
}