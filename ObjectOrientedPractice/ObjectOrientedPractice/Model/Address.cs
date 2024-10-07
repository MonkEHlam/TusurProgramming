using ObjectOrientedPractice.Services;

namespace ObjectOrientedPractice.Model
{
    internal class Address
    {
        private int _index = 0;
        private string _country = "";
        private string _city = "";
        private string _street = "";
        private string _building = "";
        private string _apartment = "";

        /// <summary>
        /// Postal code. 6 length integer.
        /// </summary>
        public int Index { 
            get 
            {
                return _index; 
            } 
            set 
            {
                if (Validator.AssertRange(value, 100000, 999999, "address postal index"))
                {
                    _index = value;
                }
            }
        }

        /// <summary>
        /// Country. Cannot be longer than 50 symbols.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 50, "address country"))
                {
                    _country = value;
                }
            }
        }

        /// <summary>
        /// City. Cannot be longer than 50 symbols.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 50, "address city"))
                {
                    _city = value;
                }
            }
        }

        /// <summary>
        /// Street. Cannot be longer than 100 symbols.
        /// </summary>
        public string Street
        {
            get 
            {
                return _street; 
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 100, "Address street"))
                {
                    _street = value;
                }
            }
        }

        /// <summary>
        /// Building, Cannot be longer than 10 symbols.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 10, "address building"))
                {
                    _building = value;
                }
            }
        }

        /// <summary>
        /// Apartment. Cannot be longer than 10 symbols.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 10, "address appartament"))
                {
                    _apartment = value;
                }
            }
        }

        /// <summary>
        /// Empty constructor. Zero fields.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
