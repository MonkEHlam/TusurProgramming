using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    public partial class CustomersTab : UserControl
    {
        private readonly List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private bool isDataSaved;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();
            if (_customers.Count > 1)
            {
                _customers.Sort();
            }

            foreach (var item in _customers)
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
            AddressRichTextBox.Enabled = false;
            NameTextBox.Enabled = false;
        }

        private void EnableInputs()
        {
            AddressRichTextBox.Enabled = true;
            NameTextBox.Enabled = true;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            NameTextBox.Text = _currentCustomer.Name;
            AddressRichTextBox.Text = _currentCustomer.Address;
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
                    isDataSaved = false;
                }
                catch (ArgumentException err)
                {
                    NameTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && AddressRichTextBox.Text == "")
            {
                NameTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        private void AddressRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && AddressRichTextBox.Text != "")
            {
                try
                {
                    _currentCustomer.Address = AddressRichTextBox.Text;
                    UpdateListBox();
                    isDataSaved = false;
                }
                catch (ArgumentException err)
                {
                    AddressRichTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && AddressRichTextBox.Text == "")
            {
                AddressRichTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddressRichTextBox.BackColor = Color.White;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer(" ", " "));
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            UpdateListBox();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            DisableInputs();
        }
    }
}
