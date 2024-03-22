namespace Programming.Model
{
    internal class Rectangle
    {
        private static int _allRectanglesCount;
        private double _length;
        private double _width;


        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color, int x, int y)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        public int Id { get; private set; }
        public string Color { get; set; }

        public double Length
        {
            get => _length;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(Length))) _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(Width))) _width = value;
            }
        }

        public Point2D Center { get; private set; }

        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
        }
    }
}