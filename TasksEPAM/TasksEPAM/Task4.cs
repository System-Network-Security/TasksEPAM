using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TasksEPAM
{
    static internal class Task4
    {
        static internal void Start()
        {
            Console.WriteLine("Вычисление факториала: ");
            string Value = Console.ReadLine();

            BigInteger r = 1;
            for (int i = 2; i <= Convert.ToInt32(Value); ++i)
                r *= i;
            Console.WriteLine(Value +"! = " + r);
        }
    }
}
