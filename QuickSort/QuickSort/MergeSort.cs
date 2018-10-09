using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort: Sortable
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
                int middle = (start + end) / 2;

                Sort(numbers, start, middle);
                Sort(numbers, middle + 1, end);

                Merge(numbers, middle, start, end);
            }
        }

        private void Merge(int[] numbers, int middle, int start, int end)
        {
            int leftLength = middle - start + 1;
            int rightLength = end - middle;

            int[] left = new int[leftLength];
            int[] right = new int[rightLength];

            int i, j;
            for (i = 0; i < leftLength; i++)
            {
                left[i] = numbers[start + i];
            }

            for (i = 0; i < rightLength; i++)
            {
                right[i] = numbers[i + middle + 1];
            }

            int k = start;
            i = 0; j = 0;
            while (i < leftLength && j < rightLength)
            {
                if (left[i] < right[j])
                {
                    numbers[k] = left[i];
                    i++;
                }
                else
                {
                    numbers[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                numbers[k] = left[i];
                i++; k++;
            }

            while (j < rightLength)
            {
                numbers[k] = right[j];
                j++; k++;
            }

        }

    }
}
