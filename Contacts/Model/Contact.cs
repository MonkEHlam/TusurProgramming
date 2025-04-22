using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Represents a person contact.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private string _name;
        private string _email;
        private string _phone;
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

        /// <summary>
        /// Max length of contact's name.
        /// </summary>
        private const int MaxNameLength = 100;

        /// <summary>
        /// Max length of phone number.
        /// </summary>
        private const int MaxPhoneNumberLength = 100;

        /// <summary>
        /// Max length of email.
        /// </summary>
        private const int MaxEmailLength = 100;

        /// <summary>
        /// Regular expression for phone mask.
        /// </summary>
        public static readonly Regex PhoneMask = new Regex(@"^[0-9+() -]*$");

        /// <summary>
        /// Regular expression for phone validation.
        /// </summary>
        public static readonly Regex PhoneRegex =
            new Regex(@"^\+?(\d{1,3})?[-. (]*(\d{1,4})[-. )]*(\d{1,4})[-. ]*(\d{1,9})$");

        /// <summary>
        /// Regular expression for email validation.
        /// </summary>
        public static readonly Regex EmailRegex =
            new Regex(@"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$");

        /// <summary>
        /// Contact`s name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    ValidateProperty(nameof(Name), value);
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Contact`s Phone number.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    ValidateProperty(nameof(Phone), value);
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }

        /// <summary>
        /// Contact`s email address.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    ValidateProperty(nameof(Email), value);
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string Error => string.Join("\n", _errors.Values);

        public string this[string columnName] => _errors.TryGetValue(columnName, out var error) ? error : null;

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="name">Contact`s name.</param>
        /// <param name="phone">Contact`s Phone number.</param>
        /// <param name="email">Contact`s email address.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Empty class constructor.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="propertyName">Name of changed properety.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Validates contact properety.
        /// </summary>
        /// <param name="propertyName">Name of property to validate.</param>
        /// <param name="value">Value to approve.</param>
        private void ValidateProperty(string propertyName, string value)
        {
            string error = null;

            switch (propertyName)
            {
                case nameof(Name):
                {
                    if (string.IsNullOrWhiteSpace(value))
                        error = "Empty name.";
                    else if (value.Length > MaxNameLength)
                        error = "Max name length is 100 symbols.";
                    break;
                }

                case nameof(Phone):
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Empty phone number";
                    }
                    else
                    {
                        if (value.Length > MaxPhoneNumberLength)
                            error = "Max phone number length is 100 symbols.";
                        else if (!PhoneRegex.IsMatch(value))
                            error = "Wrong format. Example: +7 (123) 456-7890";
                    }
                    break;
                }

                case nameof(Email):
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Email is empty.";
                    }
                    else
                    {
                        if (value.Length > MaxEmailLength)
                            error = "Max email length is 100 symbols.";
                        else if (!EmailRegex.IsMatch(value))
                            error = "Wrong format. Example: example@domain.com";
                    }
                    break;
                }
            }

            if (error != null)
            {
                _errors[propertyName] = error;
            }
            else
            {
                _errors.Remove(propertyName);
            }
        }

        public object Clone()
        {
            return new Contact(Name, Phone, Email);
        }
    }
}
