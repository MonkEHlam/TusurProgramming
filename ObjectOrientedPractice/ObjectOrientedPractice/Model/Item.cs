using ObjectOrientedPractice.Services;
using System;

namespace ObjectOrientedPractice.Model
{
    internal class Item: IComparable<Item>, IEquatable<Item>
    {
        /// <summary>
        /// Item`s id
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Item`s name
        /// </summary>
        private string _name;
        /// <summary>
        /// Item`s info
        /// </summary>
        private string _info;
        /// <summary>
        /// Item`s cost
        /// </summary>
        private double _cost;

        public int Id { 
            get { return _id; } 
        }

        public string Name {
            get { return _name; } 
            set 
            { 
                if (Validator.AssertLengthOfString(value, 200, "item name"))
                {
                    _name = value;
                }  
            } 
        }

        public string Info {
            get { return _info; } 
            set 
            {
                if (!Validator.AssertLengthOfString(value, 1000, "item descriprion"))
                {
                    _info = value;
                }
            }
        }

        public double Cost { 
            get { return _cost; } 
            set
            {
                if (Validator.AssertRange(value, 0, 100000, "item cost"))
                {
                    _cost = value;
                }
            } 
        }

        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.NextItemId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Base class comparer
        /// </summary>
        /// <param name="compareItem"><see cref="Item" /> for compare.</param>
        /// <returns>Int compare index of IComparable.</returns>
        public int CompareTo(Item compareItem)
        {
            if (compareItem == null)
                return 1;

            return Id.CompareTo(compareItem.Id);
        }

        /// <summary>
        /// Compairing pair of <see cref="Item" />
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// String view of class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}, {Name}, {Cost}";
        }
    }
}
