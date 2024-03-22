using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class Validator
    {
        public static bool AssertOnPositiveValue(int value, string method)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Argument must be positive, {method}");
            }
            return true;
        }
        public static bool AssertOnPositiveValue(double value, string method)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Argument must be positive,\n{method}");
            }
            return true;
        }
        public static bool AssertValueInRange(int value, int min, int max, string method) 
        {
            if ((value < min) || (value > max))
                throw new ArgumentException($"Invalid argument,\n{method}");
            return true;
            
        }
        public static bool AssertValueInRange(double value, double min, double max, string method) 
        {
            if ((value < min) || (value > max))
                throw new ArgumentException($"Invalid argument,\n{method}");
            return true;
        }
    }
}
