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
        private List<IMenuItem> order = new();

        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies when a collection of this class changes.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// The salex tax rate.
        /// </summary>
        public decimal SalesTaxRate { get; set; } = 0.09m;

        /// <summary>
        /// The subtotal price of the order.
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal sum = 0m;
                foreach(IMenuItem item in this)
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
                foreach (IMenuItem item in this)
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
        /// The order number.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The date and time the order was placed at.
        /// </summary>
        public DateTime PlacedAt { get; }

        /// <summary>
        /// The order count.
        /// </summary>
        public int Count => Number;

        /// <summary>
        /// Checks to see if the order is synchronized.
        /// </summary>
        public bool IsSynchronized { get; }

        /// <summary>
        /// Checks to see if the root is in sync.
        /// </summary>
        public object SyncRoot { get; }

        public bool IsReadOnly => true;

        /// <summary>
        /// The next order number in the lineup for orders.
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// Constructor for the order class.
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            PlacedAt = DateTime.Now;
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
        /// <param name="propertyName">The name of the property that's changing.</param>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            this.CollectionChanged(this,e);
        }

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IMenuItem item)
        {
            order.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Tax));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Calories));
        }

        /// <summary>
        /// Removes an item from the order.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        public bool Remove(IMenuItem item)
        {
            if (order.Contains(item))
            {
                int index = order.IndexOf(item);
                order.Remove(item);
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                OnPropertyChanged(nameof(Subtotal));
                OnPropertyChanged(nameof(Tax));
                OnPropertyChanged(nameof(Total));
                OnPropertyChanged(nameof(Calories));
                return true;
            }
            return false;
        }

        public void Clear()
        {
            order.Clear();
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
            return order.Contains(item);
        }

        /// <summary>
        /// Copies the data.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">The index</param>
        public void CopyTo(IMenuItem[] array, int arrayIndex)
        {
            order.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>
        /// Returns the enumerator.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }

        public IEnumerator<IMenuItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }
    }
}
