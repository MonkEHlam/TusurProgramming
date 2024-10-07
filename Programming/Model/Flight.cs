namespace Programming.Model
{
    internal class Flight
    {
        private int _flightTimeInMinutes;

        public Flight()
        {
        }

        public Flight(string departurePoint, string arrivalPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public string DeparturePoint { get; set; }
        public string ArrivalPoint { get; set; }

        public int FlightTimeInMinutes
        {
            get => _flightTimeInMinutes;
            set
            {
                if (Validator.AssertOnPositiveValue(value, GetType() + "." + nameof(FlightTimeInMinutes)))
                    _flightTimeInMinutes = value;
            }
        }
    }
}