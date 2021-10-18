using PointOfSale;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace GyroScope.Data.Order
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order : IMenuItem, ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
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
        }

        /// <summary>
        /// Helper method used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that's changing.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Helper method used to trigger a CollectionChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that's changing.</param>
        protected void OnCollectionChanged(string collectionName)
        {
            this.CollectionChanged?.Invoke(this, new CollectionChangeEventArgs(collectionName));
        }

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(IMenuItem item)
        {
            Order list = new();
            list.Add(item);
            OnCollectionChanged(nameof(item));
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Tax));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Calories));
        }

        /// <summary>
        /// Removes an item from the order.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        public void Remove(IMenuItem item)
        {
            Order list = new();
            list.Remove(item);
            OnCollectionChanged(nameof(item));
            OnPropertyChanged(nameof(Subtotal));
            OnPropertyChanged(nameof(Tax));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Calories));
        }
    }
}
