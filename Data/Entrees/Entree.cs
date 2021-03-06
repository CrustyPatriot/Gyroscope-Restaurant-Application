using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The base class for all entrees.
    /// </summary>
    public abstract class Entree: INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for each 
        /// </summary>
        public virtual IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The description of each menu item.
        /// </summary>
        public abstract string Description { get; }

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
