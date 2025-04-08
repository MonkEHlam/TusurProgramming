using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Represents a person contact.
    /// </summary>
    internal class Contact : INotifyPropertyChanged, ICloneable, IDataErrorInfo
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
        public static readonly Regex PhoneNumberMask = new Regex(@"^[0-9+() -]*$");

        /// <summary>
        /// Regular expression for phone validation.
        /// </summary>
        public static readonly Regex PhoneNumberRegex =
            new Regex(@"^\+?(\d{1,3})?[-. (]*(\d{1,4})[-. )]*(\d{1,4})[-. ]*(\d{1,9})$");

        /// <summary>
        /// Regular expression for email validation.
        /// </summary>
        public static readonly Regex EmailRegex =
            new Regex(@"^[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+$");

        /// <summary>
        /// SelectedContact`s name.
        /// </summary>
        /// <summary>
        /// Получает или задает имя контакта.
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
        /// SelectedContact`s Phone number.
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
        /// SelectedContact`s email address.
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
        /// <param name="name">SelectedContact`s name.</param>
        /// <param name="phone">SelectedContact`s Phone number.</param>
        /// <param name="email">SelectedContact`s email address.</param>
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
        /// <param name="propertyName">Name of property to validate</param>
        /// <param name="value"></param>
        private void ValidateProperty(string propertyName, string value)
        {
            string error = null;

            switch (propertyName)
            {
                case nameof(Name):
                    if (string.IsNullOrWhiteSpace(value))
                        error = "Имя не может быть пустым.";
                    else if (value.Length > MaxNameLength)
                        error = "Имя не должно превышать 100 символов.";
                    break;

                case nameof(Phone):
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Номер телефона не может быть пустым.";
                    }
                    else
                    {
                        if (!PhoneNumberMask.IsMatch(value))
                            error = "Номер телефона содержит недопустимые символы.";
                        else if (value.Length > MaxPhoneNumberLength)
                            error = "Номер телефона не должен превышать 100 символов.";
                        else if (!PhoneNumberRegex.IsMatch(value))
                            error = "Номер телефона имеет неверный формат. Пример: +7 (123) 456-7890";
                    }
                    break;

                case nameof(Email):
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        error = "Email не может быть пустым.";
                    }
                    else
                    {
                        if (value.Length > MaxEmailLength)
                            error = "Email не должен превышать 100 символов.";
                        else if (!EmailRegex.IsMatch(value))
                            error = "Email имеет неверный формат. Пример: example@domain.com";
                    }
                    break;
            }

            if (error != null)
                _errors[propertyName] = error;
            else
                _errors.Remove(propertyName);
        }

        public object Clone()
        {
            return new Contact(Name, Phone, Email);
        }
    }
}
