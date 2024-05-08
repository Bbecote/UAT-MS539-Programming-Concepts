/* 
 * FileName Animal.cs
 * Author: Briant Becote
 * Purpose: A continuation of C# tutorial focused on internal classes and functions
 * Internal to Syntax.cs
 * Developed for UAT MS539 Syntax Examples
 * Drawn from Derek Banas C# Full Course: C# Tutorial For Beginners 
 * https://www.youtube.com/watch?v=M5ugY7fWydE&t=6345s
 * Timestamps from the YT video linked above
 * Block code using ctr K, ctr C - Unblock code using ctr k, ctr U
 * Classes and Functions 02:08 in YT video
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Syntax
{
    internal class Animal
    {
        //Fields
        public string Name { get; set; } = "nameless";
        public string Sound { get; set; } = "silent";
        static int animalCount = 0;

        //Constructor
        public Animal(string name = "nameless", string sound = "silent")
        {
            Name = name;
            Sound = sound;
            animalCount++;
        }
        
        //Methods
        public static int getAnimalCount()
        {
            return animalCount;
        }
        
        private void MakeSound()
        {
            Console.WriteLine("{0} says {1}", Name, Sound);
        }
    }
}
