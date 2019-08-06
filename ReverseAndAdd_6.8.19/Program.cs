using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseAndAdd_6._8._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumTotal;
            int sumTotalReverse;

            Console.WriteLine("Enter a number: ");
            var inputNumber = int.Parse(Console.ReadLine());

            do
            {
                var reversedNumber = ReverseNumber(inputNumber);
                Console.WriteLine($"Reversed Number: {reversedNumber}");
                sumTotal = inputNumber + reversedNumber;
                sumTotalReverse = ReverseNumber(sumTotal);

                inputNumber = sumTotal;

                Console.WriteLine($"{inputNumber} + {reversedNumber} = {sumTotal}");
            }
            while (sumTotal != sumTotalReverse);

            Console.ReadLine();
        }

        public static int ReverseNumber(int number)
        {
            var reverse = 0;
            while (number != 0)
            {
                var remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            return reverse;
        }
    }
}
