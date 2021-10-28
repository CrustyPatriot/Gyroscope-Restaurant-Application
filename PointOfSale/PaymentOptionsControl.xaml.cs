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
using GyroScope.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        public PaymentOptions()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for the Credit/Debit button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CreditDebit_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the Cash button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;

            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (!(parent is null || parent is MainWindow));

            MainWindow window = parent as MainWindow;
            parent = window;

            if (sender is Button button)
            {
                if (button.Name == "cash" && DataContext is Order order)
                {
                    var temp = new CashPayment();
                }
            }
        }

        /// <summary>
        /// Event handler for the Return To Order button.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
