using System.Collections.Generic;
using ObjectOrientedPractice.Model.Enums;

namespace ObjectOrientedPractice.Model.Discounts
{
    internal class PercentDiscount : IDiscount
    {
        public int CurrentPercent {  get; private set; }

        public Category Category { get; private set; }

        public double AmountSpended {  get; private set; }

        public string Info
        {
            get
            {
                return $"Процентная \"{Category}\" - {CurrentPercent}%";
            }
        }

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

        public PercentDiscount(Category category) 
        {
            Category = category;
            CurrentPercent = 1;
        }

        public double Calculate(List<Item> items)
        {
            return GetCost(items) / 100 * CurrentPercent;
        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            double spended = GetCost(items);
            AmountSpended += spended;

            int newPercent = (int)(AmountSpended / 1000) + 1;
            CurrentPercent = newPercent < 10 ? newPercent : 10;
        }
    }
}
