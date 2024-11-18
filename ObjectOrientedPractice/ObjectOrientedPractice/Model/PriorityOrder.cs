using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Represents a priorite order.
    /// Priority order contains additional info about date and time of delivery.
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Date of delivery.
        /// </summary>
        DateTime DeliveryDay { get; set; }

        /// <summary>
        /// Time of delivery.
        /// </summary>
        DeliveryTime DeliveryTime { get; set; } 

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="amount"></param>
        /// <param name="address"></param>
        public PriorityOrder(List<Item> items, double amount, Address address)
            : base(items, amount, address)
        {
            DeliveryDay = DateTime.Today;
            DeliveryTime = DeliveryTime.NineToEleven;
        }
    }
}
