/* 
 * FileName Syntax.cs
 * Author: Briant Becote
 * Purpose: An overview of C# Syntax across variables, data structures, iteratives and operators.
 * Developed for UAT MS539 Syntax Examples
 * Drawn from Derek Banas C# Full Course: C# Tutorial For Beginners 
 * https://www.youtube.com/watch?v=M5ugY7fWydE&t=6345s
 * Timestamps from the YT video linked above
 * Block code using ctr K, ctr C - Unblock code using ctr k, ctr U
 */

using System; // Not required but used in almost all C#/.Net programs. This line makes all the types (classes, etc.) within the core .NET "System" namespace available for direct use in your code. It's like importing a toolbox full of the common features you'll need. 
//using System.Globalization;
//using System.Text; 

/*-------      -------*/
namespace ConsoleApp1 // Not required. A namespace is like a container or folder that helps organize your code.  It groups related classes, types, and other code elements, preventing naming conflicts and making your code more manageable.
{

    /* Access Modifiers - note the lower case access modifiers, lower case "class", upercase ClassName convention. Used on classes, methods, and .
     * These are the most typical ones:
     * public class PublicClass { }  // Accessible from anywhere in your project or other assemblies (DLLs).
     * internal class InternalClass { } // Accessible only within the current assembly (project). Generally applicable to helper classes.
     * private class PrivateClass { } // Accessible only within the same class or struct.
     * protected class ProtectedClass { } // Only applicable to classes within a class or methods. This modifier adopts the parent class's modifer.
     * The access modifer is not required (but standard practice to include).  When not explicit, the default modifier is internal. 
     */

    public class Syntax // Required. Every program must have a class. This declares a class named "Snytax" that is accessible from other parts of your project or even external code (Due to the public accessor).  It's the blueprint for creating objects, which are instances of the class. Some programning languages require the primary class of the file to match the file name, C# doesn't require it, but it's good practice to do so.







