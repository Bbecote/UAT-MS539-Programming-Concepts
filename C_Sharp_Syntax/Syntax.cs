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

using System; //Imports classes and functions from the System Class

/*-------      -------*/
namespace ConsoleApp1 //Not explicitly required - Organizes your code.
{
    public class Syntax //Primary class must match the file name
    {
        /*-------  Functions  -------*/

        static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", message, i);
            }
        }



        static void Main(string[] args) //Execution of your code begins here
        {
            /*-------  Console Methods -------*/
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
            int[] favNums = new int[3];
            favNums[0] = 27;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customerNames = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" }; 
            object[] randomArray = { "Paul", 45, 1.254}; //create an array with different data types
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);
            for (int i = 0; i < randomArray.Length; i++)  //for loop with array
            {
                Console.WriteLine("Array Position : {0}, Value : {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2] { { "Bob", "Billy"}, {"Sally", "Samantha" }}; //Multidimensional Array creates columns (first input) and rows (second input)
            Console.WriteLine("MD Value : {0}", custNames.GetValue(0,1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine("Array Values : {0}", custNames[i, j]);
                }
            }

            int[] randNum = { 1, 4, 9, 2 };
            PrintArray(randNum, "ForEach");
            Console.WriteLine("----------------------------");

            Array.Sort(randNum);
            Array.Reverse(randNum);
            Console.WriteLine("1 at index : {0}", Array.IndexOf(randNum, 1));
            randNum.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3, 4, };
            int[] destArray = { 5, 6, 7, 8 };
            int startIndex = 0;
            int length = 2;
            //Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            Array.Copy(srcArray, startIndex, destArray, 0, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 0);
            PrintArray(srcArray, "Another Copy");

            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("Values > 10 : {0}", Array.Find(numArray, num => num > 10));




        }
    }
}



