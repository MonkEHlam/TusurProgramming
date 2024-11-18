using System;
using ObjectOrientedPractice.Model;
using System.Windows.Forms;
using System.Drawing;

namespace ObjectOrientedPractice.View.Controls
{
    /// <summary>
    /// User control for displaying and editing address information.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// The address currently being displayed and edited.
        /// </summary>
        internal Address currentAddress;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressControl"/> class.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the address control with data from the currentAddress property.
        /// </summary>
        public void UpdateControl()
        {
            if (currentAddress == null)
            {
                DisableInput();
                return;
            }
            IndexTextBox.Text = currentAddress.Index.ToString();
            CityTextBox.Text = currentAddress.City;
            CountryTextBox.Text = currentAddress.Country;
            StreetTextBox.Text = currentAddress.Street;
            BuildingTextBox.Text = currentAddress.Building;
            ApartamentTextBox.Text = currentAddress.Apartment;
            EnableInput();
        }

        /// <summary>
        /// Disables all input fields in the address control.
        /// </summary>
        public void DisableInput()
        {
            IndexTextBox.Enabled = false;
            CityTextBox.Enabled = false;
            CountryTextBox.Enabled = false;
            StreetTextBox.Enabled = false;
            BuildingTextBox.Enabled = false;
            ApartamentTextBox.Enabled = false;
        }

        /// <summary>
        /// Enables all input fields in the address control.
        /// </summary>
        public void EnableInput()
        {
            IndexTextBox.Enabled = true;
            CityTextBox.Enabled = true;
            CountryTextBox.Enabled = true;
            StreetTextBox.Enabled = true;
            BuildingTextBox.Enabled = true;
            ApartamentTextBox.Enabled = true;
        }

        /// <summary>
        /// Handles KeyPress events for the IndexTextBox.
        /// </summary>
        /// <param name="sender">The IndexTextBox.</param>
        /// <param name="e">Key press event arguments.</param>
        private void IndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && IndexTextBox.Text != "") 
            {
                try
                {
                    currentAddress.Index = int.Parse(IndexTextBox.Text);
                }
                catch (ArgumentException err)
                {
                    IndexTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && IndexTextBox.Text == "") 
            {
                IndexTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter postal index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IndexTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the CountryTextBox. 
        /// </summary>
        /// <param name="sender">The CountryTextBox.</param>
        /// <param name="e">Key press event arguments.</param>
        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && CountryTextBox.Text != "")
            {
                try
                {
                    var text = CountryTextBox.Text.Replace(".", ",");
                    currentAddress.Country = text;
                }
                catch (ArgumentException err)
                {
                    CountryTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && CountryTextBox.Text == "")
            {
                CountryTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CountryTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the CityTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The CityTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && CityTextBox.Text != "")
            {
                try
                {
                    var text = CityTextBox.Text.Replace(".", ",");
                    currentAddress.City = text;
                }
                catch (ArgumentException err)
                {
                    CityTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && CityTextBox.Text == "")
            {
                CityTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CityTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the StreetTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The StreetTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && StreetTextBox.Text != "")
            {
                try
                {
                    var text = StreetTextBox.Text.Replace(".", ",");
                    currentAddress.Street = text;
                }
                catch (ArgumentException err)
                {
                    StreetTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && StreetTextBox.Text == "")
            {
                StreetTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter street.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreetTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles KeyPress event for the ApartamentTextBox.  Allows letters, whitespace, and control characters.
        /// </summary>
        /// <param name="sender">The ApartamentTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void ApartamentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && ApartamentTextBox.Text != "") 
            {
                try
                {
                    var text = ApartamentTextBox.Text.Replace(".", ",");
                    currentAddress.Apartment = text;
                }
                catch (ArgumentException err)
                {
                    ApartamentTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && ApartamentTextBox.Text == "")
            {
                ApartamentTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter apartment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ApartamentTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the BuildingTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The BuildingTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void BuildingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && BuildingTextBox.Text != "")
            {
                try
                {
                    var text = BuildingTextBox.Text.Replace(".", ",");
                    currentAddress.Building = text;
                }
                catch (ArgumentException err)
                {
                    BuildingTextBox.BackColor = Color.Red;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyChar == (char)13 && BuildingTextBox.Text == "")
            {
                BuildingTextBox.BackColor = Color.Red;
                MessageBox.Show("Enter building.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BuildingTextBox.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Handles the Load event for the AddressControl. Disables input fields on load.
        /// </summary>
        /// <param name="sender">The AddressControl itself.</param>
        /// <param name="e">Event arguments.</param>
        private void AddressControl_Load(object sender, EventArgs e)
        {
            DisableInput();
        }   
    }
}
