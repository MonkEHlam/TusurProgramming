﻿using ObjectOrientedPractice.Model;
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

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
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
            _customers.Add(new Customer(" ", new Address()));
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
