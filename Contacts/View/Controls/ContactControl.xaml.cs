using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check is input correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            var newText = textBox.Text.Insert(textBox.CaretIndex, e.Text);
            if (!Model.Contact.PhoneMask.IsMatch(newText))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Check is paste correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumber_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (!e.DataObject.GetDataPresent(typeof(string)))
            {
                e.CancelCommand();
                return;
            }

            var text = (string)e.DataObject.GetData(typeof(string));
            if (!Model.Contact.PhoneRegex.IsMatch(text))
            {
                e.CancelCommand();
            }
        }
    }
}
