using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Discounts;
using ObjectOrientedPractice.View.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    /// <summary>
    /// User control for managing and displaying customers.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Currently selected customer.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// List of customers managed by this control.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersTab"/> class.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the CustomersListBox with the current list of Customers. 
        /// Sorts the list if it contains more than one customer.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            if (Customers.Count > 1)
            {
                Customers.Sort();
            }

            foreach (var item in Customers)
            {
                CustomersListBox.Items.Add(item);
            }

            if (_currentCustomer != null)
            {
                CustomersListBox.SelectedItem = _currentCustomer;
            }
            else
            {
                DisableInputs();
            }
        }

        /// <summary>
        /// Updates listbox.
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            DiscountListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Disables the input fields for editing customer details.
        /// </summary>
        private void DisableInputs()
        {
            NameTextBox.Enabled = false;
            PrioriyCheckBox.Enabled = false;
        }

        /// <summary>
        /// Enables the input fields for editing customer details.
        /// </summary>
        private void EnableInputs()
        {
            NameTextBox.Enabled = true;
            PrioriyCheckBox.Enabled = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CustomersListBox.
        /// Populates the form fields with data from the selected customer.
        /// </summary>
        /// <param name="sender">The sender object (CustomersListBox).</param>
        /// <param name="e">Event arguments.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.Name;
            AddressControl.currentAddress = _currentCustomer.Address;
            AddressControl.UpdateControl();
            EnableInputs();
            UpdateDiscountsListBox();
        }

        /// <summary>
        /// Handles the KeyPress event of the NameTextBox.
        /// </summary>
        /// <param name="sender">The sender object (NameTextBox).</param>
        /// <param name="e">Event arguments.</param>
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && NameTextBox.Text != "")
            {
                try
                {
                    var text = NameTextBox.Text.Replace(".", ",");
                    _currentCustomer.Name = text;
                    UpdateListBox();
                }
                catch (ArgumentException err)
                {
                    NameTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && NameTextBox.Text == "")
            {
                NameTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles the Click event of the AddButton. Adds a new customer to the list.
        /// </summary>
        /// <param name="sender">The sender object (AddButton).</param>
        /// <param name="e">Event arguments.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customers.Add(new Customer(""));
            UpdateListBox();
        }

        /// <summary>
        /// Handles the Click event of the RemoveButton. Removes the selected customer from the list.
        /// </summary>
        /// <param name="sender">The sender object (RemoveButton).</param>
        /// <param name="e">Event arguments.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Customers.Remove(_currentCustomer);
            UpdateListBox();
        }

        /// <summary>
        /// Handles the Load event of the CustomersTab. Disables input fields on load.
        /// </summary>
        /// <param name="sender">The sender object (CustomersTab).</param>
        /// <param name="e">Event arguments.</param>
        private void CustomersTab_Load(object sender, EventArgs e)
        {
            DisableInputs();
        }

        /// <summary>
        /// Handle changing in PriorityCheckBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = PrioriyCheckBox.Checked;
        }

        /// <summary>
        /// Handles click on AddDiscountButton.
        /// Shows <see cref="DiscountPopUp"/> and gets choosed category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            var discountPopUp = new DiscountPopUp(_currentCustomer);

            if (discountPopUp.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var discount = new PercentDiscount(discountPopUp.Category);
            _currentCustomer.Discounts.Add(discount);
            UpdateDiscountsListBox();
        }

        /// <summary>
        /// Enable RemoveButton if smth choosed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveDiscountButton.Enabled = DiscountListBox.SelectedIndex > 0;
        }

        /// <summary>
        /// Handles click on RemoveDiscountButton.
        /// Remove Discount from <see cref="Customer.Discounts">customer discount list</see>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            var removedIndex = DiscountListBox.SelectedIndex;
            _currentCustomer.Discounts.RemoveAt(
                DiscountListBox.SelectedIndex);
            UpdateDiscountsListBox();

            if (removedIndex >= DiscountListBox.Items.Count)
            {
                DiscountListBox.SelectedIndex = removedIndex - 1;
            }
            else
            {
                DiscountListBox.SelectedIndex = removedIndex;
            }
        }
    }
}
