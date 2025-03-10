using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Represents a person contact.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Contact`s name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contact`s Phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Contact`s email address.
        /// </summary>
        public string Email { get; set; }

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
    }
}
