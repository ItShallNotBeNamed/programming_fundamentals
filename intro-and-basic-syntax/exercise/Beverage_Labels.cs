using System;

namespace ConsoleApp2
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {
            string product_name = Console.ReadLine(); //user inputs the name of the product
            int volume = int.Parse(Console.ReadLine());// user inputs the amount of the product
            int energy_per_100ml = int.Parse(Console.ReadLine());//user inputs the energy per 100ml the product has
            int sugar_per_100ml = int.Parse(Console.ReadLine());//user inputs the amount of sugar per 100ml the product has

            

            Console.WriteLine($"{volume}ml {product_name}:"); // console outputs the volume and the name of the product
            Console.WriteLine($"{((double)volume / 100.0) * energy_per_100ml}kcal, {((double)volume / 100.0) * sugar_per_100ml}g sugars");// console outputs the calculations that have been made

           
        }
    }
}
