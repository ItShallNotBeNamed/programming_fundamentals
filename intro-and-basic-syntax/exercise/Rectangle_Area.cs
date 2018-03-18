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
            //CONFIRMED from TheChill

            double rectangleWidth = double.Parse(Console.ReadLine()); //Read the width of the rectangle from the console
            double rectangleHeight = double.Parse(Console.ReadLine()); //Read the height of the rectangle from the console

            Console.WriteLine("{0:f2}", rectangleWidth * rectangleHeight); //Calculates the area of the rectangle and outputs it to the console
        }
    }
}
