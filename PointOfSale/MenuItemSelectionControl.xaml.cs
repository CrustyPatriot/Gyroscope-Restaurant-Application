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
using GyroScope.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initializes the menu item selection control
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the virgo classic gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void VirgoClassicGyro_Click(object sender, RoutedEventArgs e)
        {
            VirgoClassicGyro gyro = new VirgoClassicGyro();
            DataContext = gyro;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.menuBorder.Child = new GyroCustomControl();
        }

        /// <summary>
        /// Event handler for the leo lamb gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LeoLambGyro_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the scorpio spicy gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void ScorpioSpicyGyro_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the pisces fish dish.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void PiscesFishDish_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the taurus tabouleh.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void TaurusTabouleh_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the gemini stuffed grape leaves.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void GeminiStuffedGrapeLeaves_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the sagittarius greek salad.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void SagittariusGreekSalad_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the ares fries.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AresFries_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the libra libation.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LibraLibation_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the capricorn mountain tea.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CapricornMountainTea_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the aquarius ice.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AquariusIce_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the cancer halva cake.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CancerHalvaCake_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
