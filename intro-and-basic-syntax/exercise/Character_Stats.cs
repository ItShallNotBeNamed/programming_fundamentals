using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONFIRMED from TheChill

            string character_name = Console.ReadLine();             //reads the name,
            int health_left = int.Parse(Console.ReadLine());        //      the current health,
            int maximum_health = int.Parse(Console.ReadLine());     //      the max health,
            int energy_left = int.Parse(Console.ReadLine());        //      the current energy
            int maximum_energy = int.Parse(Console.ReadLine());     //  and the maximum energy of the character from the console

            Console.WriteLine("Name: {0}", character_name); //writes the name of the character
            Console.WriteLine("Health: |{0}{1}|", new string('|', health_left), new string('.', maximum_health - health_left)); //visualizes the health of the charecter ('|' for the current health and '.' for the missing health)
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy_left), new string('.', maximum_energy - energy_left)); //visualizes the energy of the charecter ('|' for the current energy and '.' for the missing energy)
        }
    }
}
