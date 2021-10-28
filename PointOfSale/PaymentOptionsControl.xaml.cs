using System.Windows;
using System.Windows.Controls;
using GyroScope.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        /// <summary>
        /// Initializes the payment options control.
        /// </summary>
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
            if (DataContext is Order order)
            {
                PaymentOptionModelView view = new PaymentOptionModelView();
                view.CreditDebitCard = true;
                view.Cash = false;
                view.Order = order;
                CardTransactionResult result = CardReader.RunCard((double)view.Total);
                if (result == CardTransactionResult.Approved)
                {
                    MessageBox.Show("Transaction Approved");
                    view.Print();
                    DependencyObject parent = this;
                    do
                    {
                        parent = LogicalTreeHelper.GetParent(parent);
                    }
                    while (!(parent is null || parent is MainWindow));

                    MainWindow window = parent as MainWindow;
                    window.DataContext = new Order();
                    ReturnToOrder_Click(sender, e);
                }
                if (result == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Transaction Declined");
                }
                if (result == CardTransactionResult.IncorrectPin)
                {
                    MessageBox.Show("Incorrect Pin");
                }
                if (result == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient funds");
                }
                if (result == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Card read error. Try again");
                }
            }
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
                    CashPaymentControl temp = new CashPaymentControl();
                    PaymentOptionModelView view = new PaymentOptionModelView();
                    temp.DataContext = view;
                    view.Order = order;
                    view.AmountDue = view.Total;
                    window.menuItemSelection.Child = temp;
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
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (!(parent is null || parent is MainWindow));

            MainWindow window = parent as MainWindow;
            window.menuItemSelection.Child = new MenuItemSelectionControl();
        }
    }
}
