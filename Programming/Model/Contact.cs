using System;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    internal class Contact
    {
        private string _number = "";
        private string _name;
        public string Name
        {
            get { return _name; }
            set {
                if (AssertStringContainsOnlyLetters(value))
                    _name = value;
                else
                    throw new ArgumentException("Wrong argument format for Name");
            }
        }
        private string _surname = "";
        public string Surname
        {
            get { return _surname; }
            set 
            {
                if (AssertStringContainsOnlyLetters(value))
                    _surname = value;
                else
                    throw new ArgumentException("Wrong argument format for Surame"); 
            }
        }
        private string _email = "";

        public string Number {  get { return _number; } 
            set
            {
                if (new Regex(@"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}").IsMatch(value))
                    _number = value;
                else throw new ArgumentException();
            }
        }

        public string Email { get { return _email; }
            set
            {
               if (new Regex(@"(?=.{1,64}@)[A-Za-z0-9_-]+(\\.[A-Za-z0-9_-]+)
                               *@[^-][A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*(\\.[A-Za-z]{2,})").IsMatch(value))
                    _email = value;
               else throw new ArgumentException();
            }
        }

        public Contact() { }
        public Contact(string name, string number, string email) 
        {
            Name = name;
            Number = number;
            Email = email;
        }

        private bool AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z0-9]*$"))
                return true;
            return false;
        }
    }
}
