using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortingFactory
    {

        public const int TYPE_QUICKSORT = 1;
        public const int TYPE_MERGESORT = 2;

        public Sortable GetSortingObjectByType(int type)
        {
            switch (type) {
                case TYPE_QUICKSORT:
                    return new QuickSort();
                case TYPE_MERGESORT:
                    return new MergeSort();
                default:
                    return null;
            }
        }

    }
}
