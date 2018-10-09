using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class NullSortObjetException : Exception
    {
        public NullSortObjetException()
        {
        }

        public NullSortObjetException(string message) : base(message)
        {
        }

        public NullSortObjetException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullSortObjetException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
