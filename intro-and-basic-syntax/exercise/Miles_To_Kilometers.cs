using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {


	    // we read the miles
            double inputMiles = double.Parse(Console.ReadLine());

	    // converting the miles into kilometers
            double calculatedKilometers = inputMiles * 1.60934;

 	    // printing the kilometers (f2)
            Console.WriteLine($"{calculatedKilometers:f2}");
        }
    }
}