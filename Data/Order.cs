using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order : IMenuItem, ICollection<IMenuItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of menu items for the order.
        /// </summary>
        private List<IMenuItem> _order = new List<IMenuItem>();

        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies when a collection of this class changes.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Backing field for sales tax rate.
        /// </summary>
        private decimal _salesTaxRate = 0.09m;

        /// <summary>
        /// The salex tax rate.
        /// </summary>
        public decimal SalesTaxRate
        {
            get
            {
                return _salesTaxRate;
            }
            set
            {
                if (_salesTaxRate != value)
                {
                    _salesTaxRate = value;
                    OnPropertyChanged(nameof(Total));
                }
            }
        }

        /// <summary>
        /// The subtotal price of the order.
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal sum = 0m;
                foreach(IMenuItem item in _order)
                {
                    sum += item.Price;
                }
                return sum;
            }
        }

        /// <summary>
        /// Calories of the item(s) in the order.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IMenuItem item in _order)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// The tax price of the order.
        /// </summary>
        public decimal Tax => Subtotal * SalesTaxRate;

        /// <summary>
        /// The total price of the order.
        /// </summary>
        public decimal Total => Subtotal + Tax;

        /// <summary>
        /// Price of the item in the order.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The Special instructions.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The next order number in the lineup for orders.
        /// </summary>
        private static int _nextOrderNumber = 1;

        /// <summary>
        /// Backing field for number.
        /// </summary>
        private int _number;

        /// <summary>
        /// The order number.
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (_number != value)
                {
                    _number = value;
                    OnPropertyChanged(nameof(Count));
                    OnPropertyChanged(nameof(Subtotal));
                    OnPropertyChanged(nameof(Total));
                    OnPropertyChanged(nameof(SalesTaxRate));
                }
            }
        }

        /// <summary>
        /// Private backing field for the placed at property for the date.
        /// </summary>
        private DateTime _placedAt;

        /// <summary>
        /// The date and time the order was placed at.
        /// </summary>
        public DateTime PlacedAt => _placedAt;

        /// <summary>
        /// The order count.
        /// </summary>
        public int Count => _order.Count;

        /// <summary>
        /// Checks to see if the order is synchronized.
        /// </summary>
        public bool IsSynchronized { get; }

        /// <summary>
        /// Checks to see if the root is in sync.
        /// </summary>
        public object SyncRoot { get; }

        /// <summary>
        /// Checks to see if the order is read only.
        /// </summary>
        public bool IsReadOnly => true;   

        /// <summary>
        /// Constructor for the order class.
        /// </summary>
        public Order()
        {
            Number = _nextOrderNumber;
            _nextOrderNumber++;
            _placedAt = DateTime.Now;
        }

        /// <summary>
        /// Helper method used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that's changing.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Helper method used to trigger a CollectionChanged event.
        /// </summary>
        /// <param name="e">The name of the property that's changing.</param>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            this.CollectionChanged(this, e);
        }

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IMenuItem item)
        {
            _order.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            ((INotifyPropertyChanged)item).PropertyChanged += HelperPropertyChanged;
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Tax));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Calories));
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// Returns true if item is in the list, otherwise false.
        /// </returns>
        public bool Remove(IMenuItem item)
        {
            if (_order.Contains(item))
            {
                int index = _order.IndexOf(item);
                _order.Remove(item);
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                ((INotifyPropertyChanged)item).PropertyChanged += HelperPropertyChanged;
                OnPropertyChanged(nameof(Subtotal));
                OnPropertyChanged(nameof(Tax));
                OnPropertyChanged(nameof(Total));
                OnPropertyChanged(nameof(Calories));
                return true;
            }
            return false;
        }

        /// <summary>
        /// Helper method for the notify property changed event.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event.</param>
        protected virtual void HelperPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Price"))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName.Equals("Calories"))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Clears the data from the order.
        /// </summary>
        public void Clear()
        {
            _order.Clear();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Tax));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Calories));
        }

        /// <summary>
        /// Checks to see if the item is contained.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// Returns true if contains, otherwise false.
        /// </returns>
        public bool Contains(IMenuItem item)
        {
            return _order.Contains(item);
        }

        /// <summary>
        /// Copies the data.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">The index</param>
        public void CopyTo(IMenuItem[] array, int arrayIndex)
        {
            _order.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>
        /// Returns the enumerator.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _order.GetEnumerator();
        }

        
        /// <summary>
        /// Extra GetEnumerator method necessary for the ICollection. NOT USED.
        /// </summary>
        /// <returns>
        /// Returns an enumerator.
        /// </returns>
        public IEnumerator<IMenuItem> GetEnumerator()
        {
            return _order.GetEnumerator();
        }
    }
}
