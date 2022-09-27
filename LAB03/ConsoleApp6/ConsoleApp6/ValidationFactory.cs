using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ValidationFactory
    {
        public IValidate GetValidator(Attribute attribute)
        {
            if (attribute is RangeAttribute rangeAttribute)
            {
                return new RangeValidation(rangeAttribute);
            }

            if (attribute is MaxLengthAttribute maxLength)
            {
                return new MaxLengthValidation(maxLength);
            }

            return null;
        }
    }
}
