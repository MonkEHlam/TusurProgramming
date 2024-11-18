using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// User control for displaying and managing orders.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersTab"/> class.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.DisableInput(); // Disables direct address input.
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus)); // Sets data source for status combobox.
        }

        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        /// <summary>
        /// List of orders displayed in the datagrid.
        /// </summary>
        private List<Order> Orders { get; } = new List<Order>();

        /// <summary>
        /// Refreshes the order data displayed on the Orders tab.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Updates the OrdersDataGridView with the latest order information.
        /// </summary>
        private void UpdateOrders()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();

            foreach (var customer in Customers)
            {
                // Constructs a formatted address string.
                var address = $"{customer.Address.Country}, {customer.Address.City}, ";
                address += $"{customer.Address.Street} {customer.Address.Building}, ";
                address += $"{customer.Address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    OrdersDataGridView.Rows.Add(
                        order.Id, order.CreatedAt, order.OrderStatus, customer.Name,
                        address, order.Price);
                }
            }
        }

        /// <summary>
        /// Extracts the names of items from a list of Item objects.
        /// </summary>
        /// <param name="items">The list of Item objects.</param>
        /// <returns>A list of item names.</returns>
        private List<string> GetItemNames(List<Item> items)
        {
            var itemNames = new List<string>();
            foreach (var item in items)
            {
                if (item.Name.Trim() != "")
                {
                    itemNames.Add(item.Name);
                }
                else
                {
                    itemNames.Add("---");
                }
            }
            return itemNames;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the StatusComboBox.
        /// Updates the order status in the data source and the DataGridView.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                return;
            }

            var selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            Orders[selectedIndex].OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView[2, selectedIndex].Value =
                Enum.GetName(typeof(OrderStatus), Orders[selectedIndex].OrderStatus);
        }

        /// <summary>
        /// Handles the SelectionChanged event of the OrdersDataGridView.
        /// Updates the UI with details of the selected order.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event arguments.</param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                CreatedTextBox.Text = string.Empty;
                StatusComboBox.SelectedIndex = -1;
                StatusComboBox.Enabled = false;
                AddressControl.currentAddress = null;
                OrderItemsListBox.DataSource = new List<string>();
                AmountLabel.Text = string.Empty;
                return;
            }

            var selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            IdTextBox.Text = Orders[selectedIndex].Id.ToString();
            CreatedTextBox.Text = Orders[selectedIndex].CreatedAt.ToString();
            StatusComboBox.SelectedItem = Orders[selectedIndex].OrderStatus;
            StatusComboBox.Enabled = true;
            AddressControl.currentAddress = Orders[selectedIndex].Address;
            AddressControl.UpdateControl();
            AddressControl.DisableInput();
            OrderItemsListBox.DataSource = GetItemNames(Orders[selectedIndex].ItemsList);
            AmountLabel.Text = Orders[selectedIndex].Price.ToString();
        }
    }
}
