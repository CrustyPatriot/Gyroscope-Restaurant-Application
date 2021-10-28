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
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {

        /// <summary>
        /// Propertychanged handler for updating properties
        /// </summary>
        public CashPaymentControl()
        {
            InitializeComponent();
        }

        #region

        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OneHundred(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.OneHundredNumber++;
            }
        }


        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void Fifty(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.FiftyNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void Twenty(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.TwentyNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void Ten(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.TenNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void Five(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.FiveNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void TwoDollar(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.TwoNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OneDollar(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.OneNumber++;
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusOneHundred(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.OneHundredNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.OneHundredNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusFifty(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.FiftyNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.FiftyNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusTwenty(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.TwentyNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.TwentyNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusTen(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.TenNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.TenNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusFive(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.FiveNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.FiveNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusTwoDollar(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.OneNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.TwoNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusOneDollar(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.OneNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.OneNumber--;
                }
            }
        }
        #endregion

        #region
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OneCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.OneCoinNumber++;
            }
        }


        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void FiftyCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.FiftyCoinNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void TwentyFiveCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.TwentyFiveCoinNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void TenCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.TenCoinNumber++;
            }
        }
        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void FiveCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.FiveCoinNumber++;
            }
        }

        /// <summary>
        /// Click Event for the Plus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void OneCentCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                vm.Minus = false;
                vm.Plus = true;
                vm.OneCentNumber++;
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusOneCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.OneCoinNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.OneCoinNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusFiftyCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.FiftyCoinNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.FiftyCoinNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusTwentyFiveCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.TwentyFiveCoinNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.TwentyFiveCoinNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusTenCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.TenCoinNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.TenCoinNumber--;
                }
            }
        }

        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusFiveCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.FiveCoinNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.FiveCoinNumber--;
                }
            }
        }


        /// <summary>
        /// Click Event for the minus button
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        private void MinusOneCentCoin(object Sender, RoutedEventArgs e)
        {
            if (DataContext is PaymentOptionModelView vm)
            {
                if (vm.OneCentNumber > 0)
                {
                    vm.Minus = true;
                    vm.Plus = false;
                    vm.OneCentNumber--;
                }
            }
        }

        /// <summary>
        /// Finalizes sale
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        #endregion
        private void FinalizeSale_Click(object Sender, RoutedEventArgs e)
        {
            if (((PaymentOptionModelView)DataContext).AmountDue == 0)
            {
                ((PaymentOptionModelView)DataContext).Cash = true;
                ((PaymentOptionModelView)DataContext).CreditDebitCard = false;
                ((PaymentOptionModelView)DataContext).SubtractFromCashDrawer();
                ((PaymentOptionModelView)DataContext).AddToCashDrawer();
                ((PaymentOptionModelView)DataContext).Print();
                DependencyObject parent = this;
                do
                {
                    parent = LogicalTreeHelper.GetParent(parent);
                }
                while (!(parent is null || parent is MainWindow));

                MainWindow mainWindow = parent as MainWindow;
                mainWindow.DataContext = new Order();
                ReturnToOrder(Sender, e);
            }
            else
            {
                MessageBox.Show("Pay The Due Amount First Before Finalizing Sale");
            }

        }

        /// <summary>
        /// Returns back to the main screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (!(parent is null || parent is MainWindow));

            MainWindow mainWindow = parent as MainWindow;
            mainWindow.menuItemSelection.Child = new MenuItemSelectionControl();
        }
    }
}
