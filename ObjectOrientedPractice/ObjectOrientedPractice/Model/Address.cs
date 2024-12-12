using ObjectOrientedPractice.Services;
using System;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Class representing a postal address.
    /// </summary>
    internal class Address: ICloneable
    {
        /// <summary>
        /// Postal code.
        /// </summary>
        private int _index = 0;

        /// <summary>
        /// Country.
        /// </summary>
        private string _country = "";

        /// <summary>
        /// City.
        /// </summary>
        private string _city = "";

        /// <summary>
        /// Street.
        /// </summary>
        private string _street = "";

        /// <summary>
        /// Building number.
        /// </summary>
        private string _building = "";

        /// <summary>
        /// Apartment number.
        /// </summary>
        private string _apartment = "";

        /// <summary>
        /// Postal code.  Six-digit integer.
        /// </summary>
        public int Index
        {
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
        /// Country. String length must not exceed 50 characters.
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
        /// City. String length must not exceed 50 characters.
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
        /// Street. String length must not exceed 100 characters.
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
        /// Building number. String length must not exceed 10 characters.
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
        /// Apartment number. String length must not exceed 10 characters.
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
        /// Empty constructor. All fields are initialized to default values.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="index">Postal code.</param>
        /// <param name="country">Country.</param>
        /// <param name="city">City.</param>
        /// <param name="street">Street.</param>
        /// <param name="building">Building number.</param>
        /// <param name="apartment">Apartment number.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool Equals(Address other)
        {
            if (other == null) return false;
            return (Index == other.Index &&
                    Country == other.Country &&
                    City == other.City &&
                    Street == other.Street &&
                    Building == other.Building &&
                    Apartment == other.Apartment);
        }
    }
}

