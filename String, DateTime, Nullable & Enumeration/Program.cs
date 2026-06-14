using System;
using System.Text; // ginagamit para sa StringBuilder class, na ginagamit para sa efficient string manipulatio

namespace String_DateTime_Nullable_Enumeration {
    class program
    {
        public static void Main(string[] agrs)
        {
            #region-- STRING --

            string sampleString; // string is a sequence of characters, used to store text
            string sampleStringWithNullValue = null; // string can be null, but it can also have a value
            String stringUsingClass = "Test"; // String with capital S is the class, string with small s is the keyword

            var myName = "Sean"; // equivalent to literal
            myName += " Chandrick"; // concatenation, adds the string to the existing value of myName
            Console.WriteLine("Print Characters using loop");
            foreach (var c in myName)
            {
                Console.WriteLine(c); // prints each character in myName on a new line
            }
            char[] nameCharacters = myName.ToCharArray(); // converts the string to an array of characters
            var stringFromArray = new String(nameCharacters); // creates a new string from the array of characters

            // Verbatim string - ginagamit para mapanatili ang exact formatting
            // ng string tulad ng new lines, tabs, at backslashes nang hindi
            // na kailangang gumamit ng escape characters.
            var stringWithSpecialCharacters = @" ""hello world""";
            var stringWithMultipleLines = @"S
                                            e
                                            a
                                            n
                                            ";

            Console.WriteLine(stringWithSpecialCharacters);

            Console.WriteLine(stringWithMultipleLines);

            // String escape Sequence
            var stringWithNewTabAndNewLine = "my\tname\tis:\nSean";
            Console.WriteLine(stringWithNewTabAndNewLine);
            #endregion

            #region--STRING BUILDER---
            //IMMUTABL ISSUE
            // Immutability Issue:
            // A string cannot be changed after it is created.
            // Every time += is used, a new string object is created instead of modifying the existing one.
            var sampString = "number";
            for (var number = 0; number <= 5; number++)
            {
                sampString += number;
            }
            Console.WriteLine("Immutable Issue: Using normal Concatination");
            Console.WriteLine(sampString);

            // SOLUTION: StringBuilder
            var sb = new StringBuilder();
            sb.Append("number");
            for (var number = 1; number <= 5; number++)
            {
                sb.Append(number.ToString());
            }
            Console.WriteLine("USING STRONG BUILDER CLASS");
            Console.WriteLine(sb.ToString());



            #endregion

            #region-- NUMERIC STANDARD FORMATTING--
            /*
             NUMERIC STANDARD FORMATTING
             C -Currency
              N - Number with commas and decimal places
                P - Percentage
                  E - Exponential notation
                    D - Decimal (for integers)
             */

            var myNumericValue = 123456.789;
            Console.WriteLine("Currency: " + myNumericValue.ToString("C"));
            Console.WriteLine("Number: " + myNumericValue.ToString("N"));
            Console.WriteLine("Percentage: " + myNumericValue.ToString("P"));

            var myNumber = 12345;
            Console.WriteLine("Decimal: " + myNumber.ToString("D10"));

            Console.WriteLine("Number with 2 decimal places only");
            Console.WriteLine(myNumericValue.ToString("N2")); // number with 2 decimal places only

            // Custom Numeric Formatting
            Console.WriteLine("Custom");
            Console.WriteLine(myNumericValue.ToString("PHP#,##0.00"));
            #endregion

            #region--COMPOSITE STRING FORMATTING--
            // string formatt interpolation

            var name = "Sean";
            var age = 22;
            var sampleMoney = 54321.1233345D;

            // STRING FORMAT
            Console.WriteLine("Using String Format");
            var stringOutput = string.Format("My name is {0} , I am {1} yrs old, sampleComputation {2}", name, age, 1 + 1);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:C}", sampleMoney));

            // STRING INTERPOLATION
            Console.WriteLine("STRING INTERPOLATION");
            var stringOutputInterpolation = $"My name is {name} , I am {age} yrs old, sampleComputation {1 + 1}";
            Console.WriteLine(stringOutputInterpolation);
            Console.WriteLine($"{sampleMoney:C}");
            #endregion

            #region--CHECKER--
            string firstString = null;
            string secondString = String.Empty; // empty string, not null but has no characters equivalent secondString = "";
            string thirdString = " ";
            if (firstString == null)
            {
                Console.WriteLine("firstString is null");
            }

            // version 1
            if (secondString != null && secondString != string.Empty)
            {
                Console.WriteLine("secondString is not null ");
            }
            else
            {
                Console.WriteLine("secondString is empty");
            }

            // version 2 - using string.IsNullOrEmpty() method
            if (!string.IsNullOrEmpty(secondString))
            {
                Console.WriteLine("V2 SecondString is not null");
            }
            else
            {
                Console.WriteLine("V2 secondString is empty");
            }

            // check string that is null, empty or blank (whitespaces only)
            if (string.IsNullOrWhiteSpace(thirdString))
            {
                Console.WriteLine("thirdString is null, empty or blank");
            }



            //COMMON CHECKER FUNCTIONS
            var myNameForChecker = "Sean";
            if (myNameForChecker.StartsWith("Se")) Console.WriteLine($"{myNameForChecker} starts with Se");
            if (myNameForChecker.EndsWith("n")) Console.WriteLine($"{myNameForChecker} ends with n");
            if (myNameForChecker.Contains("ea")) Console.WriteLine($"{myNameForChecker} contains ea");

