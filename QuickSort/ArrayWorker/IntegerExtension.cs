using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    public abstract class IntegerExtension: ITransformable
    {

        protected int number;
        protected StringBuilder sb;
        protected string sign;

        public IntegerExtension(int number)
        {
            this.number = number;
            sb = new StringBuilder();
        }

        public string Transform()
        {
            sign = GetSign();
            number = Math.Abs(number);
            StringBuilder sb = GetNumberParts();
            return JoinParts();
        }

        protected abstract string GetSign();

        protected StringBuilder GetNumberParts()
        {
            while (number != 0)
            {
                int remainder = GetRemainder();
                string name = GetPartName(remainder);
                AppendNameToSB(name);
                ReduceNumber();
            }

            return sb;
        }

        protected abstract int GetRemainder();

        protected abstract string GetPartName(int remainder);

        protected abstract void AppendNameToSB(string name);

        protected abstract void ReduceNumber();

        protected abstract string JoinParts();
        
    }
}
