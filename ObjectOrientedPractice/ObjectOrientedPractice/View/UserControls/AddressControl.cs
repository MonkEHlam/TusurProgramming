using ObjectOrientedPractice.Model;
using ObjectOrientedPractice.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            IndexTextBox.BackColor = Color.White;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the CountryTextBox. 
        /// </summary>
        /// <param name="sender">The CountryTextBox.</param>
        /// <param name="e">Key press event arguments.</param>
        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CountryTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the CityTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The CityTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CityTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the StreetTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The StreetTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            StreetTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles KeyPress event for the ApartamentTextBox.  Allows letters, whitespace, and control characters.
        /// </summary>
        /// <param name="sender">The ApartamentTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void ApartamentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ApartamentTextBox.BackColor = Color.White;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles KeyPress events for the BuildingTextBox, validating input and updating the address.
        /// </summary>
        /// <param name="sender">The BuildingTextBox.</param>
        /// <param name="e">KeyPress event arguments.</param>
        private void BuildingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuildingTextBox.BackColor = Color.White;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleIntInput<Address>((obj, value) => obj.Index = value,
                                                    UpdateControl,IndexTextBox, currentAddress);
        }

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Address>((obj, value) => obj.Country = value,
                                                    UpdateControl, CountryTextBox, currentAddress);
        }

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Address>((obj, value) => obj.City = value,
                                                    UpdateControl, CityTextBox, currentAddress);
        }

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Address>((obj, value) => obj.Street = value,
                                                    UpdateControl, StreetTextBox, currentAddress);
        }

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Address>((obj, value) => obj.Building = value,
                                                    UpdateControl, BuildingTextBox, currentAddress);
        }

        /// <summary>
        /// Tries to update value on focus leave from textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartamentTextBox_Leave(object sender, EventArgs e)
        {
            UserInputHadler.HandleStringInput<Address>((obj, value) => obj.Apartment = value,
                                                    UpdateControl, ApartamentTextBox, currentAddress);
        }
    }
}
