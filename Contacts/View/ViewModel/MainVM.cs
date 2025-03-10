using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        private Contact _contact;
        
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        
        /// <summary>
        /// 
        /// </summary>
        private string _email;
        
        /// <summary>
        /// 
        /// </summary>
        private string _phone;

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value; 
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
