using System.Collections.Generic;

namespace ObjectOrientedPractice.Model.Discounts
{
    /// <summary>
    /// Represents a discount based on accumulated points.
    /// </summary>
    internal class PointsDiscount : IDiscount
    {
        private int _points;

        /// <summary>
        /// Gets or sets the number of accumulated points.  
        /// Setting the value ensures it remains non-negative.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (_points != value && value >= 0)
                {
                    _points = value;
                }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов"; //Consider localizing this string
            }
        }

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="PointsDiscount"/> class.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Calculates the total cost of the given items.
        /// </summary>
        /// <param name="items">A list of items.</param>
        /// <returns>The total cost of the items.</returns>
        private double GetCost(List<Item> items)
        {
            double cost = 0;

            foreach (Item item in items)
            {
                cost += item.Cost;
            }

            return cost;
        }

        /// <summary>
        /// <inheritdoc/>
        /// Based on accumulated points and maximum possible discount.
        /// </summary>
        /// <param name="items">A list of items.</param>
        /// <returns>The discount amount.</returns>
        public double Calculate(List<Item> items)
        {
            double maxDiscount = GetCost(items) / 100 * 30;

            if (Points < maxDiscount)
            {
                return Points;
            }
            return maxDiscount;
        }

        /// <summary>
        /// <inheritdoc/>
        /// Also decrease the points.
        /// </summary>
        /// <param name="items">A list of items.</param>
        /// <returns>The discount amount applied.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            if (Points - (int)discount > 0)
            {
                Points -= (int)discount;
            }
            else
            {
                Points = 0;
            }

            return discount;
        }

        /// <summary>
        /// Updates the accumulated points based on the cost of the given items.
        /// </summary>
        /// <param name="items">A list of items.</param>
        public void Update(List<Item> items)
        {
            double newPoints = (int)(GetCost(items) / 10);
            Points += newPoints % 1 == 0 ? (int)newPoints : (int)newPoints + 1;
        }
    }
}
