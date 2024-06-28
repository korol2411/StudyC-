using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UseRef
{
    internal class Program
    {   
        static void DeleteElementInTheBegin(ref int[] array)
        {
            int[] delArraybeg = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                delArraybeg[i] = array[i+1];
            }
            array = delArraybeg;
        }
        static void DeleteElementInTheEnd(ref int[] array)
        {
            int[] delArrayEnd = new int[array.Length - 1];

            for (int i = 0; i < array.Length -1; i++)
            {
                delArrayEnd[i] = array[i];
            }
            array = delArrayEnd;
        }
        static void DeleteElementInTheUserIndex(ref int[] array, uint Index)
        {
            int[] delArrayUser = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                delArrayUser[i] = array[i];
            }
            delArrayUser[Index] = 0;
            array = delArrayUser;
        }
        static void AddElementInArrayInBegin(ref int[] array, int UserValue)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 1; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[0] = UserValue;
            array = newArray;
        }
        static void AddElementInArrayInTheEnd(ref int[] array, int UserValue)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = UserValue;
            array = newArray;
        }
        static void AddElementInArrayInUserIndex(ref int[] array,uint Index, int UserValue)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[Index] = UserValue;
            array = newArray;
        }
        static void ResizeUp(ref int[] array, uint QuaArray)
        {
            int[] Array2 = new int[QuaArray];
            for (int i = 0; i < array.Length; i++)
            {
                Array2[i] = array[i];
            }
            array = Array2;
        }

        static void ResizeDown(ref int[] array, uint QuaArray)
        {
            int[] DownArray = new int[QuaArray];
            for (int i = 0; i < DownArray.Length; i++)
            {
                DownArray[i] = array[i];
            }
            array = DownArray;
        }

        static void GetUserArray(ref int[] array, uint UserArrayElements)
        {
            int[] UserArray = new int[UserArrayElements];
            Console.WriteLine("Введите элементы массиве ==");
            for (int i = 0;i < UserArrayElements;i++)
            {
                UserArray[i] = int.Parse(Console.ReadLine());
            }
            array = UserArray;
        }
        static void ShowArray(int[] array)
        {
            Console.WriteLine("Элементы массива");
            for (int i = 0;i < array.Length;i++) 
            { 
                Console.WriteLine(i + " " + array[i]);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество элементов в вашем массиве == ");
            uint UserArrayElments = uint.Parse(Console.ReadLine());
            int[] UserArray = new int[UserArrayElments];
            Console.WriteLine();
            GetUserArray(ref UserArray, UserArrayElments);
            Console.WriteLine();
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("В массиве столько элементов == "+ " " + UserArray.Length);
            Console.WriteLine("До скольки мы хотим увеличить массив == ?");
            uint QuaArray = uint.Parse(Console.ReadLine());
            ResizeUp(ref UserArray, QuaArray);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("До скольки мы хотим уменьшить массив == ?");
            uint QuaArrayDown = uint.Parse(Console.ReadLine());
            ResizeDown(ref UserArray, QuaArrayDown);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("Значение которое вы хотите поместить в начало массива == ");
            int UserValue = int.Parse(Console.ReadLine());
            AddElementInArrayInBegin(ref UserArray, UserValue);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("Значение которое вы хотите поместить в конец массива == ");
            int UserValue2 = int.Parse(Console.ReadLine());
            AddElementInArrayInTheEnd(ref UserArray, UserValue2);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("Индекс, куда хочешь закинуть число == ");
            uint Index = uint.Parse(Console.ReadLine());
            Console.WriteLine("Само число == ");
            int UserValue3 = int.Parse(Console.ReadLine());
            AddElementInArrayInUserIndex(ref UserArray, Index, UserValue3);
            ShowArray(UserArray);

            Console.WriteLine();
            
            Console.WriteLine("Удаление перого элемента в массиве");
            Console.WriteLine();
            DeleteElementInTheBegin(ref UserArray);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("Удаление последнего элемента в массиве");
            Console.WriteLine();
            DeleteElementInTheEnd(ref UserArray);
            ShowArray(UserArray);

            Console.WriteLine();

            Console.WriteLine("Введите индекс числа в массиве, которое будет удалено");
            uint UserIndex = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            DeleteElementInTheUserIndex(ref UserArray, UserIndex);
            ShowArray(UserArray);
        }
    }
}
