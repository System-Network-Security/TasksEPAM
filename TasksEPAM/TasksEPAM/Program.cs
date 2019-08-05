using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Flag:
            try
            {
                string command;
                do
                {
                    Console.WriteLine("\n\r");
                    Console.ForegroundColor = ConsoleColor.Red;
                    command = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\r");
                    if (command == "help" || command == "1" || command == "2" || command == "3" || command == "4" || command == "5" || command == "exit")
                    {
                        switch (command)
                        {
                            case "help":
                                Console.WriteLine("Команды:" + "\n\r\n\r" +
                                    "help - Помощь по командам" + "\n\r" +
                                    "1 - Первое задание" + "\n\r" +
                                    "2 - Второе задание" + "\n\r" +
                                    "3 - Третье задание" + "\n\r" +
                                    "4 - Четвёртое задание" + "\n\r" +
                                    "5 - Пятое задание" + "\n\r" +
                                    "exit - Выход из консоли");
                                break;
                            case "1":
                                Task1.Start();
                                break;
                            case "2":
                                Task2.Start();
                                break;
                            case "3":
                                Task3.Start();
                                break;
                            case "4":
                                Task4.Start();
                                break;
                            case "5":
                                Task5.Start();
                                break;
                            default:
                                Console.WriteLine("Error 0x00000000 : Неизвестная команда");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error 0x00000000 : Неизвестная команда");
                    }
                }
                while (!command.StartsWith("exit"));
            }
            catch (Exception Ex)
            {
                string Error = null; long ErrorNumber = Ex.HResult + 2147483648;
                string ErrorString = Convert.ToString(ErrorNumber, 16).ToUpper();
                int Size = 8 - ErrorString.Length;
                for (int i = 0; i < 8; i++)
                {
                    if (i < Size)
                    {
                        Error += Encoding.UTF8.GetString((new byte[] { 48 }));
                    }
                    else
                    {
                        for (int j = 0; j < ErrorString.Length; j++)
                        {
                            if (i - Size == j)
                            {
                                Error += ErrorString[j];
                            }
                        }
                    }
                }
                Console.WriteLine("Error 0x" + Error + " : " + Ex.Message);
                goto Flag;
            }
            Console.ReadKey();
        }
    }
}
