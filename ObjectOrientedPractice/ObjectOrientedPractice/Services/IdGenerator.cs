using System.Diagnostics;

namespace ObjectOrientedPractice.Services
{
    public static class IdGenerator
    {
        static private int _itemId = 1;
        private static int _CustomerId = 1;

        /// <summary>
        /// Get uniqe index of Item
        /// </summary>
        /// <returns>New index</returns>
        static public int NextItemId() 
        {
            return _itemId++;
        }

        /// <summary>
        /// Get uniqe index of Customer
        /// </summary>
        /// <returns>New index</returns>
        public static int NextCustomerId()
        {
            return _CustomerId++;
        }
    }
}
