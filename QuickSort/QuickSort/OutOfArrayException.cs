using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class OutOfArrayException : Exception
    {
        public OutOfArrayException()
        {
        }

        public OutOfArrayException(string message) : base(message)
        {
        }

        public OutOfArrayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfArrayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
