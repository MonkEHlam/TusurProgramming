namespace Programming.Model
{
    /// <summary>
    ///     Хранит точку в двухмерном пространстве.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        ///     Создает экземпляр класса.
        /// </summary>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        ///     Возвращает значение по оси абсцисс. =0
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        ///     Возвращает значение по оси ординат.
        /// </summary>
        public int Y { get; private set; }
    }
}