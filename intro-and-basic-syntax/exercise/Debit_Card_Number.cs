using System;

namespace ConsoleApp1
{
    class Debit_Card_Number
    {
        static void Main()
        {
            string debit_card_number = "";
            for (int i = 0; i < 4; i++)
            {
                string four_digits = Console.ReadLine();

                debit_card_number += new String('0', 4 - four_digits.Length) + four_digits;

                if (i < 3)
                {
                    debit_card_number += " ";
                }
            }
            
            Console.WriteLine(debit_card_number);

            //Console.ReadLine();
        }
    }
}
