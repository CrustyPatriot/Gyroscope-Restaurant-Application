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
                    OnPropertyChanged(nameof(Meat));
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
                    OnPropertyChanged(nameof(Pita));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Tomato property.
        /// </summary>
        public bool _tomato;

        /// <summary>
        /// The ingredient tomato.
        /// </summary>
        public bool Tomato
        {
            get => _tomato;
            set
            {
                if (_tomato != value)
                {
                    _tomato = value;
                    OnPropertyChanged(nameof(Tomato));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Onion property.
        /// </summary>
        public bool _onion;

        /// <summary>
        /// The ingredient onion.
        /// </summary>
        public bool Onion
        {
            get => _onion;
            set
            {
                if (_onion != value)
                {
                    _onion = value;
                    OnPropertyChanged(nameof(Onion));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Eggplant property.
        /// </summary>
        public bool _eggplant;

        /// <summary>
        /// The ingredient eggplant.
        /// </summary>
        public bool Eggplant
        {
            get => _eggplant;
            set
            {
                if (_eggplant != value)
                {
                    _eggplant = value;
                    OnPropertyChanged(nameof(Eggplant));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Lettuce property.
        /// </summary>
        public bool _lettuce;

        /// <summary>
        /// The ingredient lettuce.
        /// </summary>
        public bool Lettuce
        {
            get => _lettuce;
            set
            {
                if ( _lettuce != value)
                {
                    _lettuce = value;
                    OnPropertyChanged(nameof(Lettuce));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Mint Chutney property.
        /// </summary>
        public bool _mintChutney;

        /// <summary>
        /// The ingredient mint chutney.
        /// </summary>
        public bool MintChutney
        {
            get => _mintChutney;
            set
            {
                if (_mintChutney != value)
                {
                    _mintChutney = value;
                    OnPropertyChanged(nameof(MintChutney));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Tzatziki property.
        /// </summary>
        public bool _tzatziki;

        /// <summary>
        /// The ingredient tzatziki.
        /// </summary>
        public bool Tzatziki
        {
            get => _tzatziki;
            set
            {
                if (_tzatziki != value)
                {
                    _tzatziki = value;
                    OnPropertyChanged(nameof(Tzatziki));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Peppers property.
        /// </summary>
        public bool _peppers;

        /// <summary>
        /// The ingredient peppers.
        /// </summary>
        public bool Peppers
        {
            get => _peppers;
            set
            {
                if (_peppers != value)
                {
                    _peppers = value;
                    OnPropertyChanged(nameof(Peppers));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }

        /// <summary>
        /// Backing field for the Wing Sauce property.
        /// </summary>
        public bool _wingSauce;

        /// <summary>
        /// The ingredient wing sauce.
        /// </summary>
        public bool WingSauce
        {
            get => _wingSauce;
            set
            {
                if (_wingSauce != value)
                {
                    _wingSauce = value;
                    OnPropertyChanged(nameof(WingSauce));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(SpecialInstructions));
                }
            }
        }
    }
}
