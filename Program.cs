using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk2_ex2_rework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: "); // ask user the length of the rectangle

            double length = Convert.ToDouble(Console.ReadLine()); // saves the answer as a double variable
            Console.WriteLine("Enter the width of the rectangle : "); //ask the user the width of the rectangle
            double width = Convert.ToDouble(Console.ReadLine()); // saves the answer as a double variable

            double area = length * width;  //calculation of the area 
            double perimeter = 2 * (length + width); //calculation of the perimeter
            Console.WriteLine("The area of the rectangle is: " + area); // prints the area of the rectangle
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter); // prints the perimeter of the rectangle
        }
    }
}
