//CONFIRMED from stoian515
using System;

namespace ConsoleApp1
{
    class Debit_Card_Number
    {
        static void Main()
        {
	    // create empty string
            string debitNumber = "";
            for (int i = 0; i < 4; i++)
            {
		// for each i we read 4 digits
                string newDigits = Console.ReadLine();
		// adding the digits to the string
                debitNumber += new String('0', 4 - newDigits.Length) + newDigits;
		// addin the last digits
                if (i < 3)
                {
                    debitNumber += " ";
                }
            }
	    // print the result            
            Console.WriteLine(debitNumber);
        }
    }
}
