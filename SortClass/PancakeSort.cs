using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClass
{
    public class PancakeSort
    {
        static int[] array;
        public static int[] PanSort(int[] array)
        {
            PancakeSortFn(array);

            return array;
        }

        public static int[] NotSortArr(int size)
        {
            array = GenerateRandomArray(size);
            return array;
        }

        static int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100); // Генерируем случайные числа от 1 до 100
            }

            return array;
        }

        static void PancakeSortFn(int[] arr)
        {
            for (int i = arr.Length; i > 1; i--)
            {
                int maxIndex = FindMaxIndex(arr, i);
                if (maxIndex != i - 1)
                {
                    if (maxIndex != 0)
                    {
                        Flip(arr, maxIndex);
                    }
                    Flip(arr, i - 1);
                }
            }
        }

        static int FindMaxIndex(int[] arr, int n)
        {
            int maxIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void Flip(int[] arr, int k)
        {
            int start = 0;
            while (start < k)
            {
                int temp = arr[start];
                arr[start] = arr[k];
                arr[k] = temp;
                start++;
                k--;
            }

        }
    }

}
