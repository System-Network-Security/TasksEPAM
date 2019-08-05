using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEPAM
{
    static internal class SortingMethod
    {
        static internal int[] BubbleSort(int[] Value)
        {
            for (int i = 0; i < Value.Length; i++)
            {
                for (int j = 0; j < Value.Length - 1; j++)
                {
                    if (Value[j] > Value[j + 1])
                    {
                        int Temp = Value[j];
                        Value[j] = Value[j + 1];
                        Value[j + 1] = Temp;
                    }
                }
            }
            return Value;
        }

        static internal void Sorting(int[] Value)
        {
            Array.Sort(Value);
        }
    }
}
