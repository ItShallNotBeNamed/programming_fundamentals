using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()); //Read the width of the rectangle from the console
            double height = double.Parse(Console.ReadLine()); //Read the height of the rectangle from the console

            Console.WriteLine("{0:f2}", width * height); //Calculates the area of the rectangle and outputs it to the console
        }
    }
}
