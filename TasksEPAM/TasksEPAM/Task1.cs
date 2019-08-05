using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    static internal class Task1
    {
        static internal int[] Start()
        {
            Console.WriteLine("Исходный массив: ");
            string Command = Console.ReadLine();
            string[] Arr = Command.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] Mas = new int[Arr.Length];
            for (int i = 0; i < Arr.Length; i++)
            {
                try
                {
                    Mas[i] = Convert.ToInt32(Arr[i]);
                }
                catch (FormatException Ex)
                {
                    Console.WriteLine("Error: " + Ex.Message + "\r\n" + "Элементы массива целочисленные значения");
                    break;
                }
            }

            Mas = SortingMethod.BubbleSort(Mas);
            Console.WriteLine();

            Console.WriteLine("Отсортированный массив: ");
            for (int j = 0; j < Arr.Length; j++)
            {
                Console.Write("{0} ", Mas[j]);
            }
            Console.WriteLine();
            return Mas;
        }
    }
}
