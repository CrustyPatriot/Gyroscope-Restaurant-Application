using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data.Treats 
{
    /// <summary>
    /// The base class for all treats.
    /// </summary>
    public abstract class Treat : INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Notifies when a property of this class changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The description of a specific treat.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The price of the treat.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions.
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

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
