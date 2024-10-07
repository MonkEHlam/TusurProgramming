using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractice.Model
{
    internal class Store
    {
        /// <summary>
        /// List of existing <see cref="Item"/>s.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// List of existing <see cref="Customer"/>s.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Empty constructor. Fieads are empty, but initialaized.
        /// </summary>
        public Store() { }
    }
}
