using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Sorting
    {

        public static void QuickSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Argument must be array of integers");
            }

            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);
                QuickSort(array, start, pivot - 1);
                QuickSort(array, pivot + 1, end);
            }
        }

        private static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            int pivot = end;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[pivot])
                {
                    Swap(ref array[i], ref array[marker]);
                    marker++;
                }
            }

            Swap(ref array[marker], ref array[pivot]);
            return marker;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void MergeSort()
        {

        }

    }
}