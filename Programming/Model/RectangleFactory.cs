using System;

namespace Programming.Model
{
    internal static class RectangleFactory
    {
        /// <summary>
        ///     Создает экземпляр класса <see cref="Rectangle" />, чтоб он вмещался в рамки.
        /// </summary>
        /// <param name="xMinPoint">Левый предел.</param>
        /// <param name="xMaxPoint">Правый предел.</param>
        /// <param name="yMinPoint">Верхний предел.</param>
        /// <param name="yMaxPoint">Нижний предел.</param>
        /// <returns>"Экземпляр класса <see cref="Rectangle" /></returns>
        public static Rectangle Randomize(int xMinPoint, int xMaxPoint, int yMinPoint, int yMaxPoint)
        {
            var rand = new Random();
            var height = rand.Next(1, yMaxPoint);
            var width = rand.Next(1, xMaxPoint);
            var leftUPoint = new Point2D(rand.Next(xMinPoint, xMaxPoint - width),
                rand.Next(yMinPoint, yMaxPoint - height));
            var rect = new Rectangle(height, width, leftUPoint);
            return rect;
        }
    }
}