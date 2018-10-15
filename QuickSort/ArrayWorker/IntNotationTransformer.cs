using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    public class IntNotationTransformer: IntegerExtension
    {

        private int @base;
        private string alphabet;

        private const string ALPHABET = "0123456789ABCDEF";

        public IntNotationTransformer(int number, int @base) : base(number)
        {
            this.@base = @base;
            alphabet = ALPHABET.Substring(0, @base);
        }

        protected override string GetSign()
            => number < 0 ? "-" : "";

        protected override int GetRemainder()
            => number % @base;

        protected override string GetPartName(int remainder)
            => alphabet[remainder].ToString();

        protected override void AppendNameToSB(string name)
            => sb.Append(name);

        protected override void ReduceNumber()
            => number /= @base;

        protected override string JoinParts()
        {
            var chars = sb.Append(sign).ToString().Reverse().ToArray();
            return new string(chars);
        }

    }
}
