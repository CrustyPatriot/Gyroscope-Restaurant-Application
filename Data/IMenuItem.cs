using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    /// <summary>
    /// Interface representing the menu items.
    /// </summary>
    public interface IMenuItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the item.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// The calories of the item.
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// The special instructions of the item.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; }
    }
}
