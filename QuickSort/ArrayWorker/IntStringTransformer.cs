using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    public class IntStringTransformer: IntegerExtension
    {

        public IntStringTransformer(int number) : base(number) { }

        protected override string GetSign()
            => number < 0 ? "minus " : "";

        protected override int GetRemainder()
            => number % 10;

        protected override string GetPartName(int remainder)
        {
            string[] correspondence = new string[]
            {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };

            return correspondence[remainder] + " ";
        } 

        protected override void AppendNameToSB(string name)
            => sb.Insert(0, name);

        protected override void ReduceNumber()
            => number /= 10;

        protected override string JoinParts()
        {
            var chars = sb.ToString().ToArray();
            return sign + new string(chars);
        }
    }
}
