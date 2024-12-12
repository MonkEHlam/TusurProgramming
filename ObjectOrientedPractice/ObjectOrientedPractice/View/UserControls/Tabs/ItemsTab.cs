using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
using ObjectOrientedPractice.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    public partial class ItemsTab : UserControl
    {
        private Item _currentItem;

        internal List<Item> Items { get; set; } =null;

        internal List<Item> DisplayItems { get; set; } = null;

        private Func<Item, Item, bool> Sorter { get; set; } = (x, y) => 
                        {   
                            int res = String.Compare(x.Name, y.Name);
                            return res > 0; 
                        };

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();

            if (Items == null || DisplayItems == null)
            {
                return;
            }

            if (FilterTextBox.Text == string.Empty)
            {
                DisplayItems = Items;
            }

            if (DisplayItems.Count > 1)
            {
                DisplayItems = DataTools.SortItems(DisplayItems, Sorter);
            }

            foreach (var item in DisplayItems)
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
            CostTextBox.Text = string.Empty;
            CostTextBox.Enabled = false;

            NameRichTextBox.Text = string.Empty;
            NameRichTextBox.Enabled = false;

            InfoRichTextBox.Text = string.Empty;
            InfoRichTextBox.Enabled = false;

            CategoryComboBox.Text = string.Empty;
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
            _currentItem = (Item)ItemsListBox.SelectedItem;
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            InfoRichTextBox.Text = _currentItem.Info;
            CategoryComboBox.Text = _currentItem.Category.ToString();
            EnableInputs();
        }

        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CostTextBox.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)46) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NameRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NameRichTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InfoRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InfoRichTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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
            SortComboBox.SelectedIndex = 0;
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

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleDoubleInput((obj, value) => obj.Cost = value,
                                        UpdateListBox, CostTextBox, _currentItem);
        }

        private void NameRichTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Item>((obj, value) => obj.Name = value,
                                        UpdateListBox, NameRichTextBox, _currentItem);
        }

        private void InfoRichTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Item>((obj, value) => obj.Info = value,
                                        UpdateListBox, InfoRichTextBox, _currentItem);
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = FilterTextBox.Text.Trim();
            if (text == string.Empty)
            {
                DisplayItems = Items;
                UpdateListBox();
                return;
            }
            DisplayItems = DataTools.FilterItems(Items, x => x.Name.Contains(text));
            _currentItem = null;
            UpdateListBox();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    {
                        Sorter = (x, y) => 
                        {   int res = String.Compare(x.Name, y.Name);
                            return res > 0; 
                        };
                        break;
                    }
                case 1:
                    {
                        Sorter = (x, y) => x.Cost > y.Cost;
                        break;
                    }
                case 2:
                    {
                        Sorter = (x, y) => x.Cost < y.Cost;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            _currentItem = null;
            UpdateListBox();
        }
    }
}