using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace number2
{
    internal class Program
    {
        static int[] RandomArray(uint UserQua, int RandomUserMinValue, int RandomUserMaxValue)
        {
            int[] RandomArrey = new int[UserQua];
            Random random = new Random();
            for (int i = 0; i < RandomArrey.Length; i++)
            {
                RandomArrey[i] = random.Next(RandomUserMinValue, RandomUserMaxValue);
            }
            return RandomArrey;
        }
        static int[] UserArray(int UserArrayValue)
        {
            int[] UserArray = new int[UserArrayValue];

            for (int i = 0; i < UserArray.Length; i++)
            {
                UserArray[i] = int.Parse(Console.ReadLine());
            }
            return UserArray;
        }

        static int SearchIndexInArray(int[] array, int SearchIndexValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == SearchIndexValue)
                {
                    return i;
                }
     
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 ==== Заполнение массива случайными числами и нахождение индекса Вашего элемента.");
            Console.WriteLine("2 ==== Заполнение массива Вашими числами и нахождение индекса Вашего элемента.");
            uint UserChoice = uint.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:

                    Console.WriteLine("Количество элементов в рандом массиве == ?");
                    uint QuaElem = uint.Parse(Console.ReadLine());
                    Console.WriteLine("Минимальное значение в рандом массиве == ?");
                    int Min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Максимальное значение в рандом массиве == ?");
                    int Max = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ваше число, индекс которого вы хотите найти == ?");
                    int UserValue = int.Parse(Console.ReadLine()); 
                    Console.WriteLine("Индекс в массиве Вашего числа == " + SearchIndexInArray(RandomArray(QuaElem, Min, Max), UserValue));
                    break;

                case 2:
                    Console.WriteLine("Количество элементов в Вашем массиве == ?");
                    int UserArrayValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ваше число, индекс которого вы хотите найти == ?");
                    int UserValue2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите элементы массива ==");
                    Console.WriteLine("Индекс в массиве Вашего числа == " + SearchIndexInArray(UserArray(UserArrayValue), UserValue2));
                    break;
                default:
                    Console.WriteLine("Other choice no the here:(");
                    break;
            }
        }
    }
}
