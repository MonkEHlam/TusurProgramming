using ObjectOrientedPractice.Services;
using ObjectOrientedPractice.Model.Enums;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ObjectOrientedPractice.Model
{
    /// <summary>
    /// Represents an item in store.
    /// </summary>
    internal class Item : IComparable<Item>, IEquatable<Item>, ICloneable
    {
        /// <summary>
        /// Item`s id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Item`s name.
        /// </summary>
        private string _name;

        /// <summary>
        /// Item`s info.
        /// </summary>
        private string _info;

        /// <summary>
        /// Item`s cost.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Gets the unique ID of the item.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value && Validator.AssertLengthOfString(value, 1000, "item name"))
                {
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                if (_info != value && Validator.AssertLengthOfString(value, 200, "item descriprion"))
                {
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                    _info = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the cost of the item.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (_cost != value && Validator.AssertRange(value, 0, 100000, "item cost"))
                {
                    CostChanged?.Invoke(this, EventArgs.Empty);
                    _cost = value;
                }
            }
        }

        /// <summary>
        /// Item <see cref="Model.Enums.Category"/>.
        /// </summary>
        public Category Category { get; set; }

        public EventHandler<EventArgs> NameChanged;

        public EventHandler<EventArgs> InfoChanged;

        public EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="name">Item`s name.</param>.
        /// <param name="info">Item`s description.</param>.
        /// <param name="cost">item`s cost</param>.
        /// <param name="category">Item`s category</param>.
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.NextItemId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="compareItem"><see cref="Item" /> for compare.</param>
        /// <returns><inheritdoc/></returns>
        public int CompareTo(Item compareItem)
        {
            if (compareItem == null)
                return 1;

            return Cost.CompareTo(compareItem.Cost);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public bool Equals(Item other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// Clone object.
        /// </summary>
        /// <returns>Clone of Item.</returns>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <summary>
        /// String view of class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tempName = Name;
            if (tempName == "")
            {
                tempName = "---";
            }
            return $"{Id}, {tempName}, {Cost}";
        }
    }
}
