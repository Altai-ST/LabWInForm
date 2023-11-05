using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClass
{
    public class Class1
    {
        static int[] arrays;
        public static int[] RandSort(int[] arrayR)
        {
            RandomSort(arrayR);
            return arrayR;
        }

        public static int[] NotSortArrRand(int size)
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

        public static void RandomSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            Random random = new Random();

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(array, i, i - 1);
                    }
                }

                left++;
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

}
