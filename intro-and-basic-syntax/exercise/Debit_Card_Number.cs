using System;

namespace ConsoleApp1
{
    class Debit_Card_Number
    {
        static void Main()
        {
	    // create empty string
            string debit_card_number = "";
            for (int i = 0; i < 4; i++)
            {
		// for each i we read 4 digits
                string four_digits = Console.ReadLine();
		// adding the digits to the string
                debit_card_number += new String('0', 4 - four_digits.Length) + four_digits;
		// addin the last digits
                if (i < 3)
                {
                    debit_card_number += " ";
                }
            }
	    // print the result            
            Console.WriteLine(debit_card_number);

            //Console.ReadLine();
        }
    }
}
