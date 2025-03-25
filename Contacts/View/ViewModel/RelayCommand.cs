using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Class that used for any ICommand realization
    /// </summary>
    class RelayCommand : ICommand
    {
        /// <summary>
        /// Command for excecuting.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Condition of excecuting.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="execute">Condition of excecuting.</param>
        /// <param name="canExecute">Condition of excecuting.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Check if condition in <see cref="_canExecute"/> changed.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Can be excecuted?
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Excecute command.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
