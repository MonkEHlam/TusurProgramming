using ObjectOrientedPractice.Services;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Represents an order of customer in store.
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// Unique GUID.
        /// </summary>
        private readonly int _id;
        
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
        /// Unique ID.
        /// </summary>
        public int Id 
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

        /// <summary>
        /// Size of discount for order.
        /// </summary>
        public double DiscountsAmount { get; set; }

        /// <summary>
        /// Price with applied discounts.
        /// </summary>
        double Total {
            get
            {
                return Price - DiscountsAmount;
            }
        }

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="items">List of items from cart.</param>
        /// <param name="amount">Item`s final cost.</param>
        /// <param name="address">Delivery address.</param>
        public Order(List<Item> items, double amount, Address address, double discountsAmount)
        {
            _id = IdGenerator.NextOrderId();
            _createdAt = DateTime.Now;
            ItemsList = items;
            Address = address;
            Price = amount;
            OrderStatus = OrderStatus.New;
            DiscountsAmount = discountsAmount;
        }
    }
}
