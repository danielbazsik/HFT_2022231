using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class RangeAttribute : Attribute
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; set; }

        public MaxLengthAttribute(int max)
        {
            Length = max;
        }
    }
}
