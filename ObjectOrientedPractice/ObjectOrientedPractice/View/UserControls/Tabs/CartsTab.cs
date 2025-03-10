using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// User control for managing shopping carts and orders.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartsTab"/> class.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// List of available items.
        /// </summary>
        internal List<Item> Items { get; set; } = new List<Item>();
        /// <summary>
        /// List of customers.
        /// </summary>
        internal List<Customer> Customers { get; set; } = new List<Customer>();
        /// <summary>
        /// Currently selected customer.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Discount amount.
        /// </summary>
        private double Discount {  get; set; }

        /// <summary>
        /// Updates the cart information displayed on the UI.
        /// </summary>
        private void UpdateInfo()
        {
            if (_currentCustomer.Cart != null)
            {
                CartListBox.Items.Clear();
                CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
                AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Refreshes the data displayed in the lists on the UI.
        /// </summary>
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(Items.ToArray());

            CustomersComboBox.Items.Clear();
            CustomersComboBox.Items.AddRange(Customers.ToArray());
            
            if (_currentCustomer != null)
            {
                CustomersComboBox.SelectedItem = _currentCustomer;
            }
        }

        /// <summary>
        /// Updates the DiscountsCheckedListBox to reflect the discounts associated with the current customer.
        /// Disables the listbox if there are no customers or no current customer is selected.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            if (Customers.Count == 0 || _currentCustomer == null)
            {
                DiscountsCheckedListBox.Items.Clear();
                DiscountsCheckedListBox.Enabled = false;
                return;
            }

            DiscountsCheckedListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info);
            }

            
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }

            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            DiscountsCheckedListBox.Enabled = true;
            DiscountLabel.Text = "0";
            TotalLabel.Text = AmountLabel.Text;
        }

        /// <summary>
        /// Updates the amount labels (AmountLabel, DiscountLabel, TotalLabel) based on the checked discounts.
        /// Calculates the total discount and updates the UI accordingly.
        /// </summary>
        private void UpdateAmountLabels()
        {
            Discount = 0.0;

            foreach (var item in DiscountsCheckedListBox.CheckedItems)
            {
                var index = DiscountsCheckedListBox.Items.IndexOf(item);
                //Calculates discount for checked items
                Discount += _currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }

            var amount = _currentCustomer.Cart.Amount;
            AmountLabel.Text = amount.ToString();
            DiscountLabel.Text = Discount.ToString();
            TotalLabel.Text = (amount - Discount).ToString();
        }

        /// <summary>
        /// Applies and updates the discounts for the current customer based on the checked items in the listbox.
        /// </summary>
        /// <param name="items">The list of items in the customer's cart.</param>
        private void UpdateCustomerDiscounts(List<Item> items)
        {
            foreach (var discount in _currentCustomer.Discounts)
            {
                if (DiscountsCheckedListBox.CheckedItems.Contains(discount.Info))
                {
                    discount.Apply(items);
                }

                discount.Update(items);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CustomersComboBox control.
        /// Updates the cart information when a customer is selected.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                UpdateInfo();
                UpdateDiscountsCheckedListBox();
                UpdateAmountLabels();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Handles the Click event of the AddToCartButton control.
        /// Adds the selected item to the current customer's cart.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && ItemsListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                UpdateInfo();
                UpdateAmountLabels();
            }
        }

        /// <summary>
        /// Handles the Click event of the RemoveItemButton control.
        /// Removes the selected item from the current customer's cart.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null && CartListBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Remove((Item)CartListBox.SelectedItem);
                UpdateInfo();
            }
        }

        /// <summary>
        /// Handles the Click event of the ClearCartButton control.
        /// Clears the current customer's cart.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                UpdateInfo();
            }
        }

        /// <summary>
        /// Handles the Click event of the CreateButton control.
        /// Creates a new order from the current customer's cart.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CartListBox.Items.Count == 0)
            {
                return;
            }

            Order order;
            if (_currentCustomer.IsPriority)
            {
                order = new PriorityOrder(
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    _currentCustomer.Address, 
                    Discount
                    );
            }
            else
            {
                order = new Order(
                    new List<Item>(_currentCustomer.Cart.Items),
                    _currentCustomer.Cart.Amount,
                    _currentCustomer.Address,
                    Discount);
            }

            _currentCustomer.Orders.Add(order);
            UpdateCustomerDiscounts(_currentCustomer.Cart.Items);
            _currentCustomer.Cart.Items.Clear();
            UpdateInfo();
            UpdateDiscountsCheckedListBox();
            UpdateAmountLabels();
        }

        /// <summary>
        /// Handles discount switch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAmountLabels();
        }
    }
}
