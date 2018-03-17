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
            string name = Console.ReadLine();                       //reads the name,
            int currentHealth = int.Parse(Console.ReadLine());      //      the current health,
            int maxHealth = int.Parse(Console.ReadLine());          //      the max health,
            int currentEnergy = int.Parse(Console.ReadLine());      //      the current energy
            int maxEnergy = int.Parse(Console.ReadLine());          //  and the maximum energy of the character from the console

            Console.WriteLine("Name: {0}", name); //writes the name of the character
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth)); //visualizes the health of the charecter ('|' for the current health and '.' for the missing health)
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy)); //visualizes the energy of the charecter ('|' for the current energy and '.' for the missing energy)
        }
    }
}
