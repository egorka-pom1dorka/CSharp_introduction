using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Sorting
    {

        public static void QuickSort(int[] arr, int start, int end)
        {
            if (start < 0 || end > arr.Length - 1)
            {
                throw new OutOfArrayException("Given indexes are out of array");
            }

            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int marker = start;
            int pivot = end;
            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[pivot])
                {
                    Swap(ref arr[i], ref arr[marker]);
                    marker++;
                }
            }
            Swap(ref arr[marker], ref arr[pivot]);
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