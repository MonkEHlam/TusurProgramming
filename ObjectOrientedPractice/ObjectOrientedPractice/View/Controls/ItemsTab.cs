﻿using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    public partial class ItemsTab : UserControl
    {
        private readonly List<Item> _items = new List<Item>();
        private Item _currentItem;
        private bool isDataSaved;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            if (_items.Count > 1)
                _items.Sort();
            foreach (var item in _items) ItemsListBox.Items.Add(item);
            if (_currentItem != null)
                ItemsListBox.SelectedItem = _currentItem;
        }

        private void ItemsLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)46) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && CostTextBox.Text != "")
            {
                try
                {
                    var text = CostTextBox.Text.Replace(".", ",");
                    _currentItem.Cost = double.Parse(text);
                    UpdateListBox();
                    isDataSaved = false;
                }
                catch (ArgumentException err)
                {
                    CostTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NameRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && NameRichTextBox.Text != "")
            {
                try
                {
                    _currentItem.Name = NameRichTextBox.Text;
                    UpdateListBox();
                    isDataSaved = false;
                }
                catch (ArgumentException err)
                {
                    NameRichTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InfoRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && InfoRichTextBox.Text != "")
            {
                try
                {
                    _currentItem.Info = InfoRichTextBox.Text;
                    UpdateListBox();
                    isDataSaved = false;
                }
                catch (ArgumentException err)
                {
                    InfoRichTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item(" ", " ", 0.0));
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            UpdateListBox();
        }
    }
}