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
    internal class SaveCommand : ICommand
    {
        /// <summary>
        /// Service class entity for serialization.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="serializer"><see cref="ContactSerializer"/> entity.</param>
        public SaveCommand(ContactSerializer serializer)
        {
            _serializer = serializer;
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
        /// <param name="parameter">Contact for serialization</param>
        public void Execute(object parameter)
        {
            _serializer.Serialize((Contact)parameter);
        }
    }
}
