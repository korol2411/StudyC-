using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRecursia
{
    internal class Program
    {
        static void ConsoleWriteArray(int[] array,int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                ConsoleWriteArray(array, i + 1);
            }

        }
        static void ArraySumAll(int[] array, ref int sum, int i = 0)
        {
            if (i < array.Length)
            {
                sum += array[i];
                ArraySumAll(array, ref sum, i + 1);
            }
        }
        static int SumUserNumber(int UserValue)
        {
            if (UserValue < 10)
                return UserValue;

            int digit = UserValue % 10;
            int nextvalue = UserValue / 10;

            return digit + SumUserNumber(nextvalue);
        }
        static void Main(string[] args)
        {
            int[] UserArray = { 2, 2, 4, 5, 7, 9};
            int sum = 0;
            Console.WriteLine("Array: ");
            ConsoleWriteArray(UserArray);
            ArraySumAll(UserArray, ref sum);
            Console.WriteLine("Sum of array elements =" + " " + sum);
            Console.WriteLine("Enter your number =");
            int UserValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of digits = " + " " + SumUserNumber(UserValue));

        }
    }
}
