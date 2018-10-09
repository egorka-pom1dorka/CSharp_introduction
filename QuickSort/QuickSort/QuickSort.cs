using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort: Sortable
    {

        public void Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("Invalid array, must be array of integers");
            }

            Sort(numbers, 0, numbers.Length - 1);
        }

        private void Sort(int[] numbers, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(numbers, start, end);
                Sort(numbers, start, pivot - 1);
                Sort(numbers, pivot + 1, end);
            }
        }

        private int Partition(int[] numbers, int start, int end)
        {
            int marker = start;
            int pivot = end;
            for (int i = start; i < end; i++)
            {
                if (numbers[i] < numbers[pivot])
                {
                    Swap(ref numbers[i], ref numbers[marker]);
                    marker++;
                }
            }

            Swap(ref numbers[marker], ref numbers[pivot]);
            return marker;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
