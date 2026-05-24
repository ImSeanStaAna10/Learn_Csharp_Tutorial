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



            #endregion

            #region ======== ENUMERABLE, COLLECTION, LIST (C# COLLECTION TYPES) =====================
            // ======================================================
            // ENUMERABLE, COLLECTION, LIST (C# COLLECTION TYPES)
            // ======================================================
       


            /*
            ======================================================
            C# COLLECTION TYPES OVERVIEW
            ======================================================

            1. IEnumerable<T>
               - READ-ONLY at forward-only access lang
               - Pwede lang i-loop gamit foreach
               - Hindi pwede i-modify (no Add, Remove, Update)
               - Walang indexing ([ ])
               - Best for: reading or iteration lang

            2. ICollection<T>
               - Mas flexible kaysa IEnumerable
               - Pwede mag Add, Remove, Count
               - Wala pa ring indexing support ([ ])
               - Best for: basic manipulation ng collection

            3. List<T>
               - Pinaka flexible at commonly used
               - Pwede Add, Remove, Insert, Update, Indexing
               - Full control sa data
               - Best for: dynamic and editable data
            */

            #region -- ENUMERABLE --

            #region Description
            // IEnumerable is READ-ONLY at forward-only lang
            // Pwede mo lang siya i-loop gamit foreach
            // Hindi mo siya pwedeng i-edit or i-index
            #endregion

            var countries = new[] { "Philippines", "Japan", "Korea", "China" };
            IEnumerable<string> enumCountries = countries;  // convert array to IEnumerable
            // enumCountries[0] = "America"; bawal kasi walang indexing at read-only

            Console.WriteLine("\n----- ENUMERABLE -----");
            foreach (var country in enumCountries)
            {
                Console.WriteLine(country);
            }

            #endregion

            #region -- COLLECTION --

            #region Description
            // ICollection mas flexible kaysa IEnumerable
            // Pwede mag Add at Remove
            // Pero wala pa ring indexing ([ ])
            #endregion

            Console.WriteLine("\n----- COLLECTION -----");


            ICollection<string> colCountries = new List<string>(countries); // convert array to ICollection via List


            colCountries.Add("Australia"); // adding elements
            colCountries.Add("America"); // adding elements
            colCountries.Remove("China"); // removing element

            // colCountries[2] = "Sample"; bawal kasi walang indexing

            Console.WriteLine("**************************");

            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }

            #endregion

            #region -- LIST --

            #region Description
            // List<T> pinaka powerful sa tatlo
            // Pwede Add, Remove, Update, Insert, at Indexing
            // Full control sa elements
            #endregion

            var listCountries = new List<string>(countries); // from array

            var listInitCountries = new List<string>()
            {
                "Philippines",
                "USA"
            };

            var listCountriesNew = new List<string>();

            // adding single items
            listCountriesNew.Add("Philippines");
            listCountriesNew.Add("USA");

            // adding multiple items
            listCountriesNew.AddRange(new[] { "Canada", "Australia" });

            // remove item (check spelling dapat exact match)
            listCountriesNew.Remove("Philippines");

            // update using index
            listCountriesNew[0] = "America";

            Console.WriteLine("\n----- LIST -----");

            // looping using for loop (may index access)
            for (var index = 0; index < listCountriesNew.Count; index++)
            {
                Console.WriteLine($"{index}: {listCountriesNew[index]}");
            }

            #endregion

            #endregion

        }
    }
}