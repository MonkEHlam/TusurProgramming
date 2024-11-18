using System;

namespace ObjectOrientedPractice.Services
{
    /// <summary>
    /// Static class, that validates user`s input values.
    /// </summary>
    static public class Validator
    {
        /// <summary>
        /// Assert string`s length
        /// </summary>
        /// <param name="str">Asserting string</param>
        /// <param name="maxLength"></param>
        /// <param name="minLength">As default 0</param>
        /// <returns></returns>
        public static bool AssertLengthOfString(string str, int maxLength, string assertionSource) {
            if (str == null) { return false; }
            if (str.Length <= maxLength) { return true; }
            throw new ArgumentException($"Failed on string length assertion in {assertionSource}.");
        }

        /// <summary>
        /// Assert does number in range including edges.
        /// </summary>
        /// <param name="num">Asserting number.</param>
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

        /// <summary>
        /// Assert does number in range including edges.
        /// </summary>
        /// <param name="num">Asserting number.</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertRange(int num, int min, int max, string assertionSource)
        {
            if (num >= min && num <= max)
            {
                return true;
            }
            throw new ArgumentException($"Failed on range assertion in {assertionSource}.");
        }
    }
}
