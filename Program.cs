using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_OF_THE_DİGİTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TOTAL OF DIGITS OF NUMBER ENTERED FROM KEYBOARD

            Console.Write("Enter a Number (Max 3 digits) : ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = ((number % 100) - ones) / 10;
            hundreds = number / 100;

            Console.WriteLine("Ones: " + ones);
            Console.WriteLine("Tens: " + tens);
            Console.WriteLine("Hundreds: " + hundreds);

            sum = hundreds + tens + ones;
            Console.WriteLine("-------------");
            Console.WriteLine("Sum: " + sum);
            #endregion
        }
    }
}
