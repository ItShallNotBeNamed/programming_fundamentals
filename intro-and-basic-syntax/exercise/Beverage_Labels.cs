using System;

namespace ConsoleApp2
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {
            string product_name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy_per_100ml = int.Parse(Console.ReadLine());
            int sugar_per_100ml = int.Parse(Console.ReadLine());

            //double total_energy = ((double)volume / 100.0) * energy_per_100ml;
            //double total_sugars = ((double)volume / 100.0) * sugar_per_100ml;

            Console.WriteLine($"{volume}ml {product_name}:");
            Console.WriteLine($"{((double)volume / 100.0) * energy_per_100ml}kcal, {((double)volume / 100.0) * sugar_per_100ml}g sugars");

            //Console.ReadLine();
        }
    }
}
