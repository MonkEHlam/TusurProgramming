using System;

namespace ObjectOrientedPractice.Services
{
    static public class Validator
    {
        /// <summary>
        /// Assert string`s length
        /// </summary>
        /// <param name="str">Asserting string</param>
        /// <param name="maxLength"></param>
        /// <param name="minLength">As default 0</param>
        /// <returns></returns>
        public static bool AssertLengthOfString(string str, int maxLength, string assertionSource, int minLength = 0) {
            if (str == null) { return false; }
            if (minLength <= str.Length && str.Length <= maxLength) { return true; }
            throw new ArgumentException($"Failed on string length assertion in {assertionSource}.");
        }

        /// <summary>
        /// Assert does number in range
        /// </summary>
        /// <param name="num">Asserting number</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertRange(double num, double min, double max, string assertionSource)
        {
            if (num >= min && num <= max) 
            { 
                return true; 
            }
            throw new ArgumentException($"Failed on range assertion in {assertionSource}.");
        }
    }
}
