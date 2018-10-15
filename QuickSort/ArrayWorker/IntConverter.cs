using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    public static class IntConverter
    {

        public static string Transform(this int number, ITransformable obj)
            => obj.Transform();

        public static string TransformToBase(this int number, int @base)
        {
            var transformer = new IntNotationTransformer(number, @base);
            return number.Transform(transformer);
        }

        public static string TransformToString(this int number)
        {
            var transformer = new IntStringTransformer(number);
            return number.Transform(transformer);
        }
        

    }

}
