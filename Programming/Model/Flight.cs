using System;

namespace Programming.Model
{
    internal class Flight
    {
        public string DeparturePoint {  get; set; }
        public string ArrivalPoint { get; set; }

        private int _flightTimeInMinutes;
        public int FlightTimeInMinutes 
        { 
            get { return _flightTimeInMinutes; } 
            set { if (Validator.AssertOnPositiveValue(value, this.GetType() + "." + nameof(FlightTimeInMinutes))) _flightTimeInMinutes = value;  }
        }

        public Flight() { }
        
        public Flight(string departurePoint, string arrivalPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
