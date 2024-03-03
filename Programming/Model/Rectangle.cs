using System;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _length;
        public double Length
        {
            get { return _length; }
            set { _length = value > 0 ? value : throw new ArgumentException(); }
        }

        private double _width;
        public double Width 
        {
            get { return _width; }
            set { _width = value > 0 ? value : throw new ArgumentException(); }
        }
        public string Color { get; set; }

        public Rectangle() { }
        public Rectangle(double length, double width, string color) 
        {
            Length = length;
            Width = width; 
            Color = color;
        }
    }
}
