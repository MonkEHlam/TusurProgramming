namespace ObjectOrientedPractice.Services
{
    public static class IdGenerator
    {
        private static  int _itemId = 1;
        private static int _CustomerId = 1;

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
            return _CustomerId++;
        }
    }
}
