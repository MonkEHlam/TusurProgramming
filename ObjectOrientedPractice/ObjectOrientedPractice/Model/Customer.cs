using ObjectOrientedPractice.Services;
using System;

namespace ObjectOrientedPractice.Model
{
    internal class Customer: IComparable<Customer>, IEquatable<Customer>
    {
        /// <summary>
        /// Customer`s Id
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Customer`s name
        /// </summary>
        private string _name;
        /// <summary>
        /// Customer` address
        /// </summary>
        private Address _address;

        public string Name {
            get 
            { 
                return _name; 
            }
            set
            {
                if (Validator.AssertLengthOfString(value, 200, "customer name"))
                {
                    _name = value;
                }
            }
        }
        public Address Address { get; set; }

        public int Id
        {
            get { return _id; }
        }

        public Customer(string name, Address address)
        {
            _id = IdGenerator.NextCustomerId();
            Name = name;
            Address = address;
        }

        /// <summary>
        /// Base class comparer
        /// </summary>
        /// <param name="compareItem"><see cref="Customer" /> for compare.</param>
        /// <returns>Int compare index of IComparable.</returns>
        public int CompareTo(Customer compareItem)
        {
            if (compareItem == null)
                return 1;

            return Id.CompareTo(compareItem.Id);
        }

        /// <summary>
        /// Compairing pair of <see cref="Customer" />
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// String view of class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
