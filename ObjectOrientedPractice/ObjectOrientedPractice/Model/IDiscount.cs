using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractice.Model
{
    internal interface IDiscount
    {
        /// <summary>
        /// Provides a string representation of the discount information.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Calculates the discount amount.
        /// </summary>
        /// <param name="items">A list of items.</param>
        /// <returns>The discount amount.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Applies the calculated discount.
        /// </summary>
        /// <param name="items">A list of items.</param>
        /// <returns>The discount amount applied.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Updates the accumulated discount.
        /// </summary>
        /// <param name="items">A list of items.</param>
        void Update(List<Item> items);
    }
}
