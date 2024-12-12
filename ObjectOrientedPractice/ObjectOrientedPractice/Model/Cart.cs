using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Represents a cart of customer.
    /// </summary>
    internal class Cart: ICloneable, IEquatable<Cart>
    {
        /// <summary>
        /// List of items in cart.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// List of items in cart.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            private set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Amount cost of items in cart.
        /// </summary>
        public double Amount
        {
            get
            {
                double i = 0.0;
                foreach (var item in Items)
                {
                    i += item.Cost;
                }
                return i;
            }
        }

        /// <summary>
        /// Default cart constructor.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Cart constructor with initial items.
        /// </summary>
        /// <param name="items">List of items.</param>
        public Cart(List<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Cart(Items);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other">Объект item для сравнения.</param>
        /// <returns><inheritdoc/></returns>
        public bool Equals(Cart other)
        {
            for (var i = 0; Items.Count > i; i++)
            {
                if (Items[i] != other.Items[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
