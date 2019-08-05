using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    static internal class Task3
    {
        static internal void Start()
        {
            Console.WriteLine("Исходная строка: ");
            string Command = Console.ReadLine();
            Console.WriteLine();
            List<string> list = new List<string>();
            Console.WriteLine("Уникальные слова в предложинеии: ");
            string[] Arr = Command.Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries), mas;
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (i != j && Arr[i] == Arr[j])
                    {
                        list.Add(Arr[i]);
                    }
                }
            }

            mas = list.ToArray();

            for (int i = 0; i < mas.Length; i++)
            {
                Command = Command.Replace(mas[i], string.Empty);
            }

            Console.WriteLine(Command);
        }
    }
}
