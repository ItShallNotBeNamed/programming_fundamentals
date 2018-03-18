using System;
//CONFRIMED from radipleven

namespace ConsoleApp2
{
    class Beverage_Labels
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine(); //user inputs the name of the product
            int amount = int.Parse(Console.ReadLine());// user inputs the amount of the product
            int energyPer100ml = int.Parse(Console.ReadLine());//user inputs the energy per 100ml the product has
            int sugarPer100ml = int.Parse(Console.ReadLine());//user inputs the amount of sugar per 100ml the product has

            

            Console.WriteLine($"{amount}ml {product}:"); // console outputs the volume and the name of the product
            Console.WriteLine($"{((double)amount / 100.0) * energyPer100ml}kcal, {((double)amount / 100.0) * sugarPer100ml}g sugars");// console outputs the calculations that have been made

           
        }
    }
}
