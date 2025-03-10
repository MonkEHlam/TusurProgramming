using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    internal class LoadCommand : ICommand
    {
        /// <summary>
        /// Service class entity for deserialization.
        /// </summary>
        private ContactSerializer _deserializer;

        /// <summary>
        /// View update method.
        /// </summary>
        private Action<Contact> _updater;

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="serializer"><see cref="ContactSerializer"/> entity.</param>
        public LoadCommand(ContactSerializer deserializer, Action<Contact> updater)
        {
            _deserializer = deserializer;
            _updater = updater;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="parameter"><inheritdoc/></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="parameter"><inheritdoc/></param>
        public void Execute(object parameter)
        {
            var contact = _deserializer.Deserialize();
            _updater(contact);
        }
    }
}
