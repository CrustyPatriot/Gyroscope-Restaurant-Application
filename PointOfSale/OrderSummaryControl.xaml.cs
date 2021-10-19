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
using Gyroscope.Data;
using GyroScope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Initializes the order summary control window.
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes an order and sets it as the data context.
        /// </summary>
        public Order NewOrder => (Order)DataContext;

        /// <summary>
        /// Event handler for the remove item button.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event.</param>
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                NewOrder.Remove((IMenuItem)button.DataContext);
            }
        }

        /// <summary>
        /// Edits the item in the listview.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event.</param>
        private void EditItem(object sender, RoutedEventArgs e)
        {
            DependencyObject newObject = this;
            do
            {
                newObject = LogicalTreeHelper.GetParent(newObject);
            }
            while (!(newObject is null || newObject is MainWindow));

            if (newObject is MainWindow)
            {
                MainWindow window = (MainWindow)newObject;

                if (list.SelectedValue is Gyro)
                {
                    var control = new GyroCustomControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is PiscesFishDish)
                {
                    var control = new PiscesFishDishControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is Side)
                {
                    var control = new SideSizecontrol();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is LibraLibation)
                {
                    var control = new LibraLibationControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is CapricornMountainTea)
                {
                    var control = new CapricornMountainTeaControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is AquariusIce)
                {
                    var control = new AquariusIceControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }

                if (list.SelectedValue is CancerHalvaCake)
                {
                    var control = new CancerHalvaCakeControl();
                    control.DataContext = list.SelectedItem;
                    window.menuItemSelection.Child = control;
                }
            }
        }
    }
}
