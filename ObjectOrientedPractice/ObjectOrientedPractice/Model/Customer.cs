using ObjectOrientedPractice.Services;
using ObjectOrientedPractice.Model.Discounts;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Represents a customer 
    /// </summary>
    internal class Customer : IComparable<Customer>, IEquatable<Customer>
    {
        /// <summary>
        /// Customer`s Id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// List of orders.
        /// </summary>
        private readonly List<Order> _orders = new List<Order>();

        /// <summary>
        /// Customer`s name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Customer`s current cart.
        /// </summary>
        private Cart _cart;


        /// <summary>
        /// Customer`s name.
        /// </summary>
        public string Name
        {
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

        /// <summary>
        /// Customer`s address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Customer`s Id.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Customer`s current cart.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                Cart = value;
            }
        }

        /// <summary>
        /// List of orders.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
        }

        /// <summary>
        /// Is customer a priority client.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// List of customer`s discounts.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="name">Customer`s name</param>
        public Customer(string name)
        {
            _id = IdGenerator.NextCustomerId();
            Name = name;
            Address = new Address();
            _cart = new Cart();
            Discounts = new List<IDiscount>
            {
                new PointsDiscount()
            };
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
        /// Compairing pair of <see cref="Customer" />.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Customer other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// String view of class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Name == "")
            {
                return $"{Id}, Name: ---";
            }
            return $"{Id}, {Name}";
        }
    }
}
