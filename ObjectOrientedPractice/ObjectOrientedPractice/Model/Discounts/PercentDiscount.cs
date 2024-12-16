using System;
using System.Collections.Generic;
using ObjectOrientedPractice.Model.Enums;

namespace ObjectOrientedPractice.Model.Discounts
{
    /// <summary>
    /// Represents a percentage-based discount applied to a specific category of items.
    /// Implements IDiscount and IComparable for discount calculation and comparison.
    /// </summary>
    internal class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// The current percentage discount (1-10%).
        /// </summary>
        public int CurrentPercent { get; private set; }

        /// <summary>
        /// The category of items this discount applies to.
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// The total amount spent on items of this category.  Used for discount updates.
        /// </summary>
        public double AmountSpended { get; private set; }

        /// <summary>
        /// Provides a string representation of the discount.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Percentage \"{Category}\" - {CurrentPercent}%";
            }
        }

        /// <summary>
        /// Calculates the total cost of items in the specified category.
        /// </summary>
        /// <param name="items">The list of items to calculate the cost from.</param>
        /// <returns>The total cost of items in the specified category.</returns>
        private double GetCost(List<Item> items)
        {
            double cost = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    cost += item.Cost;
                }
            }
            return cost;
        }

        /// <summary>
        /// Constructor for PercentDiscount. Initializes with a category and a default discount of 1%.
        /// </summary>
        /// <param name="category">The category of items this discount applies to.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            CurrentPercent = 1;
        }

        /// <summary>
        /// Calculates the discount amount based on the current percentage and the cost of items.
        /// </summary>
        /// <param name="items">The list of items to calculate the discount from.</param>
        /// <returns>The discount amount.</returns>
        public double Calculate(List<Item> items)
        {
            return GetCost(items) / 100 * CurrentPercent;
        }

        /// <summary>
        /// Applies the discount to the specified items.  In this case, it's the same as Calculate().
        /// </summary>
        /// <param name="items">The list of items to apply the discount to.</param>
        /// <returns>The discount amount.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Updates the discount percentage based on the total amount spent on items of this category.
        /// The discount increases by 1% for every 1000 units spent, up to a maximum of 10%.
        /// </summary>
        /// <param name="items">The list of items to update the discount based on.</param>
        public void Update(List<Item> items)
        {
            double spended = GetCost(items);
            AmountSpended += spended;

            int newPercent = (int)(AmountSpended / 1000) + 1;
            CurrentPercent = newPercent < 10 ? newPercent : 10;
        }

        /// <summary>
        /// Compares this PercentDiscount to another based on the current percentage.
        /// </summary>
        /// <param name="other">The other PercentDiscount to compare to.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
                return 1;

            return CurrentPercent.CompareTo(other.CurrentPercent);
        }
    }
}