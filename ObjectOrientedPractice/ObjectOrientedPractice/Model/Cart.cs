using ObjectOrientedPractice.View.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractice.Model
{
    internal class Cart
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
    }
}
