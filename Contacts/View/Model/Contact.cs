using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Represents a person contact.
    /// </summary>
    internal class Contact : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// SelectedContact`s name.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// SelectedContact`s Phone number.
        /// </summary>
        public string Phone { get; set; } = "";

        /// <summary>
        /// SelectedContact`s email address.
        /// </summary>
        public string Email { get; set; } = "";

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

        public object Clone()
        {
            return new Contact(Name, Phone, Email);
        }
    }
}
