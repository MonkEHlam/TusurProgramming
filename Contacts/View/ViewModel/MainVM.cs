using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Basic ViewModel class
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Command for data saving.
        /// </summary>
        public ICommand SaveCommand { get; set; }

        /// <summary>
        /// Command for data uploading.
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Current contact.
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        /// Contact`s name.
        /// </summary>
        public string Name
        {
            get { return Contact.Name; }
            set
            {
                Contact.Name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Contact`s email address.
        /// </summary>
        public string Email
        {
            get { return Contact.Email; }
            set
            {
                Contact.Email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Contact`s Phone number.
        /// </summary>
        public string Phone
        {
            get { return Contact.Phone; }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public MainVM()
        {
            Contact = new Contact();

            ContactSerializer contactSerializer = new ContactSerializer();
            LoadCommand = new LoadCommand(contactSerializer, Update);
            SaveCommand = new SaveCommand(contactSerializer);
        }

        /// <summary>
        /// Event that invoke on property value changing.
        /// </summary>
        /// <param name="propertyName">Name of changing properety</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Updates fields of contact.
        /// </summary>
        /// <param name="contact">Contact, according to which fields changes.</param>
        public void Update(Contact contact)
        {
            Email = contact.Email;
            Phone = contact.Phone;
            Name = contact.Name;
        }
    }
}

