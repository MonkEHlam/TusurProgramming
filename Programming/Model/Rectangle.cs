using System;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _length;
        public double Length
        {
            get { return _length; }
            set { if (Validator.AssertOnPositiveValue(value, this.GetType() + "." + nameof(Length))) _length = value; }
        }

        private double _width;
        public double Width 
        {
            get { return _width; }
            set { if (Validator.AssertOnPositiveValue(value, this.GetType() + "." + nameof(Width))) _width = value; }
        }
        public string Color { get; set; }

        private Point2D _center;
        public Point2D Center
        {
            get => _center;
            private set => _center = value;
        }

        public Rectangle() { }
        public Rectangle(double length, double width, string color, int x, int y) 
        {
            Length = length;
            Width = width; 
            Color = color;
            Center = new Point2D(x, y);
        }
    }
}
