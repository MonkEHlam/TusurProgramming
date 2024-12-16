using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Enums;
using ObjectOrientedPractice.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.Controls
{
    /// <summary>
    /// User control for managing and displaying a list of items.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Currently selected item.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// The complete list of items.
        /// </summary>
        internal List<Item> Items { get; set; } = null;

        /// <summary>
        /// The subset of items currently displayed (after filtering and sorting).
        /// </summary>
        internal List<Item> DisplayItems { get; set; } = null;

        /// <summary>
        /// Delegate defining the sorting logic for the items.  Defaults to descending sort by name.
        /// </summary>
        private Func<Item, Item, bool> Sorter { get; set; } = (x, y) => String.Compare(x.Name, y.Name) > 0;

        /// <summary>
        /// Event triggered when the items list is modified.
        /// </summary>
        public EventHandler<EventArgs> ItemsChanged;

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes the ItemsListBox with the current DisplayItems, applying sorting if needed.
        /// </summary>
        private void UpdateListBox()
        {
            if (Items == null || DisplayItems == null) return;

            ItemsListBox.Items.Clear();

            if (FilterTextBox.Text == string.Empty)
            {
                DisplayItems = Items;
            }

            if (DisplayItems.Count > 1)
            {
                DisplayItems = DataTools.SortItems(DisplayItems, Sorter);
            }

            ItemsListBox.Items.AddRange(DisplayItems.ToArray());

            if (_currentItem != null)
            {
                ItemsListBox.SelectedItem = _currentItem;
            }
            else
            {
                DisableInputs();
            }
        }

        /// <summary>
        /// Disables input controls.
        /// </summary>
        private void DisableInputs()
        {
            CostTextBox.Enabled = false;

            CostTextBox.Text = string.Empty;
            CostTextBox.Enabled = false;

            NameRichTextBox.Text = string.Empty;
            NameRichTextBox.Enabled = false;

            InfoRichTextBox.Text = string.Empty;
            InfoRichTextBox.Enabled = false;

            CategoryComboBox.Text = string.Empty;
            CategoryComboBox.Enabled = false;
        }

        /// <summary>
        /// Enables input controls.
        /// </summary>
        private void EnableInputs()
        {
            CostTextBox.Enabled = true;
            NameRichTextBox.Enabled = true;
            InfoRichTextBox.Enabled = true;
            CategoryComboBox.Enabled = true;
        }

        /// <summary>
        /// Handles selection changes in ItemsListBox, populating input fields with selected item data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// KeyPress event handler for CostTextBox, allowing only digits and the decimal point.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CostTextBox.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        /// <summary>
        /// KeyPress event handler for NameRichTextBox, allowing alphanumeric characters, punctuation, and whitespace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NameRichTextBox.BackColor = Color.White;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        /// <summary>
        /// KeyPress event handler for InfoRichTextBox, allowing alphanumeric characters, punctuation, and whitespace.
        /// Prevents invalid characters from being entered into the InfoRichTextBox.
        /// </summary>
        /// <param name="sender">The sender object (InfoRichTextBox).</param>
        /// <param name="e">The KeyPressEventArgs.</param>
        private void InfoRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            InfoRichTextBox.BackColor = Color.White;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) &&
                !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
        }

        /// <summary>
        /// Adds a new Item to the Items list with default values, updates the listbox, and raises the ItemsChanged event.
        /// </summary>
        /// <param name="sender">The sender object (AddButton).</param>
        /// <param name="e">The EventArgs.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item(" ", " ", 0.0, Category.Frozen));
            UpdateListBox();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Removes the currently selected Item from the Items list, updates the listbox, and raises the ItemsChanged event.
        /// </summary>
        /// <param name="sender">The sender object (RemoveButton).</param>
        /// <param name="e">The EventArgs.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_currentItem);
            UpdateListBox();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Handles the Load event for the ItemsTab, initializing the control.
        /// Disables inputs, populates the CategoryComboBox, and sets the initial sorting order.
        /// </summary>
        /// <param name="sender">The sender object (ItemsTab).</param>
        /// <param name="e">The EventArgs.</param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            DisableInputs();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
            SortComboBox.SelectedIndex = -1;
        }


        /// <summary>
        /// Handles the SelectedIndexChanged event for the CategoryComboBox, updating the selected item's category.
        /// </summary>
        /// <param name="sender">The sender object (CategoryComboBox).</param>
        /// <param name="e">The EventArgs.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                UpdateListBox(); // Update the listbox after changing the category.
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Leave event for the CostTextBox, validating and updating the item's cost.
        /// </summary>
        /// <param name="sender">The sender object (CostTextBox).</param>
        /// <param name="e">The EventArgs.</param>
        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleDoubleInput((obj, value) => obj.Cost = value, UpdateListBox, CostTextBox, _currentItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Handles the Leave event for the NameRichTextBox, validating and updating the item's name.
        /// </summary>
        /// <param name="sender">The sender object (NameRichTextBox).</param>
        /// <param name="e">The EventArgs.</param>
        private void NameRichTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Item>((obj, value) => obj.Name = value, UpdateListBox, NameRichTextBox, _currentItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Handles the Leave event for the InfoRichTextBox, validating and updating the item's info.
        /// </summary>
        /// <param name="sender">The sender object (InfoRichTextBox).</param>
        /// <param name="e">The EventArgs.</param>
        private void InfoRichTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Item>((obj, value) => obj.Info = value, UpdateListBox, InfoRichTextBox, _currentItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// Handles the TextChanged event for the FilterTextBox, filtering the items displayed in the listbox.
        /// </summary>
        /// <param name="sender">The sender object (FilterTextBox).</param>
        /// <param name="e">The EventArgs.</param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event for the SortComboBox, setting the sorting logic.
        /// </summary>
        /// <param name="sender">The sender object (SortComboBox).</param>
        /// <param name="e">The EventArgs.</param>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    { 
                        Sorter = (x, y) => String.Compare(x.Name, y.Name) < 0;
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