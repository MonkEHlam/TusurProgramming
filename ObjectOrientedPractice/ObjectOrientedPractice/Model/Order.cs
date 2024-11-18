using ObjectOrientedPractice.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Model
{
    internal class Order
    {
        /// <summary>
        /// Unique GUID.
        /// </summary>
        private readonly string _id;
        
        /// <summary>
        /// Time of creation.
        /// </summary>
        private readonly DateTime _createdAt;
        
        /// <summary>
        /// Order`s address.
        /// </summary>
        private Address _address;
        
        /// <summary>
        /// List of items.
        /// </summary>
        private List<Item> _itemsList;
        
        /// <summary>
        /// Total price of order.
        /// </summary>
        private double _price;

        /// <summary>
        /// Current status of order.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Unique GUID.
        /// </summary>
        public string Id 
        {
            get 
            {
                return _id; 
            }
        }

        /// <summary>
        /// Time of creation.
        /// </summary>
        public DateTime CreatedAt 
        {
            get
            { 
                return _createdAt;
            } 
        }

        /// <summary>
        /// Total price of order.
        /// </summary>
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Order`s address.
        /// </summary>
        public Address Address
        {
            get 
            {
                return _address; 
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// List of items.
        /// </summary>
        public List<Item> ItemsList
        {
            get
            {
                return _itemsList;
            }
            set
            {
                _itemsList = value;
            }
        }

        public Order(List<Item> items, double amount, Address address)
        {
            _id = IdGenerator.NewId();
            _createdAt = DateTime.Now;
            ItemsList = items;
            Address = address;
            Price = amount;
            OrderStatus = OrderStatus.New;
        }
    }
}
