using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Model.Discounts;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractice.View.UserControls
{
    public partial class DiscountPopUp : Form
    {
        public Category Category { get; set; }
        private Customer Customer { get; }

        internal DiscountPopUp(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            UpdateCategoryComboBox();
        }

        private void UpdateCategoryComboBox()
        {
            var customerCategories = new List<Category>();
            foreach (var discount in Customer.Discounts)
            {
                if (discount is PercentDiscount)
                {
                    var percentDiscount = discount as PercentDiscount;
                    customerCategories.Add(percentDiscount.Category);
                }
            }

            var dataCategories = new List<Category>();
            foreach (var category in Enum.GetValues(typeof(Category)).Cast<Category>().ToList())
            {
                if (!customerCategories.Contains(category))
                {
                    dataCategories.Add(category);
                }
            }

            CategoryComboBox.DataSource = dataCategories;
        }
        private void DiscountPopUp_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Category = (Category)Enum.Parse(
                typeof(Category),
                CategoryComboBox.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = CategoryComboBox.SelectedIndex >= 0;
        }
    }
}
