using GyroScope.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Order _order = new();

        public Order Order
        {
            get => _order;
            set
            {
                if (_order != value)
                {
                    _order = value;
                    DataContext = value;
                }
            }
        }

        /// <summary>
        /// Initializes the main window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Order;
        }

        /// <summary>
        /// Event handler for the Cancel button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            menuItemSelection.Child = new MenuItemSelectionControl();

        }

        /// <summary>
        /// Event handler for the Complete Order button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            _order = new Order();
        }

        /// <summary>
        /// Event handler for the select items button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Select_Click(object sender, RoutedEventArgs e)
        {
            _order = new Order();
        }
    }
}
