using System;

namespace Programming.Model
{
    /// <summary>
    ///     Содержит методы для проверок числовых значений.
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        ///     Проверяет Integer на значение, большее нуля
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="method">Метод, откуда получено значение</param>
        /// <returns>True, если значение больше нуля, иначе false</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(int value, string method = "")
        {
            if (value < 0) throw new ArgumentException($"Argument must be positive, {method}");
            return true;
        }

        /// <summary>
        ///     Проверяет Double на значение, большее нуля.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="method">Метод, откуда получено значение.</param>
        /// <returns>True, если значение больше нуля, иначе false.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertOnPositiveValue(double value, string method)
        {
            if (value < 0) throw new ArgumentException($"Argument must be positive,\n{method}");
            return true;
        }

        /// <summary>
        ///     Проверяет, находиться ли Integer в диапозоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Низ диапозона.</param>
        /// <param name="max">Верх диапозона</param>
        /// <param name="method">Метод, из которого вызвана проверка</param>
        /// <returns>True, если аргумент в диапозоне, иначе false</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(int value, int min, int max, string method)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Invalid argument,\n{method}");
            return true;
        }

        /// <summary>
        ///     Проверяет, находиться ли Double в диапозоне.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Низ диапозона.</param>
        /// <param name="max">Верх диапозона</param>
        /// <param name="method">Метод, из которого вызвана проверка</param>
        /// <returns>True, если аргумент в диапозоне, иначе false</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool AssertValueInRange(double value, double min, double max, string method)
        {
            if (value < min || value > max)
                throw new ArgumentException($"Invalid argument,\n{method}");
            return true;
        }
    }
}