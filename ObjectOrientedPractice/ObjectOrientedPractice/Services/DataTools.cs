using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Services
{
    /// <summary>
    /// Provides utility methods for filtering and sorting lists of Items.
    /// </summary>
    internal static class DataTools
    {
        /// <summary>
        /// Filters a list of Items based on a provided condition.
        /// </summary>
        /// <param name="items">The list of Items to filter.</param>
        /// <param name="condition">A function that takes an Item and returns true if the Item should be included in the filtered list, false otherwise.</param>
        /// <returns>A new list containing only the Items that satisfy the condition.</returns>
        internal static List<Item> FilterItems(List<Item> items, Func<Item, bool> condition)
        {
            var outputItems = new List<Item>();

            foreach (var item in items)
            {
                if (condition(item))
                {
                    outputItems.Add(item);
                }
            }
            return outputItems;
        }

        /// <summary>
        /// Sorts a list of Items using a bubble sort algorithm based on a provided comparison condition.
        /// </summary>
        /// <param name="items">The list of Items to sort.</param>
        /// <param name="condition">A function that takes two Items and returns true if the first Item should come before the second Item in the sorted list, false otherwise.</param>
        /// <returns>A new list containing the sorted Items.</returns>
        internal static List<Item> SortItems(List<Item> items, Func<Item, Item, bool> condition)
        {
            if (items.Count < 2)
            {
                return items;
            }

            var sortItems = new List<Item>(items); // Create a copy to avoid modifying the original list

            int n = sortItems.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (condition(sortItems[j], sortItems[j + 1]))
                    {
                        var temp = sortItems[j];
                        sortItems[j] = sortItems[j + 1];
                        sortItems[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break; // Optimization: If no swaps occurred, the list is sorted
            }

            return sortItems;
        }

        /// <summary>
        /// Filters a list of Items to include only those with a cost greater than or equal to 5000.
        /// </summary>
        /// <param name="items">The list of Items to filter.</param>
        /// <returns>A new list containing only the Items with a cost greater than or equal to 5000.</returns>
        internal static List<Item> FilterItemsByCost(List<Item> items)
        {
            return FilterItems(items, item => item.Cost >= 5000);
        }

        /// <summary>
        /// Filters a list of Items to include only those of a specified category.
        /// </summary>
        /// <param name="items">The list of Items to filter.</param>
        /// <param name="category">The category to filter by.</param>
        /// <returns>A new list containing only the Items of the specified category.</returns>
        internal static List<Item> FilterItemsByCategory(List<Item> items, Category category)
        {
            return FilterItems(items, item => item.Category == category);
        }
    }
}
