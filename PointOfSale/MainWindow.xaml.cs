using GyroScope.Data;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes the order.
        /// </summary>
        public Order _order = new();

        /// <summary>
        /// Sets the order property.
        /// </summary>
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
            DataContext = new Order();
        }

        /// <summary>
        /// Event handler for the Cancel button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
            Order = new Order();

        }

        /// <summary>
        /// Event handler for the Complete Order button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (!(parent is null || parent is MainWindow));

            MainWindow nextBorder = parent as MainWindow;
            parent = nextBorder;
            if (sender is Button button && button.Name == "paymentmethod")
            {
                if (DataContext is Order)
                {
                    PaymentOptions temp = new PaymentOptions();
                    nextBorder.menuItemSelection.Child = temp;
                }
            }
        }

        /// <summary>
        /// Event handler for the select items button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Select_Click(object sender, RoutedEventArgs e)
        {
            menuItemSelection.Child = new MenuItemSelectionControl();
        }
    }
}
