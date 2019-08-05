using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    static internal class Task2
    {
        static internal void Start()
        {
            int[] Mas = Task1.Start();
            Console.WriteLine();

            Console.WriteLine("Значение для поиска: ");
            string Value = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Значение найденное в массиве: ");
            for (int j = 0; j < Mas.Length; j++)
            {
                if (Convert.ToInt32(Value) == Mas[j])
                {
                    Console.Write("Array[{0}] = {1}\r\n", j, Mas[j]);
                }
            }
        }
    }
}
