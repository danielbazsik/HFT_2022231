using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class Validator
    {
        public static bool Validate(this object instance)
        {
            ValidationFactory validationFactory = new();
            var propertyInfoArray = instance.GetType().GetProperties();

            foreach (var propertyInfo in propertyInfoArray)
            {
                var attributes = propertyInfo.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    var validation = validationFactory.GetValidator(attribute);
                    if (validation?.Validate(instance, propertyInfo) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
