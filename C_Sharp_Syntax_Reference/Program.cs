/*Multi-line comment
 * Author: Dr. Briant Becote
 * Date: 5/28/24
 * Program: C_Sharp_Syntax_Reference
 * Prupose: An overview of C# Syntax across variables, data structures, literals and operators.
 * Developed for UAT MS539 Syntax Examples
 * Guided by the C# Programming Yellow Book by Rob Miles: https://static1.squarespace.com/static/5019271be4b0807297e8f404/t/5df9306ec60881645ea57ced/1576611956760/CSharp+Book+2019+Refresh.pdf
 * .Net Design Guidelines including naming conventions: https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-1.1/czefa0ke(v=vs.71)?redirectedfrom=MSDN
 * Guidance on Variables: https://en.wikibooks.org/wiki/C_Sharp_Programming/Variables
 */

using System;
using System.Collections.Immutable;
using System.Threading.Tasks.Dataflow; // Not required but used in almost all C#/.Net programs. This line makes all the types (classes, etc.) within the core .NET "System" namespace available for direct use in your code. It's like importing a toolbox full of the common features you'll need. You can add additional "using" statements to import classes to use in your code.

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ConsoleApp // Not required. A namespace is like a container or folder that helps organize your code.  It groups related classes, types, and other code elements, preventing naming conflicts and making your code more manageable.
{
    //Standard Class Structure: access_modifer class ClassName { body_of_the_class }

    /* Access Modifiers - note the lower case access modifiers, lowercase "class", uppercase ClassName convention. Used on classes, methods, and fields.
    * These are the most typical ones:
    * public class PublicClass { }  // Accessible from anywhere in your project or other assemblies (DLLs).
    * internal class InternalClass { } // Accessible only within the current assembly (project). Generally applicable to helper classes.
    * private class PrivateClass { } // Accessible only within the same class or struct.
    * protected class ProtectedClass { } // Only applicable to classes within a class or methods. This modifier adopts the parent class's modifier.
    * The access modifier is not required (but standard practice to include).  When not explicit, the default modifier is internal. 
    */

    public class Syntax // Required when not running Top-Level Statements in a single .cs file (available since C# 9). This declares a class named "Syntax" that is accessible from other parts of your project or even external code (Due to the public accessor).  It's the blueprint for creating objects, which are instances of the class. Some programming languages require the primary class of the file to match the file name, C# doesn't require it, but it's good practice to do so.

    {
        //----- CLASS PROPERTIES & FIELDS -----//
        /* These are variables that have a class level scope.  More specifics on variables within the code.
         * Fields: Variables that are accessed via the Object.variableName notation.  Are typically private. Declared with C# syntax: private int FieldExample = 0; A default of 0 is provided, and the exact amount can be set in the constructor
         * Parameters: Variables with setters and getters that control access for controlled use and improved abstraction. Often declared with the C# syntax: public int ParameterExample { get; set; } = 0; but these get/set methods can be expanded to provide additional logic/control. A default of 0 is provided, and the exact amount can be set in the constructor
         * Instance variable - a variable that is distinct with each object created from that class.
         * Static variable - declared with the static keyword, is a universal variable that is shared with all objects of the class, accessed directly through the class (rather than the object).
        */

        //----- CLASS CONSTRUCTORS -----//
        /* A method that defines the creation (initialization) of an object for that class.  Not required (C# will implicitly set class fields to their defaults) but appropriate when you want to create an Object with specific field values.
         */


        //----- CLASS METHODS -----//
        //Method Structure: access_modifier return_type MethodsName (literal parameters, literal parameters) { body_of_the_method If your method has a return type other than void, it must return that type before exiting the body. }

        //----- Console Interaction -----//      
        public void HelloWorld()
        {
            //Basic Variable Declaration Structure: type variableName = the_value
            Console.WriteLine("Hello user, please enter your name."); 
            string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name); //String Concatonation
            Console.WriteLine($"Hello {name}"); //String Interpolation - recommended for performanace, readability, and maintainability
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }

        static void Main() // Required to let our program know where to start executing code.  When you see "string[] args" as a parameter in your Main method, that's to capture command line arguments.  Standard, but not required.
        {
            //Object Initialization Structure: Class Name_Of_Object = new Class(any_applicable_parameters);
            Syntax SyntaxObject = new Syntax();

            //Method Run on an Object Structure: ObjectName.Method( applicable_parameters);
            //SyntaxObject.HelloWorld();
            int additionOutput = SyntaxObject.Addition(2, 2);
            Console.WriteLine($"Our Addition Method Produced: {additionOutput}");
            //Console.WriteLine(SyntaxObject.Addition(2, 2));  //Altneratively we can run the Addition method within the WriteLine method, but that approach can be difficult to read/understand

            //----- Basic Data Types (working with literals) -----//
            bool trueorFalse = true; //Can set to true or false.
            Console.WriteLine($"The TrueofFalse Output: {trueorFalse}");

            //----- Some Number Types -----//
            Console.WriteLine($"The size of an int: {sizeof(int)} bytes");
            Console.WriteLine($"The biggest integer: {int.MaxValue}");
            Console.WriteLine($"The smallest integer: {int.MinValue}");
            Console.WriteLine($"The size of an long: {sizeof(long)} bytes");
            Console.WriteLine($"The biggest long: {long.MaxValue}");
            Console.WriteLine($"The smallest long: {long.MinValue}");
            Console.WriteLine($"The size of an float: {sizeof(float)} bytes");
            Console.WriteLine($"The biggest float: {float.MaxValue}");
            Console.WriteLine($"The smallest float: {float.MinValue}");
            Console.WriteLine($"The size of an double: {sizeof(double)} bytes");
            Console.WriteLine($"The biggest double: {double.MaxValue}");
            Console.WriteLine($"The smallest double: {double.MinValue}");
            Console.WriteLine($"The size of an decimal: {sizeof(decimal)} bytes"); //Although a large data type, provides best precision for decimal numbers
            Console.WriteLine($"The biggest decimal: {decimal.MaxValue}");
            Console.WriteLine($"The smallest decimal: {decimal.MinValue}");


            int intExample10 = 10;
            int longExample = 15;
            decimal decimalExample = 3.1415926535897932384626433832M;
            double doubleExample = 3.14159265358979;
            float floatExample = 3.141592F;

            //----- Formatting Outputs -----//
            Console.WriteLine($"Currency: {23.445:C}");
            Console.WriteLine($"Pad out to 4 places: {23:D4}");
            Console.WriteLine($"3 Decimals: {23.4:F3}");
            Console.WriteLine($"Commas: {2300.9:N}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"{now:yyyy-MM-dd HH:mm:ss}");    // Output: 2024-05-28 21:25:13 
            Console.WriteLine($"{now:dddd, MMMM d, yyyy}"); // Output: Tuesday, May 28, 2024

            //----- Random Numbers -----//
            Random rand = new Random();
            int newRandomDice = rand.Next(2, 13); //Why is this not right for two dice?


            //----- Char and String -----//

            //A single character stored as Unicode (2 bytes of memory).  Uses single quotes
            char charExample = '$';
            string stringExample = ""; //An empty string

            //----- Relational Operators -----//
            //Test Equals and Not Equals
            bool test = "a" == "b"; //false
            test = "a" == "a"; //true
            test = 1 == 0; //false
            test = false == false; //true
            test = "a" != "a"; // false

            test = 3 > 5; //Great than
            test = 3 < 5; //Less than
            test = 3 >= 5; //Greater than or equals
            test = 3 <= 5; //Less than or equals

            //----- Logical AND, OR and Exclusive OR -----//
            test = 1 == 1 && 5 == 5; //true
            test = 1 == 1 && 5 == 0; //false
            test = 1 == 1 || 5 == 0; //true
            test = 1 == 1 ^ 5 == 5; //false

            //----- Post and Preix Inc/Decrements -----//
            intExample10 = 10;
            Console.WriteLine($"++ 10: {++intExample10}"); //Prefix Increment
            intExample10 = 10;
            Console.WriteLine($"10 ++ : {intExample10++}"); //PostFix Increment
            intExample10 = 10;
            Console.WriteLine($"-- 10: {--intExample10}"); //Prefix Increment
            intExample10 = 10;
            Console.WriteLine($"10 -- : {intExample10--}"); //PostFix Increment
            intExample10 = 10;

            //----- Common Binary Operators -----//
            intExample10 = 10;
            Console.WriteLine($"10 += 10: {intExample10 += intExample10}"); //same as intExample = intExample + intExample
            intExample10 = 10;
            Console.WriteLine($"10 -= 10: {intExample10 -= intExample10}"); //same as intExample = intExample - intExample
            intExample10 = 10;
            int intExample5 = 5;
            //Modulous
            Console.WriteLine($"5 %= 10: {intExample5 %= intExample10}"); //returns the remainder of division as a whole number. 
            int intExample100 = 100;
            int intExample2 = 2;
            Console.WriteLine($"100 %= 2: {intExample100 %= intExample2}"); //Most often used to determine if a number is even or odd given a variable input. If a zero returns, the number is even.


            //----- Strings and Numerics -----//
            stringExample = "New String";

            //----- Casting from String -----//
            bool boolFromString = bool.Parse("false");
            Console.WriteLine($"Casting from string to bool: {boolFromString}");
            int intFromString = int.Parse("15");
            Console.WriteLine($"Casting from string to int: {intFromString}");

            //----- Casting to A String -----//
            string newString = 5.ToString();
            Console.WriteLine($"Casting from int to string: {newString}");

            //----- Casting Numbers One to Another Type -----//
            int intCastExample = (int)floatExample;
            Console.WriteLine($"3.141592F cast into an int: {intCastExample}");
            float floatCastExample = (float)15;
            Console.WriteLine($"15 cast into an float: {floatCastExample}");

            //----- Conditional Statements -----//

            if (15 > 10)
            {
                //Do Stuff
            }
            else
            {
                //Do Something Else
            }

            bool boolFalse = false;
            bool boolTrue = true;

            if (boolFalse)
            {
                //Doesn't execute
            }
            else
            {
                //Executes
            }
            if (!boolFalse)
            {
                //Executes
            }

            if (boolTrue && boolFalse)
            {
                //Doesn't execute
            }

            if (intExample10 < 10)
            {
                // Doesn't execute
            }
            else if (intExample10 > 10)
            {
                // Doesn't Execute
            }
            else
            {
                //Equals 10 - execute this.
            }

            //Switch Statements
            switch (intExample10)
            {
                case < 10:
                    //Do stuff
                    break;
                case 10:
                    //Do stuff
                    break;
                case > 10:
                    break;
                default: //Do stuff
            }

            //Switch Expressions (since C# 8)
            int switchResult = 2 switch
            {
                1 => 7,
                2 => 8,  //this will be set to the variable switchResult
                3 => 9,
                4 => 10,
                _ => 11,
            };

            //----- String Stuff -----//
            //Immutability: C# strings are immutable, meaning their values cannot be changed after creation. String manipulation operations always return new string objects.

            string hitsFrom80s1 = "Take On Me";
            string hitsFrom80s2 = "Every Breath You Take";
            Console.WriteLine("My Favorite 80's songs are {0} and {1}", hitsFrom80s1, hitsFrom80s2);
            //Alignment
            Console.WriteLine($"{"Left",-10}{"Center",0}{"Right",10}");
            //Contatonation
            Console.WriteLine(hitsFrom80s1 + " heart " + hitsFrom80s2);
            //Searching - other options include IndexOf, StartsWith, EndsWith
            bool containsSample = hitsFrom80s1.Contains("take");  //False case sensitive
            bool containsSample2 = hitsFrom80s1.ToLower().Contains("take");
            Console.WriteLine($"Boolean test of string.Contains: {containsSample}");
            Console.WriteLine($"Boolean test of string.Contains with ToLower: {containsSample2}");
            //Grab a substring
            string notARealSong = hitsFrom80s1.Substring(0, 7) + " " + hitsFrom80s2.Substring(hitsFrom80s2.Length - 4);
            Console.WriteLine($"Concatonate two substrings: {notARealSong}");
            string isARealSong = hitsFrom80s1.Replace("Take", "Living").Replace("Me", "A Prayer");
            Console.WriteLine($"Two Replaces on a single string: {isARealSong}");
            Console.WriteLine($"String Length using text.Length(): {hitsFrom80s1.Length}");
            Console.WriteLine($"To Uppercase: {hitsFrom80s1.ToUpper()}");
            Console.WriteLine($"To Lowercase: {hitsFrom80s1.ToLower()}");
            //Verbatim - allows you to print out exactly what's in the quotation marks
            Console.WriteLine(@"Using Verbatim, these are escape characters:  //// /' \"" \\ \t \a");

            //----- Loops -----//
            //For Loops - 3 parts separated by semicolons: initialization expression, test expression, and update expression
            for (int count = 0; count < 10; count++)
            {
                Console.Write($"I'm on count: {count}, ");
            }

            Console.WriteLine("");

            /*
            while (!true) // Runs indefinitely, often used for networking, logging, background services
            {
                //Do stuff
            }
            */

            int x = 10;
            do
            {
                //Do stuff
                x--;
            } while (x != 0);


            Console.WriteLine("//----- Data Structures (Arrays) -----//");
            //----- Data Structures -----//

            //Arrays
            //Array Declaration Structure: type[] name = new int[size_of_array_in_int].  Arrays are a fixed length data structure, referenced by the index starting from 0.
            int[] newArray = new int[10]; //all indexes are set to 0
            int[] newArray1 = { 10, 100, 1000 }; //length of 3, index 0 = 1, index 1 = 100, index 2 = 1000
            Console.WriteLine($"As a reference type, printing the array directly will print it's type: {newArray1}"); //

            //Accessing Values: type variable = arrayName[index_of_desired_value]
            int intFromArray = newArray[1];
            Console.WriteLine($"Accessing value at index 2 of newArray1: {newArray1[2]}");

            //Join Strings from an array
            string[] songs = { hitsFrom80s1, hitsFrom80s2, isARealSong };
            Console.WriteLine($"My favorite 80's songs: {string.Join(", ", songs)}");

            //For Loop with arrays
            for (int i = 0; i < songs.Length; i++)
            {
                Console.WriteLine($"My top 3 favorite 80's songs: {i}:{songs[i]}");
            }

            //Foreach Loop
            foreach (int num in newArray1)
            {
                Console.WriteLine(num);
            }

            //Changing the value
            newArray1[0] = 1;

            //Searching the array
            int index = Array.IndexOf(newArray1, 100);
            Console.WriteLine($"The index of newArray1 for 100 is: {index}");
            bool containsValue = newArray.Contains(100);
            Console.WriteLine($"My newArray1 contains 1000: {containsValue}");

            //Sorting (retuns a new array
            int[] unsortedArray = { 5, 3, 4, 2, 1 };
            Array.Sort(unsortedArray);
            Console.WriteLine($"Now my unsorted array is sorted: {string.Join(", ", unsortedArray)}");

            /* Reference vs Value Types
            * Reference Type: Indirect Storage - Reference types store a reference (memory address) to the actual data. When you assign a reference type variable to another, both variables point to the same object.
            * Reference Types include: Classes, Objects, Arrays (including those containing value type variables), Strings
            * 
            * Value Type: Direct Storage - directly store their data in memory. When you assign a value type variable to another, a copy of the value is created and placed into memory at the new variable's memory location.
            * Value Types include: Numeric Types (int, long, float, double, decimal), Boolean, Character, Structs (a lightweight object-like data structure), Enums (another object-like data structure).
            */

            Console.WriteLine(@"/--------Reference & Value types example--------\");
            //Reference type example
            int int1 = 5;
            int int2 = int1;
            Console.WriteLine($"int2 copied from int1: {int2}");
            int2 = 7;
            Console.WriteLine("Value Types Ouptut");
            Console.WriteLine($"int1: {int1}");
            Console.WriteLine($"int2: {int2}");

            Console.WriteLine("Reference Types Ouptut");
            int[] newArray2 = { 1, 2, 3 };
            int[] newArray3 = newArray2;
            newArray3[1] = 10;
            Console.WriteLine($"Values for newArray2: {string.Join(", ", newArray2)}");
            Console.WriteLine($"Values for newArray3: {string.Join(", ", newArray3)}");

            Console.WriteLine("Strings:A Reference Type that acts like a Value Type");
            string string1 = "Hello World!";
            string string2 = string1;
            Console.WriteLine($"string1 copied from string2: {string2}");
            string2 = "It's a Cruel Cruel World";
            Console.WriteLine($"string1: {string1}");
            Console.WriteLine($"string2: {string2}");

        

















        }
    }
}
