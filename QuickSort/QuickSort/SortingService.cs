using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortingService
    {

        private SortingFactory factory = null;

        public SortingService()
        {
            factory = new SortingFactory();
        }

        public void Sort(int[] numbers, int type)
        {
            Sortable sortObject = factory.GetSortingObjectByType(type);
            if (sortObject == null)
            {
                throw new NullSortObjetException("Unknown sorting type");
            }
            sortObject.Sort(numbers);
        }

    }
}
