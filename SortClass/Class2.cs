using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClass
{
    internal class Class2
    {
        static int[] arrays;
        public static int[] CycleSortFn(int[] arrrrr)
        {
            int[] arrTest = GenerateRandomArray(10);
            CycleSort(arrTest);
            return arrTest;
        }


        public static int[] NotSortArrCycle(int size)
        {
            arrays = GenerateRandomArray(size);
            return arrays;
        }
        public static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // Генерируем случайные числа от 1 до 100
            }

            return array;
        }

        public static void CycleSort(int[] array)
        {
            int n = array.Length;
            for (int cycleStart = 0; cycleStart < n - 1; cycleStart++)
            {
                int item = array[cycleStart];
                int pos = cycleStart;

                for (int i = cycleStart + 1; i < n; i++)
                {
                    if (array[i] < item)
                    {
                        pos++;
                    }
                }

                if (pos == cycleStart)
                {
                    continue;
                }

                while (item == array[pos])
                {
                    pos++;
                }

                int temp = array[pos];
                array[pos] = item;

                while (pos != cycleStart)
                {
                    pos = cycleStart;
                    for (int i = cycleStart + 1; i < n; i++)
                    {
                        if (i < n && array[i] < item)
                        {
                            pos++;
                        }
                    }

                    while (pos < n && item == array[pos])
                    {
                        pos++;
                    }

                    if (pos < n)
                    {
                        temp = array[pos];
                        array[pos] = item;
                    }
                }
            }
        }
    }
}
