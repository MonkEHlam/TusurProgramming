using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
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
        #region Fields

        /// <summary>
        /// De|sereliazation service entity.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Collection of contacts.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Current contact.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Represents visibility of apply changes button.
        /// </summary>
        private Visibility _applyButtonVisibility = Visibility.Collapsed;

        /// <summary>
        /// Is contact readonly
        /// </summary>
        private bool _isReadOnly = true;

        /// <summary>
        /// Is contact adding now.
        /// </summary>
        private bool _isAdding;

        /// <summary>
        /// Is contact editing now.
        /// </summary>
        private bool _isEditing;

        #endregion
        #region Properties

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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// List of all saved contacts.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; private set; }

        /// <summary>
        /// Selected contact for changing.
        /// </summary>
        public Contact SelectedContact { get; set; }

        /// <summary>
        /// Is some contact is selected in listbox.
        /// </summary>
        public bool IsContactSelected
        {
            get
            {
                return SelectedContact != null;
            }
        }

        /// <summary>
        /// Represents visibility of apply changes button.
        /// </summary>
        public Visibility ApplyButtonVisibility { get; set; } = Visibility.Hidden;


        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                if (_isReadOnly != value)
                {
                    _isReadOnly = value;
                    OnPropertyChanged("isReadOnly");
                }
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Command for data saving.
        /// </summary>
        public ICommand SaveCommand { get; set; }

        /// <summary>
        /// Command for data uploading.
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Command for handling apply button.
        /// </summary>
        public ICommand ApplyCommand { get; set; }

        /// <summary>
        /// Command for handling edit button.
        /// </summary>
        public ICommand EditCommand { get; set; }

        /// <summary>
        /// Command for handling add button.
        /// </summary>
        public ICommand AddCommand { get; set; }

        /// <summary>
        /// Command for handling remove button.
        /// </summary>
        public ICommand RemoveCommand { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Class constructor.
        /// </summary>
        public MainVM()
        {
            Contact = new Contact();
            _serializer = new ContactSerializer();
            LoadCommand = new RelayCommand(Load);
            SaveCommand = new RelayCommand(Save);
        }

        #endregion

        #region Events

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

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

        /// <summary>
        ///
        /// </summary>
        /// <param name="contacts"></param>
        public void GetContacts(ObservableCollection<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
        }

        /// <summary>
        /// Saves the data when the application is closing.
        /// </summary>
        public void SaveOnApplicationClose()
        {
            SaveCommand.Execute(Contacts);
        }

        /// <summary>
        /// Loads the data when the application is starting.
        /// </summary>
        public void LoadOnApplicationStart()
        {
            LoadCommand.Execute(null);
        }

        #endregion

        #region Private Methods (Command implementations)

        /// <summary>
        ///  Saves contact data.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        private void Save(object parameter)
        {
            var contacts = (ObservableCollection<Contact>)parameter;
            if (contacts.Count == 0) { return; }

            var answer = _serializer.Serialize(contacts);
            if (answer)
            {
                MessageBox.Show("File succsesfully saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Error on content saving!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Loads contact data.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        private void Load(object parameter)
        {
            Contacts = _serializer.Deserialize();
        }

        #endregion
    }
}
