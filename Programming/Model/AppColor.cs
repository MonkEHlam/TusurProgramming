using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    ///     Хранит цвета, используемые в программе.
    /// </summary>
    internal static class AppColor
    {
        /// <summary>
        ///     Ипользуется для обозначения непересекающихся прямоугольников.
        /// </summary>
        public static readonly Color RectangleGreenColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        ///     Ипользуется для обозначения непересекающихся прямоугольников.
        /// </summary>
        public static readonly Color RectangleRedColor = Color.Red;

        public static readonly Color ErrorColor = ColorTranslator.FromHtml("#F53D65");
        public static readonly Color NormalColor = Color.White;
        public static readonly Color FallColor = ColorTranslator.FromHtml("#e29c45");
        public static readonly Color SpringColor = ColorTranslator.FromHtml("#559c45");
    }
}