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
        private Visibility _applyButtonVisibility = Visibility.Hidden;

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

        private int _indexBefore;

        #endregion
        
        #region Properties

        /// <summary>
        /// Current contact.
        /// </summary>
        public Contact SelectedContact 
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                if (value != _selectedContact)
                {
                    _selectedContact = value;
                    OnPropertyChanged("SelectedContact");
                }
            }
        }

        /// <summary>
        /// SelectedContact`s name.
        /// </summary>
        public string Name
        {
            get { return SelectedContact.Name; }
            set
            {
                SelectedContact.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// SelectedContact`s email address.
        /// </summary>
        public string Email
        {
            get { return SelectedContact.Email; }
            set
            {
                SelectedContact.Email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// SelectedContact`s Phone number.
        /// </summary>
        public string Phone
        {
            get { return SelectedContact.Phone; }
            set
            {
                SelectedContact.Phone = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// List of all saved contacts.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            private set
            {
                if (value != _contacts)
                {
                    _contacts = value;
                    OnPropertyChanged();
                }
            }
        }

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
        public Visibility ApplyButtonVisibility
        {
            get
            {
                return _applyButtonVisibility;
            }
            set
            {
                if (value != _applyButtonVisibility)
                {
                    _applyButtonVisibility = value;
                    OnPropertyChanged("ApplyButtonvisibility");
                }
            }
        }

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
            SelectedContact = new Contact();
            _serializer = new ContactSerializer();
            LoadCommand = new RelayCommand(Load);
            AddCommand = new RelayCommand(Add);
            ApplyCommand = new RelayCommand(Apply);
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
        public void Update()
        {
            Email = SelectedContact.Email;
            Phone = SelectedContact.Phone;
            Name = SelectedContact.Name;
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
        }

        /// <summary>
        /// Loads contact data.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        private void Load(object parameter)
        {
            Contacts = _serializer.Deserialize();
        }

        private void Add(object parameter)
        {
            _indexBefore = _contacts.IndexOf(SelectedContact);
            SelectedContact = new Contact();
            Update();
            IsReadOnly = false;
            _isAdding = true;
            ApplyButtonVisibility = Visibility.Visible;
        }

        private void Apply(object parameter)
        {
            if (SelectedContact != null)
            {
                if (_isAdding)
                {
                    Contacts.Add(SelectedContact);
                    _isAdding = false;
                }
                if(_isEditing)
                { }

                ApplyButtonVisibility = Visibility.Hidden;
                IsReadOnly = true;
                SelectedContact = Contacts[_indexBefore];
            }   
        }

        #endregion
    }
}
