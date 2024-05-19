/* 
 * FileName ShapeMath.cs
 * Author: Briant Becote
 * Purpose: A continuation of C# tutorial focused on structs
 * Internal to Syntax.cs
 * Developed for UAT MS539 Syntax Examples
 * Drawn from Derek Banas C# Full Course: C# Tutorial For Beginners 
 * https://www.youtube.com/watch?v=M5ugY7fWydE&t=6345s
 * Timestamps from the YT video linked above
 * Block code using ctr K, ctr C - Unblock code using ctr k, ctr U
 * Classes and Functions 02:18 in YT video
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Syntax
{
    internal class ShapeMath
    {
        public static double getArea(string shape = "", double length = 0, double length1 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * length1;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length * length1 / 2;
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length, 2);
            }
            else return -1;
        }


    }
}
