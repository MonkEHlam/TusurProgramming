using System;

namespace Programming.Model
{
    internal class Ring
    {
        private double _externalRadius;
        private double _internalRadius;

        public Ring(Point2D center, double internalRadius, double externalRadius)
        {
            Center = center;
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
        }

        public Point2D Center { get; set; }

        public double InternalRadius
        {
            get => _internalRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, $"{GetType()}.{nameof(InternalRadius)}"))
                    _internalRadius = value;
            }
        }

        public double ExternalRadius
        {
            get => _externalRadius;
            set
            {
                if (Validator.AssertOnPositiveValue(value, $"{GetType()}.{nameof(InternalRadius)}") &&
                    value > InternalRadius)
                    _externalRadius = value;
                else
                    throw new ArgumentException();
            }
        }

        public double Area
        {
            get
            {
                var internalArea = Math.Pow(InternalRadius, 2) * Math.PI;
                var externalArea = Math.Pow(ExternalRadius, 2) * Math.PI;
                return externalArea - internalArea;
            }
        }
    }
}