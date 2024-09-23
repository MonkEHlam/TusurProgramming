using System;

namespace Programming.Model
{
    /// <summary>
    ///     Содержит методы, проверяющие пересечение колец <see cref="Ring" /> и прямоуголников <see cref="Rectangle" />.
    /// </summary>
    internal static class ColisionManager
    {
        /// <summary>
        ///     Проверяет пересечение прямоугольников <see cref="Rectangle" />
        /// </summary>
        /// <returns>Возвращает правду, если прямоугольники пересекаются, иначе ложь.</returns>
        public static bool IsColision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var xColision = Math.Abs(rectangle1.Center.X - rectangle2.Center.X) <=
                            (rectangle1.Width + rectangle2.Width) / 2;
            var yColision = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) <=
                            (rectangle1.Height + rectangle2.Height) / 2;
            return xColision && yColision;
        }

        /// <summary>
        ///     Проверяет пересечение колец <see cref="Ring" />
        /// </summary>
        /// <returns>Возвращает правду, если кольца пересекаются, иначе ложь.</returns>
        public static bool IsColision(Ring ring1, Ring ring2)
        {
            var c = Math.Pow(Math.Pow
                             (
                                 Math.Abs(ring1.Center.X - ring2.Center.X), 2) +
                             Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2
                             ), 0.5);
            return c < ring1.ExternalRadius + ring2.ExternalRadius;
        }
    }
}