            if (myNameForChecker == "sean")
            {
                Console.WriteLine($"{myNameForChecker} is equal to sean");

            }
            else
            {
                Console.WriteLine($"{myNameForChecker} is \"NOT\" equal to sean");
            }

            //IGNORE CASE COMPARISON - using String.Equals() method with StringComparison.InvariantCultureIgnoreCase
            if (myNameForChecker.Equals("sean", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"{myNameForChecker} is equal to sean ignoring case");
            }
            else {
                Console.WriteLine($"{myNameForChecker} is \"NOT\" equal to sean ignoring case");
            }


            #endregion

            #region-- COMMONLY USED FUNCTION TO MANIPULATE STRING VALUES --
            var myString = "HELLO WORLD";

            Console.WriteLine(myString);
            Console.WriteLine($"REVERSE: {new String(myString.Reverse().ToArray())}");
            Console.WriteLine($"REPLACE: {myString.Replace("WORLD", "STA ANA")}"); // replace world with sta ana
            Console.WriteLine($"SUBSTRING: {myString.Substring(3, 7)}"); //SUBSTRING (startIndex, lenght)
            Console.WriteLine($"lOWERCASE:  {myString.ToLower()}"); // lowercase
            Console.WriteLine($"UPPERCASE: {myString.ToUpper()}"); // uppercase

            var anotherString = " Sea n ";
            Console.WriteLine($"TRIM START: {anotherString.TrimStart(' ')}");
            Console.WriteLine($"TRIM END: {anotherString.TrimEnd(' ')}");
            Console.WriteLine($"TRIM START AND END: {anotherString.Trim(' ')}");
            Console.WriteLine($"TRIM START AND END AND REPLACE: {anotherString.Trim(' ').Replace(" ", string.Empty)}");

            var lastString = "Sean-Chandrick-Sta-Ana:String";
            Console.WriteLine(lastString);
            var words = lastString.Split('-');
            Console.WriteLine("===WORDS===");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            var wordsMultipleStringSeperator = lastString.Split(new char[] { '-', ':' });
            Console.WriteLine("=======WORDS WITH MULTIPLE SEPERATOR - AND :");
            foreach (var mulWord in wordsMultipleStringSeperator)
            {
                Console.WriteLine(mulWord);
            }

            Console.WriteLine(String.Join("*", wordsMultipleStringSeperator));
            #endregion

            #region--DATE and TIME
            Console.WriteLine("********** DATE AND TIME ************");
            var now = DateTime.Now;
            var today = DateTime.Today;
            var timeNow = now.TimeOfDay;
            var dateNow = now.Date;

            Console.WriteLine($"NOW: {now}");
            Console.WriteLine($"TODAY: {today}");
            Console.WriteLine($"TimeNow: {timeNow}");
            Console.WriteLine($"dateNow: {dateNow}");

            Console.WriteLine("EXAMPLE 2");
            var myDate = new DateTime(2025, 06, 14);
            Console.WriteLine($"MyDATE: {myDate}");
            //FORMATTING
            Console.WriteLine($"FORMATTED: {myDate:MMM dd,yyyy}");
            //COMPUTATION
            var yesterday = now.AddDays(-1);
            var tommorow = now.AddDays(1);
            var days = now.Subtract(myDate).Days;

            Console.WriteLine($"YESTERDAY:{yesterday}");
            Console.WriteLine($"TOMMOROW:{tommorow}");
            Console.WriteLine($"Now my date (number of days):{days}");
            #endregion

            #region-NULLABLE--
            string myString2 = null; //refernce type is nullable
            Nullable<int> myNumber1 = null; //pwede gawing nullableyung value type using NUllable
            int? secondNullableInt = null; //shortcut para gawing nullable

            //NULLABLE is equivalent to optional meanning int variables are optonal
            //VERSION 1
            if (myNumber1 != null)
            {
                Console.WriteLine("NOT NULL");

            }
            else
            {
                Console.WriteLine("NULL");
            }

            secondNullableInt = 5;
            //version 2
            if (myNumber1.HasValue || secondNullableInt.HasValue)
                Console.WriteLine(secondNullableInt.Value);

            #endregion

            #region--ENUMERATIONS--

            Console.WriteLine("ENUMS");
            var boyGender = Gender.Male;
            Console.WriteLine($"Gender {boyGender}, GenderValue {(int)boyGender}"); // casting

            switch (boyGender)
            {
                case Gender.Male:
                    Console.WriteLine("MALE");
                    break;
                case Gender.Female:
                    Console.WriteLine("FEMALE");
                    break;
                default:
                    Console.WriteLine("uNKNOWNS");
                    break;
            };

            var value = 1;

            Gender genderFromValue = (Gender)value;
            var stringValue = "Male";
            Gender genderFromString = (Gender)Enum.Parse(typeof(Gender), stringValue);
            Console.WriteLine($"gender from int: {genderFromValue}");
            Console.WriteLine($"gender from String: {genderFromString}");









        }

        public enum Gender // ENUM -  Enum represents a fixed set of named constants or choices. integer by default
        {
            Unknown,
            Male,
            Female,
            sample = 2 // pwde rin mag set ng values sa enums

        }

            #endregion
    }

}