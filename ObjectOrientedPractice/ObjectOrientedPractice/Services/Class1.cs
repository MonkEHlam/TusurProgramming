using ObjectOrientedPractice.Model;
using System.Collections.Generic;

namespace ObjectOrientedPractice.Services
{
    internal static class DataTools
    {
        internal delegate bool FilterCondition(Item item);

        internal static List<Item> FilterItems(List<Item> items, FilterCondition condition)
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
    }
}
