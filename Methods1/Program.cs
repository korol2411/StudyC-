using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260624
{
    internal class Program
    {
        static void StringLine(char Sumbol, uint maxSumbols) 
        {
            
            for (int i = 0; i < maxSumbols; i++)
            {
                Console.Write(Sumbol);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            char Sumbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Введите количество символов");
            uint maxSumbols = uint.Parse(Console.ReadLine());

            StringLine(Sumbol, maxSumbols);

        }
    }
}
