using System;
using System.Diagnostics;

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
        public static bool AssertLengthOfString(string str, int maxLength, int minLength = 0) {
            if (str == null) { return false; }
            if (minLength < str.Length && maxLength > str.Length) { return true; }
            StackFrame frame = new StackFrame();
            throw new ArgumentException("Error on range validation, trying to validate properety" + frame.GetMethod().Name);
        } 

        /// <summary>
        /// Assert does number in range
        /// </summary>
        /// <param name="num">Asserting number</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertRange(int num, int min, int max) {
            if (num > min && num < max) { return true; }
            StackFrame frame = new StackFrame();
            throw new ArgumentException("Error on range validation, trying to validate properety" + frame.GetMethod().Name);
        }

        /// <summary>
        /// Assert does number in range
        /// </summary>
        /// <param name="num">Asserting number</param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertRange(double num, double min, double max)
        {
            if (num > min && num < max) { return true; }
            return false;
        }
    }
}
