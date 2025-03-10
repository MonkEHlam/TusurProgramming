using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Current contact.
        /// </summary>
        private Contact _contact;
        
        /// <summary>
        /// Contact`s name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Contact`s email address.
        /// </summary>
        private string _email;

        /// <summary>
        /// Contact`s Phone number.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Contact`s name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Contact`s email address.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value; 
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Contact`s Phone number.
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event that invoke on property value changing.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
