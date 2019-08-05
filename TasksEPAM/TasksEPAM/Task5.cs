using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    static internal class Task5
    {
        static internal void Start()
        {
            Console.WriteLine("Исходная строка: ");
            string Command = Console.ReadLine();
            Console.WriteLine(); bool flag = false;
            Stack<char> stack = new Stack<char>();

            foreach (Char Symbol in Command)
                switch (Symbol)
                {
                    case '}':
                        try
                        {
                            if (stack.Peek() != '{')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка '}'");
                                flag = true;
                            }
                            else
                                stack.Pop();
                        }
                        catch
                        {
                            Console.WriteLine("Лишняя закрывающая скобка '}'");
                        }
                        break;
                    case ')':
                        try
                        {
                            if (stack.Peek() != '(')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка ')'");
                                flag = true;
                            }
                            else
                                stack.Pop();
                        }
                        catch
                        {
                            Console.WriteLine("Лишняя закрывающая скобка ')'");
                        }
                        break;
                    case ']':
                        try
                        {
                            if (stack.Peek() != '[')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка ']'");
                                flag = true;
                            }
                            else
                                stack.Pop();
                        }
                        catch
                        {
                            Console.WriteLine("Лишняя закрывающая скобка ']'");
                        }
                        break;
                    case '[':
                    case '(':
                    case '{':
                        stack.Push(Symbol);
                        break;
                }
            for (int i = stack.Count; i > 0; i--)
            {
                Console.WriteLine("Не найдена закрывающая скобка для " + stack.Pop());
                flag = true;
            }

            if (flag == false)
            {
                Console.WriteLine("Правильная скобочная последовательность");
            }
        }
    }
}
