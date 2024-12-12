using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    public partial class ItemsTab : UserControl
    {
        private Item _currentItem;
        internal List<Item> Items { get; set; }

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();
            if (Items.Count > 1)
            {
                Items.Sort();
            }
            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item);
            }
            if (_currentItem != null)
            {
                ItemsListBox.SelectedItem = _currentItem;
            }
            else
            {
                DisableInputs();
            }
        }

        private void DisableInputs()
        {
            CostTextBox.Enabled = false;
            NameRichTextBox.Enabled = false;
            InfoRichTextBox.Enabled = false;
            CategoryComboBox.Enabled = false;
        }

        private void EnableInputs()
        {
            CostTextBox.Enabled = true;
            NameRichTextBox.Enabled = true;
            InfoRichTextBox.Enabled = true;
            CategoryComboBox.Enabled = true;
        }

        private void ItemsLlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem = Items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
            CategoryComboBox.Text = _currentItem.Category.ToString();
            EnableInputs();
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
                }
                catch (ArgumentException err)
                {
                    CostTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && CostTextBox.Text == "")
            {
                CostTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CostTextBox.BackColor = Color.White;
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
                }
                catch (ArgumentException err)
                {
                    NameRichTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && NameRichTextBox.Text == "")
            {
                NameRichTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NameRichTextBox.BackColor = Color.White;
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
                }
                catch (ArgumentException err)
                {
                    InfoRichTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && InfoRichTextBox.Text == "")
            {
                InfoRichTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InfoRichTextBox.BackColor = Color.White;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item(" ", " ", 0.0, Category.Frozen));
            UpdateListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_currentItem);
            UpdateListBox();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            DisableInputs();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}