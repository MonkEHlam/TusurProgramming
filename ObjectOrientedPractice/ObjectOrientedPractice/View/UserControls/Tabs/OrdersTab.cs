using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
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
        private Order _currentOrder;

        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// List of orders displayed in the datagrid.
        /// </summary>
        private List<Order> Orders { get; } = new List<Order>();

        /// <summary>
        /// Gets or sets the list of customers.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersTab"/> class.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.DisableInput();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

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
            
            _currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView[2, OrdersDataGridView.SelectedCells[0].RowIndex].Value =
                Enum.GetName(typeof(OrderStatus), _currentOrder.OrderStatus);
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

            _currentOrder = Orders[OrdersDataGridView.SelectedCells[0].RowIndex];
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreatedAt.ToString();
            StatusComboBox.SelectedItem = _currentOrder.OrderStatus;
            StatusComboBox.Enabled = true;
            AddressControl.currentAddress = _currentOrder.Address;
            AddressControl.UpdateControl();
            AddressControl.DisableInput();
            OrderItemsListBox.DataSource = GetItemNames(_currentOrder.ItemsList);
            AmountLabel.Text = _currentOrder.Price.ToString();
            
            if (typeof(PriorityOrder) == _currentOrder.GetType())
            {
                _currentPriorityOrder = (PriorityOrder)_currentOrder;
                PriorityOptionsGroupBox.Visible = true;
                PriorityTimeComboBox.SelectedIndex = (int)_currentPriorityOrder.DeliveryTime;
                PriorityDateTimePicker.Value = _currentPriorityOrder.DeliveryDay;
            }
            else
            {
                _currentPriorityOrder = null;
                PriorityOptionsGroupBox.Visible = false;
            }
        }

        private void PriorityTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = (DeliveryTime)PriorityTimeComboBox.SelectedIndex;
        }

        private void PriorityDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (PriorityDateTimePicker.Value >= DateTime.Today)
            {
                _currentPriorityOrder.DeliveryDay = PriorityDateTimePicker.Value;
            }
            else
            {
                MessageBox.Show("Wrong date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
