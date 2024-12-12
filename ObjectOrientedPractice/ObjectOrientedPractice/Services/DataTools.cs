using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Services
{
    internal static class DataTools
    {
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

        internal static List<Item> SortItems(List<Item> items, Func<Item, Item, bool> condition)
        {
            if (items.Count < 2)
            {
                return items;
            }

            var sortItems = new List<Item>(items);

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
                // Если за проход не было обменов, массив отсортирован
                if (!swapped)
                    break;
            }

            return sortItems;
        }

        internal static List<Item> FilterItemsByCost(List<Item> items)
        {
            return FilterItems(items, item => item.Cost >= 5000);
        }

        internal static List<Item> FilterItemsByCategory(List<Item> items, Category category)
        {
            return FilterItems(items, item => item.Category == category);
        }
    }
}
