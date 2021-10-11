using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The class containing the Gyro instructions.
    /// </summary>
    public class Gyro : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The price.
        /// </summary>
        public override decimal Price { get; }

        /// <summary>
        /// The calories.
        /// </summary>
        public override uint Calories { get; }

        /// <summary>
        /// Backing field for the meat property.
        /// </summary>
        public DonerMeat _meat;

        /// <summary>
        /// The type of meat.
        /// </summary>
        public DonerMeat Meat
        {
            get => _meat;
            set
            {
                if (_meat != value)
                {
                    _meat = value;
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Pita property.
        /// </summary>
        public bool _pita;

        /// <summary>
        /// The ingredient pita.
        /// </summary>
        public bool Pita
        {
            get => _pita;
            set
            {
                if (_pita != value)
                {
                    _pita = value;
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }
        /// <summary>
        /// The ingredient tomato.
        /// </summary>
        public bool Tomato { get; set; }
        /// <summary>
        /// The ingredient onion.
        /// </summary>
        public bool Onion { get; set; }
        /// <summary>
        /// The ingredient eggplant.
        /// </summary>
        public bool Eggplant { get; set; }
        /// <summary>
        /// The ingredient lettuce.
        /// </summary>
        public bool Lettuce { get; set; }
        /// <summary>
        /// The ingredient mint chutney.
        /// </summary>
        public bool MintChutney { get; set; }
        /// <summary>
        /// The ingredient tzatziki.
        /// </summary>
        public bool Tzatziki { get; set; }
        /// <summary>
        /// The ingredient peppers.
        /// </summary>
        public bool Peppers { get; set; }
        /// <summary>
        /// The ingredient wing sauce.
        /// </summary>
        public bool WingSauce { get; set; }
    }
}