        /*------- SKIP DOWN 100 LINES OR SO FOR MAIN() -----*/
    {
        /*-------  Functions Used in initial Sytax -------*/

        static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", message, i);
            }
        }
        static double DoDivision(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new System.DivideByZeroException();
            }
            return num1 / num2;
        }

        /*-------  Methods 1:38 -------*/
        //access modifier (private, public, protected), return type, MethodsName (literal parameters, literal parameters)
        //{ body of the method.  If your method has a return type other than void, it must return that type before exiting the body. }

        private static void Helloworld() // This declares a private method named "HelloWorld" that doesn't return a value (void).  The static keyword means you can call it directly on the class itself without creating an object.
        {
            Console.Write("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello {0}", name);
        }

        private static double Getsum(double x = 1, double y = 1)
        {
            return x + y;
        }

        private static void Doubleit(int x, out int solution) //using out parameter, creates a variable that can be used in scope, useful for multiple returns from a function or error handling
        {
            solution = x * 2;
        }

        public static void Swap(ref int num, ref int num1)  //passing by reference, useful for large variables reducing copy overhead
        {
            int temp = num;
            num = num1;
            num1 = temp;
        }

        static double Getsomemore(params double[] numbers) //setting parameter to accept an unknown amount of input
        {
            double sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        static void Printinfo(string name, int zipcode)  //named parameters: calling with parameters out of order, and not initializing parameters
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipcode);
        }

        static double Getsum2(double x = 1, double y = 1) //overloading functions, ex 1
        {
            return x + y;
        }

        static double Getsum2(string x = "1", string y = "1") //overloading functions, ex 2
        {
            return Convert.ToDouble(x) + Convert.ToDouble(y);
        }

        static void PaintCar(CarColor color)  //function using enum
        {
            Console.WriteLine("The car was painted {0} and the code is {1}", color, (int)color);
        }

        /*-------  Enumerated Types (enums) 2:04 -------*/ //Data type as key valued pairs with limited types
        enum CarColor : byte
        {
            red = 0,
            green = 1,
            blue = 2,
            yellow = 3,
            purple = 4,
        }


        /*-------  Using Internal Classes & Structs 02:22 ------- */
        struct Rectangle
        {
            //Fields
            public double length { get; set; } = 1;
            public double width { get; set; } = 1;

            //Constructor
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            public double area()
            {
                return length * width;
            }

        }

        static void Main(string[] args) //Execution of your code begins here
        {
            /*-------  Using Internal Classes & Structs 02:22 ------- */
            Rectangle rect = new Rectangle();
            rect.length = 200;
            rect.width = 50;
            Console.WriteLine("Area of rect : {0}", rect.area());



            /*-------  Calls for Functions 1:38 -------*/
            HelloWorld();
            //Console.WriteLine("5 + 10 = {0}", GetSum(5, 10));  //Discussion about scope
            //DoubleIt(15, out int solution); 
            //Console.WriteLine("15 * 2 = {0}", solution);
            //int num = 10;
            //int num1 = 20;
            //Console.WriteLine("Before swap num : {0} and num1 : {1}", num, num1);
            //Swap(ref num, ref num1);
            //Console.WriteLine("After swap num : {0} and num1 : {1}", num, num1);
            //Console.WriteLine("GetSomeMore output: {0}", GetSomeMore(1, 3, 5));
            //PrintInfo(zipCode: 02854, name: "Briant Becote");
            //Console.WriteLine("Output GetSum2 with doubles : {0}", GetSum2(1, 2));
            //Console.WriteLine("Output GetSum2 with strings : {0}", GetSum2("1", "2"));

            /*-------  Calls for Enums 2:04 -------*/
            //CarColor car1 = CarColor.yellow;
            //paintCar(car1);

            /*-------  Console Methods Beginning of Tutorial -------*/
            //Console.WriteLine("Hello MS539 Students!");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Black;

            /*-------  User Interaction Methods 00:09 -------*/
            //Console.Write("What is your name? ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello {0}!", userName);

            /*-------  Variables & Data Types 00:11 -------*/
            //bool canIVote = true;
            //Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            //Console.WriteLine("Smallest Integer: {0}", int.MinValue);
            //Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            //Console.WriteLine("Smallest Long: {0}", long.MinValue);

            //decimal decimalPi = 3.1415926535897932384626433832M; //Note the required M for decimal data types
            //decimal decBigNum = 3.0000000000000000000000000000M;
            //Console.WriteLine("Pi + Big Num: {0}",decimalPi +  decBigNum);

            //Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);
            //Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);

            //Console.WriteLine("Biggest Double: {0}", double.MaxValue);
            //Console.WriteLine("Smallest Double: {0}", double.MinValue);

            //double doublePie = 3.14159265358979;
            //double doubleBigNum = 3.00000000000000;
            //Console.WriteLine("Double Pi + Big Num: {0}", doublePie + doubleBigNum);

            //Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            //Console.WriteLine("Smallest Float: {0}", float.MinValue);

            //float floatPi = 3.141592F; //Note the required F for float data types
            //float floatBigNum = 3.000000F;
            //Console.WriteLine("Float Pi + Big Num: {0}", floatPi + floatBigNum);

            /*-------  Conversions/Casting 00:23 -------*/
            //bool boolFromString = bool.Parse("true");  //with parse, C# attempts to determine the type, will throw an error if not coverting correctly
            //int intFromString = int.Parse("15");
            //double dblFromString = double.Parse("1.234");
            //int result;
            //if (int.TryParse("15", out result))
            //{
            //    //Allows for testing with safe fail (won't throw an exception), outputs true or false
            //}
            //string stringFromDouble = dblFromString.ToString();
            //Console.WriteLine($"Data type: {stringFromDouble.GetType()}"); //Note the $ to add a variable in the output
            //double doubleNum = 12.345;
            //Console.WriteLine($"Integer : {(int)doubleNum}"); //casting

            /*-------  Formatting Output 00:28 -------*/

            //Console.WriteLine("Currency : {0:c}", 23.455);
            //Console.WriteLine("Pad with 0s : {0:d4}", 23);
            //Console.WriteLine("3 Decimals : {0:f3}", 23.4);
            //Console.WriteLine("Comamas : {0:n4}", 2300.9);

            /*-------  Strings 00:31 ------ - */
            //string randString = "This is a string";
            //Console.WriteLine("String length is {0}", randString.Length);
            //Console.WriteLine("String contains is {0}", randString.Contains("is"));
            //Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            //Console.WriteLine("Remove string : {0}", randString.Remove(10, 6)); //ending & beginning elements (not inclusive)
            //Console.WriteLine("Insert string : {0}", randString.Insert(10, "short"));
            //Console.WriteLine("Replace string : {0}", randString.Replace("string", "sentence"));
            //Console.WriteLine("Compare string : {0}", string.Compare("A", "a"));
            //Console.WriteLine("Compare string : {0}", string.Compare("A", "a", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
            //Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
            //Console.WriteLine("Trim Whitespace : {0}", randString.Trim());
            //Console.WriteLine("To Uppercase : {0}", randString.ToUpper());
            //Console.WriteLine("To Lowercase : {0}", randString.ToLower());
            //string newString = string.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            //Console.Write(newString + "\n");
            //// /' \" \\ \t \a //Escape characters
            //Console.WriteLine(@"Exactly what I typed\n");

            /*-------  Arrays 00:44 ------ - */
            //int[] favNums = new int[3];
            //favNums[0] = 27;
            //Console.WriteLine("favNum 0 : {0}", favNums[0]);
            //string[] customerNames = { "Bob", "Sally", "Sue" };
            //var employees = new[] { "Mike", "Paul", "Rick" }; 
            //object[] randomArray = { "Paul", 45, 1.254}; //create an array with different data types
            //Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            //Console.WriteLine("Array Size : {0}", randomArray.Length);
            //for (int i = 0; i < randomArray.Length; i++)  //for loop with array
            //{
            //    Console.WriteLine("Array Position : {0}, Value : {1}", i, randomArray[i]);
            //}

            //string[,] custNames = new string[2, 2] { { "Bob", "Billy"}, {"Sally", "Samantha" }}; //Multidimensional Array creates columns (first input) and rows (second input)
            //Console.WriteLine("MD Value : {0}", custNames.GetValue(0,1));

            //for (int i = 0; i < custNames.GetLength(0); i++)
            //{
            //    for (int j = 0; j < custNames.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Array Values : {0}", custNames[i, j]);
            //    }
            //}

            //int[] randNum = { 1, 4, 9, 2 };
            //PrintArray(randNum, "ForEach");
            //Console.WriteLine("----------------------------");

            //Array.Sort(randNum);
            //Array.Reverse(randNum);
            //Console.WriteLine("1 at index : {0}", Array.IndexOf(randNum, 1));
            //randNum.SetValue(0, 1);
            //int[] srcArray = { 1, 2, 3, 4, };
            //int[] destArray = { 5, 6, 7, 8 };
            //int startIndex = 0;
            //int length = 2;
            ////Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            //Array.Copy(srcArray, startIndex, destArray, 0, length);
            //PrintArray(destArray, "Copy");

            //Array anotherArray = Array.CreateInstance(typeof(int), 10);
            //srcArray.CopyTo(anotherArray, 0);
            //PrintArray(srcArray, "Another Copy");

            //int[] numArray = { 1, 11, 22 };
            //Console.WriteLine("Values > 10 : {0}", Array.Find(numArray, num => num > 10));

            /*-------  Operators 01:07 ------ - */
            //Relational Operators : > < >= <= == !=
            //Logical Operators : && || !
            //int age = 17;
            //if (age > 5 && age <= 7)
            //{
            //    Console.WriteLine("Go to elementary school");
            //}
            //if (age < 13)
            //{
            //    Console.WriteLine("Go to middle school");
            //}
            //if (age >= 13 && age < 19)
            //{
            //    Console.WriteLine("Go to high school");
            //}
            //else
            //{
            //    Console.WriteLine("Go to college");
            //}

            //if (age < 16 || age > 65)
            //{
            //    Console.WriteLine("You don't need to work");
            //}

            //Console.WriteLine("!True or False : {0}", !true);

            //bool canDrive = age >= 16 ? true : false; //ternary operator

            //switch (age) //switch will test each case to run the matching output
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Go to day care");
            //        break;
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Go to preschool");
            //        break;
            //    case 5:
            //        Console.WriteLine("Go to kindergarten");
            //        break;
            //    default:
            //        Console.WriteLine("Stay Home");
            //        goto OtherSchool;
            //        break;
            //}
            //OtherSchool:
            //    Console.WriteLine("Homeschool");

            ////String comparison.  Note that == checks if the string is the same object in memory, while .Equals confirms the values are the same.
            //string name1 = "Briant";
            //string name2 = "Briant";
            //if (name1.Equals(name2, StringComparison.Ordinal))
            //{
            //    Console.WriteLine("Names are equal");
            //}

            /*-------  More Loops Do & Do While 01:18 ------- */
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0) //Modulo operator, divides and takes the remainder, often used to check for even (as show) or wrapping (ie, 12 hour format 13%12 = 1)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if (i == 9) break;
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11); //max number not inclusive
            //int guessedNumber = 0;
            //do
            //{
            //    Console.WriteLine("Pick a random number 1-10 :");
            //    guessedNumber = Convert.ToInt32(Console.ReadLine()); //Readline input is always a string. Converts it to an interger
            //    Console.WriteLine("Secret number is : {0}", secretNumber);
            //} while (secretNumber != guessedNumber);
            //Console.WriteLine("You got it!");

            /*-------  Exception Handling 01:25 ------- */
            //double num1 = 5;
            //double num2 = 0;
            //try
            //{
            //    Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("No No No division by zero!");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("A random exception was thrown");
            //    Console.WriteLine(ex.ToString());
            //}

            //finally  //The finally block is part of the try-catch-finally construct.  Its primary role is to ensure a block of code always executes, regardless of whether an exception occurred in the try block. Usefull for forcing log keeping or closing resources (files, network connections, database etc)
            //{
            //    Console.WriteLine("Clearning up");
            //}

            /*-------  String Builders 01:30 ------- */
            //StringBuilder sb = new StringBuilder("Random text"); //default sb size is 16
            //StringBuilder sb1 = new StringBuilder("More random text", 256); //forcing size to 256
            //Console.WriteLine("Capacity sb1 : {0}", sb1.Capacity);
            //Console.WriteLine("Length sb1 : {0}", sb1.Length);
            //sb1.AppendLine(" added even more text!");
            //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            //string newString = sb.ToString();
            //sb1.AppendFormat(enUS, newString);
            //Console.WriteLine(sb1.ToString());
            //sb1.Replace("text", "characters");
            //Console.WriteLine(sb1.ToString());
            //sb1.Clear();
            //sb1.Append("Random Text");
            //Console.WriteLine(sb1.Equals(sb));
            //sb1.Insert(11, " Mo text");
            //Console.WriteLine(sb1.ToString());
            //sb1.Remove(11, 8);
            //Console.WriteLine(sb1.ToString());

            /*-------  Date Times 01:59 ------- */
            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine("Day of the week is : {0}", dateTime.DayOfWeek);
            //dateTime = dateTime.AddDays(4);
            //dateTime = dateTime.AddMonths(1);
            //dateTime = dateTime.AddYears(10);
            //Console.WriteLine("Updated date is : {0}", dateTime.ToString());
            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            //Console.WriteLine("New Lunchtime is : {0}", lunchTime.ToString());





        }
    }
}



