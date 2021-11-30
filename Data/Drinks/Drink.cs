using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The base class for all drinks.
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged, IMenuItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The description of a specific drink.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions.
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Helper method used to trigger a PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that's changing.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
