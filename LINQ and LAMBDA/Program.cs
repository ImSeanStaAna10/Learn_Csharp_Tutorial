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
        public static void Main(string[] args)
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

            var linqEvenNumbers =
                from number in numbers
                where number % 2 == 0
                select number;

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

            var lambdaEvenNumbers =
                numbers.Where(number => number % 2 == 0);

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
                if (mixNum < 9)
                {
                    numberContainer.Add(mixNum);
                }
            }

            for (int i = numberContainer.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"NUMERO: {numberContainer[i]}");
            }

            #endregion

            #region -- LINQ --

            var linqQuery =
                from number in mixedNumbers
                where number < 9
                orderby number descending
                select $"NUMERO: {number}";

            Console.WriteLine("------------- LINQ ----------------");

            foreach (var num in linqQuery)
            {
                Console.WriteLine(num);
            }

            #endregion

            #region -- LAMBDA -- 

            var lambdaQuery =
                mixedNumbers
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
               new Student("Luffy",22,1),
               new Student("Sabo",25,2),
               new Student("Ace",30,1)
            };

            var sections = new List<Section>()
            {
                new Section(1, "Pirate"),
                new Section(2 , "revolutionary")
            };

            #region -- LINQ -- 

            Console.WriteLine("**************** LINQ VERSION *******************");

            var query =
                from section in sections
                join student in students on section.Grade equals student.Grade
                where student.Age > 20
                orderby student.Age, student.Grade
                select new
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

            var lambdaQuerys =
                sections
                    .Join(
                        students.Where(student => student.Age > 20),
                        section => section.Grade,
                        student => student.Grade,
                        (section, student) => new
                        {
                            section.SectionName,
                            StudentName = student.Name,
                            student.Age,
                            student.Grade
                        }
                    )
                    .OrderBy(student => student.Age)
                    .ThenBy(student => student.Grade);

            foreach (var sectionAndStudent in lambdaQuerys)
            {
                Console.WriteLine($"Section: {sectionAndStudent.SectionName}, Student Name: {sectionAndStudent.StudentName}");
            }

            #endregion
            #endregion


            #region -- GROUPINGS --

            Console.WriteLine("********* GROUPINGS *******************");

            var cars = new List<Cars>()
            {
                new Cars("Toyota", "Red", "Corolla" , 2010),
                new Cars("Honda" , "Red", "Vios", 2009),
                new Cars("Honda" , "Red", "Vios", 2009),
                new Cars("Honda" , "Red", "Vios", 2009),
            };

            #region -- LINQ -- 

            Console.WriteLine("********* LINQ *******************");

            var groupLinq =
                from car in cars
                group car by car.modelYear into carModelYear
                select new carGroup
                {
                    ModelYear = carModelYear.Key,
                    Count = carModelYear.Count()
                };

            foreach (var carModelYear in groupLinq)
            {
                Console.WriteLine($"Year: {carModelYear.ModelYear}, Count: {carModelYear.Count}");
            }

            #endregion


            #region -- LAMBDA --

            Console.WriteLine("********* LINQ *******************");

            var lambdaGroup =
                cars.GroupBy(car => car.modelYear)
                    .Select(group => new carGroup
                    {
                        ModelYear = group.Key,
                        Count = group.Count()
                    });

            foreach (var carModelYear in lambdaGroup)
            {
                Console.WriteLine($"Year: {carModelYear.ModelYear}, Count: {carModelYear.Count}");
            }

            #endregion
            #endregion


            #region -- LAMBDA ONLY FUNCTION / BASIC AGGREGATION --

            Console.WriteLine("********* LAMBDA ONLY FUNCTIONS *******************");

            var sampleNumber = Enumerable.Range(1, 10);
            Console.WriteLine("Sample Number: " + string.Join(", ", sampleNumber));

            Console.WriteLine("------- AVERAGE FUNCTION -------");

            var average = sampleNumber.Average();
            var num1to5average = sampleNumber.Where(num => num <= 5).Average();

            Console.WriteLine($"Average {average}");
            Console.WriteLine($"Average number 1 to 5: {num1to5average}");

            var count = sampleNumber.Count();
            var min = sampleNumber.Min();
            var max = sampleNumber.Max();
            var summation = sampleNumber.Sum();

            Console.WriteLine($"COUNT: {count}, MAX: {max}, MIN: {min}, SUMMATION: {summation}");

            #endregion


            #region -- CONVERSION --

            Console.WriteLine("********* CONVERSION *******************");

            var sampleNumber2 = Enumerable.Range(1, 15);

            var list = new List<int>(sampleNumber2);
            var enumValue = list.AsEnumerable();
            var backtoList = enumValue.ToList();

            list = (from numbersSamp in sampleNumber2 where numbersSamp >= 5 select numbersSamp).ToList();

            list.Add(16);

            Console.WriteLine("CONVERSION: " + string.Join(",", list));

            #endregion


            #region -- BASIC ELEMENT ACCESS -- 

            Console.WriteLine("------- BASIC ELEMENT ACCESS -------");

            var numbersSamp2 = Enumerable.Range(1, 10);

            var firstNumber = numbersSamp2.FirstOrDefault();
            var lastNumber = numbersSamp2.LastOrDefault();
            var firstEvenNumber = numbersSamp2.FirstOrDefault(n => n % 2 == 0);

            var firstWithoutDefault = numbersSamp2.First();
            var lastWithoutDefault = numbersSamp2.Last();

            Console.WriteLine($"First Number: {firstNumber}, Last Number: {lastNumber}, First Even Number: {firstEvenNumber}");
            Console.WriteLine($"First without default: {firstWithoutDefault}, Last without default: {lastWithoutDefault}");

            #endregion


            #region -- PARTITIONING --

            Console.WriteLine("------- PARTITIONING -------");

            var sampleNumber3 = Enumerable.Range(1, 10);

            var numbersSkip5 = sampleNumber3.Skip(5);
            var numbersSkipWhile = sampleNumber3.SkipWhile(n => n < 5);

            var numbersTake5 = sampleNumber3.Take(5);
            var numberTakeWhile = sampleNumber3.TakeWhile(n => n < 5);

            Console.WriteLine($"Skip5: {string.Join(",", numbersSkip5)}");
            Console.WriteLine($"SkipWhile < 5: {string.Join(",", numbersSkipWhile)}");
            Console.WriteLine($"Take5: {string.Join(",", numbersTake5)}");
            Console.WriteLine($"TakeWhile < 5: {string.Join(",", numberTakeWhile)}");

            #endregion


            #region -- SET  --

            Console.WriteLine("------- SET -------");

            var repeatedNumbers = new[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };
            var distinctNumbers = repeatedNumbers.Distinct();

            Console.WriteLine($"Distinct Numbers: {string.Join(",", distinctNumbers)}");

            var sampleNumbers4 = Enumerable.Range(1, 10);
            var excludeNumbers = new[] { 5, 6, 7 };
            var newNumbers = sampleNumbers4.Except(excludeNumbers);

            Console.WriteLine($"Exclude : {string.Join(",", newNumbers)}");

            var sampleNumbers5 = Enumerable.Range(1, 10);
            var checkerNumbers = new int[] { 1, 2, 3 };
            var intersectNumbers = sampleNumbers5.Intersect(checkerNumbers);

            Console.WriteLine($"Intersect: {string.Join(",", intersectNumbers)}");

            var sampleNumbers6 = Enumerable.Range(1, 10);
            var appendNumbers = new[] { 10, 11, 12, 13, 14, 15 };
            var unionNumbers = sampleNumbers6.Union(appendNumbers);

            Console.WriteLine($"Union: {string.Join(",", unionNumbers)}");
        }

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
    public int Grade { get; set; }
    public string SectionName { get; set; }

    public Section(int grade, string sectionName)
    {
        Grade = grade;
        SectionName = sectionName;
    }
}

public class Cars
{
    public string Brand { get; set; }
    public string Color { get; set; }
    public string carName { get; set; }
    public int modelYear { get; set; }

    public Cars(string brand, string color, string name, int model)
    {
        Brand = brand;
        Color = color;
        carName = name;
        modelYear = model;
    }
}

public class carGroup
{
    public int ModelYear { get; set; }
    public int Count { get; set; }
}

    #endregion
