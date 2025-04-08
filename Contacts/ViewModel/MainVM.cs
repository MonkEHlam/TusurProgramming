using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// Basic ViewModel class
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        #region Fields

        /// <summary>
        /// De|sereliazation service entity.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Collection of contacts.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts = [];

        /// <summary>
        /// Current contact.
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsContactSelected))]
        private Contact _selectedContact;

        /// <summary>
        /// Represents visibility of apply changes button.
        /// </summary>
        [ObservableProperty]
        private Visibility _applyButtonVisibility = Visibility.Hidden;

        /// <summary>
        /// Is contact readonly
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Is contact adding now.
        /// </summary>
        private bool _isAdding;

        /// <summary>
        /// Is contact editing now.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Index of selected contact before any change.
        /// </summary>
        private int _indexBefore;

        #endregion

        /// <summary>
        /// Is some contact selected
        /// </summary>
        public bool IsContactSelected
        {
            get
            {
                return (SelectedContact != null);
            }
        }

        #region Constructors

        /// <summary>
        /// Class constructor.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves the data when the application is closing.
        /// </summary>
        public void SaveOnApplicationClose()
        {
            SaveCommand.Execute(this);
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
        [RelayCommand]
        private void Save(object parameter)
        {
            var answer = _serializer.Serialize(Contacts);
        }

        /// <summary>
        /// Loads contact data.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        [RelayCommand]
        private void Load(object parameter)
        {
            Contacts = _serializer.Deserialize();
        }

        /// <summary>
        /// Activate adding mode.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand]
        private void Add(object parameter)
        {
            SelectedContact = new Contact();
            IsReadOnly = false;
            _isAdding = true;
            ApplyButtonVisibility = Visibility.Visible;
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Remove Selected contact and change selected contact by index in accordance with lab text.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        private void Remove(object parameter)
        {
            if (SelectedContact != null)
            {
                _indexBefore = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    if (_indexBefore < Contacts.Count)
                    {
                        SelectedContact = Contacts[_indexBefore];
                    }
                    else
                    {
                        SelectedContact = Contacts[^1];
                    }
                }

                else
                {
                    SelectedContact = null;
                }
            }
        }

        /// <summary>
        /// Activates editing mode.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        private void Edit(object parameter)
        {
            _indexBefore = Contacts.IndexOf(SelectedContact);
            SelectedContact = (Contact)SelectedContact.Clone();
            IsReadOnly = false;
            _isEditing = true;
            ApplyButtonVisibility = Visibility.Visible;
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Applies changes. Add contact into collection or confirm changes.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand]
        private void Apply(object parameter)
        {
            if (SelectedContact != null)
            {
                if (_isAdding)
                {
                    Contacts.Add(SelectedContact);
                    _isAdding = false;
                }
                if (_isEditing)
                {
                    Contacts[_indexBefore] = SelectedContact;
                    _isEditing = false;
                }

                ApplyButtonVisibility = Visibility.Hidden;
                IsReadOnly = true;
                if (_indexBefore >= 0)
                {
                    SelectedContact = Contacts[_indexBefore];
                }
            }
        }

        /// <summary>
        /// Checks can remove and edit command be used.
        /// </summary>
        private bool CanEditOrRemoveContact()
        {
            return SelectedContact != null && Contacts.Count > 0 && IsReadOnly && !_isEditing && !_isAdding;
        }

        /// <summary>
        /// Invokes when selected contact changes and deactivate editing and adding modes.
        /// </summary>
        /// <param name="value"></param>
        partial void OnSelectedContactChanged(Contact value)
        {
            _isAdding = false;
            _isEditing = false;
            IsReadOnly = true;
            ApplyButtonVisibility = Visibility.Hidden;
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }
        #endregion
    }
}
