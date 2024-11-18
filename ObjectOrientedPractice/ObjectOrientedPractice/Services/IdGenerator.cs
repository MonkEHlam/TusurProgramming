namespace ObjectOrientedPractice.Services
{
    /// <summary>
    /// Service class for ID generating.
    /// </summary>
    public static class IdGenerator
    {
        private static  int _itemId = 1;
        private static int _customerId = 1;
        private static int _orderId = 1;

        /// <summary>
        /// Get uniqe identificator of Item
        /// </summary>
        /// <returns>New identificator</returns>
        public static int NextItemId() 
        {
            return _itemId++;
        }

        /// <summary>
        /// Get uniqe identificator of Customer
        /// </summary>
        /// <returns>New identificator</returns>
        public static int NextCustomerId()
        {
            return _customerId++;
        }

        /// <summary>
        /// Get uniqe identificator of Customer
        /// </summary>
        /// <returns>New identificator</returns>
        public static int NextOrderId()
        {
            return _orderId++;
        }
    }
}
