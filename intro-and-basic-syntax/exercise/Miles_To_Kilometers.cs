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



            double inputMiles = double.Parse(Console.ReadLine());


            double calculatedKilometers = inputMiles * 1.60934;


            Console.WriteLine($"{calculatedKilometers:f2}");
        }
    }
}