using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    public partial class CustomersTab : UserControl
    {
        private Customer _currentCustomer;

        internal List<Customer> Customers { get; set; }

        public CustomersTab()
        {
            InitializeComponent();
        }

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

        private void DisableInputs()
        {
            NameTextBox.Enabled = false;
        }

        private void EnableInputs()
        {
            NameTextBox.Enabled = true;
        }

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
        }

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customers.Add(new Customer(" ", new Address()));
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Customers.Remove(_currentCustomer);
            UpdateListBox();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            DisableInputs();
        }
    }
}
