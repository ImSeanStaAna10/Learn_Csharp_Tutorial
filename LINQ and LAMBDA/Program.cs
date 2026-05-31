
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


// query  - set of instruction thats describes what data to retrieve from a given data sournce or sources
// LINQ - is parang sql query lang
// Lambda -  using Lambda expressions short function


namespace LINQ_and_LAMBDA
{
    class Program
    {
        public static void Main(string[]args)
        {

            // print even numbers only 
            var numbers = new[] { 5, 6, 2, 9, 1 };
            #region -- first sample -- 

            #region -- FOR EACH AND IF-ELSE
            //using Loop and if-else
            var evenNumbers = new List<int>(); // empty list dito ilalagay yung mga even numbers
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            Console.WriteLine("FOR EACH AND IF");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }
                
            Console.WriteLine("**********************");

            #endregion

            #region -- LINQ --
            Console.WriteLine("LINQ");
            //USING LINQ
            /*
              * FROM bawat "number" sa loob ng "numbers"
             -> Kukunin at iikutan isa-isa lahat ng values/items
             -> Kada ikot, ang current item tatawaging "number"

             WHERE ang number ay divisible by 2
             -> Iche-check kung ang current number ay even
             -> Kapag ang remainder ay 0 pagkatapos hatiin sa 2,
                ibig sabihin pasado sa condition

             SELECT yung number
             -> Yung mga numbers lang na pumasa sa condition
                ang isasama sa final result/output
             */
            var linqEvenNumbers = from number in numbers where number % 2 == 0 select number;
            foreach (var even in linqEvenNumbers)
            {
                Console.WriteLine(even);
            }

            #endregion

            #region -- LAMBDA EXPRESSION --
            /*
            LINQ + Lambda (Where filter)

            numbers.Where(number => number % 2 == 0)

            Where()
            -> pumipili lang ng data sa list

            number
            -> bawat item sa numbers

            => 
            -> ibig sabihin "check ito"

            number % 2 == 0
            -> check kung even number
            -> kapag walang remainder, pasado

            RESULT:
            -> kukunin lang yung even numbers
            */

            Console.WriteLine("************** LAMBDA EXPRESSION ******************");
            var lambdaEvenNumbers = numbers.Where(number => number % 2 == 0);
            foreach (var even in lambdaEvenNumbers)
            {
                Console.WriteLine(even);
            }
            #endregion

            #endregion

            #region -- WITH ORDER AND TRANSFORMATION OF DATA -- 

            Console.WriteLine("- WITH ORDER AND TRANSFORMATION OF DATA -- ");
            Console.WriteLine();

            //Print only those numbers less than 9 
            var mixedNumbers = new[] { 3, 5, 6, 9 };

            #region -- loopings and Conditional stsment
            var numberContainer = new List<int>(); 
            Console.WriteLine("------------- LOOPINGS AND CONDITIONAL ----------------");

            // filter
            foreach (var mixNum in mixedNumbers)
            {
                if (mixNum < 9 )
                {
                    numberContainer.Add(mixNum);
                }
            }

            for (int i = numberContainer.Count - 1 ; i>=0; i--)
            {
                Console.WriteLine($"NUMERO: {numberContainer[i]}");
            }

         
            #endregion

            #region -- LINQ --
            //Linq
            var linqQuery = from number in mixedNumbers
                            where number <  9
                            orderby number descending
                            select $"NUMERO: {number}";

            Console.WriteLine("------------- LINQ ----------------");
            foreach (var num in linqQuery)
            {
                Console.WriteLine(num);
            }
            #endregion

            #region -- LAMBDA -- 
            var lambdaQuery = mixedNumbers
                            .Where(number => number < 9)
                            .OrderByDescending(number => number)
                            .Select(number => $"NUMERO:{number}");
            Console.WriteLine("------------- LAMBDA ----------------");
            foreach (var num in lambdaQuery)
            {
                Console.WriteLine(num);
            }


            #endregion

            #endregion


            #region -- JOINS --

            Console.WriteLine("********* JOINS *******************");
            Console.WriteLine();
            var students = new List<Student>()
            {
               new Student("Luffy",17,1),
               new Student("Sabo",19,2),
               new Student("Ace",22,1)
            };

            var sections = new List<Section>()
            {
                new Section("Pirate" ,  1),
                new Section("Revolutionary", 2)

            };

            #region -- LINQ -- 
            Console.WriteLine("**************** LINQ VERSION *******************");
            //linq
            var query = from section in sections // Kunin ang bawat section mula sa sections.
                        join student in students  on section.Grade equals student.Grade // I-match ang bawat section sa students. Pag pareho ang Grade ng section and student, pagsamahin sila. 
                        where student.Age < 25 // Kunin lang ang students na mas mababa sa 25 years old.
                        orderby student.Age, student.Grade // I-sort ayon sa Age, kapag pareho ang Age, saka gamitin ang Grade.
                        select new // Gumawa ng bagong object.
                        {
                            section.SectionName,
                            StudentName = student.Name,
                        };

            foreach (var sectionAndStudent in query)
            {
                Console.WriteLine($"Section: {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            }

            #endregion




            #region -- LAMBDA --
            
            Console.WriteLine("**************** LAMBDA VERSION ***********************");
            var lambdaQuerys = sections // start with section
               .Join( // join section in other collection
                students.Where(student => student.Age < 25), // first parameter,  join sa student na may age na < 25
                section => section.Grade, // second parameter, sa section grade ang gagamiting key
                student => student.Grade,// third parameter, sa student grade din gagamitin na key
                (section, student) => new // pag may matching grade gumawa ng new object
                {
                    section.SectionName,
                    StudentName = student.Name,
                    student.Age,
                    student.Grade
                } 
                )
               .OrderBy(student => student.Age) // I-sort ko ang result gamit ang Age.
               .ThenBy(student => student.Grade); // Kapag pareho ang Age, Grade naman ang gamitin.

            foreach (var sectionAndStudent in lambdaQuerys)
            {
                Console.WriteLine($"Section: {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            }

            #endregion
            #endregion


        }
    }

    #region -- FOR DEMO PURPOSES --

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
    public class Section
    {
        public string SectionName { get; set; }
        public int Grade {get; set;  }

        public Section(string sectionName, int grade)
        {
            SectionName = sectionName;
            Grade = grade;
        }
    }
    #endregion
}