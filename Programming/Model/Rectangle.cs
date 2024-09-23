namespace Programming.Model
{
    /// <summary>
    ///     Хранит данные о прямоугольнике.
    /// </summary>
    internal class Rectangle
    {
        private static int _allRectanglesCount;
        private int _height;
        private Point2D _leftUpPoint;
        private int _width;

        /// <summary>
        ///     Создает путсой экземпляр класса.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            Id = GetAllRectanglesCount();
        }

        /// <summary>
        ///     Создает экземпляр класса.
        /// </summary>
        /// <param name="height">Высота.</param>
        /// <param name="width">Ширина.</param>
        /// <param name="leftUpPoint">Верхняя левая точка прямоугольника</param>
        public Rectangle(int height, int width, Point2D leftUpPoint)
        {
            LeftUPoint = leftUpPoint;
            Height = height;
            Width = width;
            _allRectanglesCount++;
            Id = GetAllRectanglesCount();
        }

        /// <summary>
        ///     Возвращает идентификатор прямоугольника.
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///     Возвращает и принимает высоту.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
                Center = new Point2D(_leftUpPoint.X + Width, Height + _leftUpPoint.Y);
            }
        }

        /// <summary>
        ///     Возвращает и принимает ширину.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                Center = new Point2D(_leftUpPoint.X + Width, Height + _leftUpPoint.Y);
            }
        }

        /// <summary>
        ///     Возвращает и принимает верхнюю левую точку прямоугольника.
        /// </summary>
        public Point2D LeftUPoint
        {
            get => _leftUpPoint;

            set
            {
                _leftUpPoint = value;
                Center = new Point2D(_leftUpPoint.X + Width, Height + _leftUpPoint.Y);
            }
        }

        /// <summary>
        ///     Возвращает точку центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        ///     Возвращает строковое представление прямоугольника.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}: X= {LeftUPoint.X}, Y = {LeftUPoint.Y}, W = {Width}, H = {Height}";
        }

        /// <summary>
        ///     Возвращает количество прямоугольников.
        /// </summary>
        public static int GetAllRectanglesCount()
        {
            return _allRectanglesCount;
        }
    }
}