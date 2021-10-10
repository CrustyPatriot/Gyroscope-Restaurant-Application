using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using GyroScope.Data.Drinks;

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
            menu.AddChild(gyro);
        }

        /// <summary>
        /// Event handler for the leo lamb gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LeoLambGyro_Click(object sender, RoutedEventArgs e)
        {
            LeoLambGyro gyro = new LeoLambGyro();
            DataContext = gyro;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(gyro);
        }

        /// <summary>
        /// Event handler for the scorpio spicy gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void ScorpioSpicyGyro_Click(object sender, RoutedEventArgs e)
        {
            ScorpioSpicyGyro gyro = new ScorpioSpicyGyro();
            DataContext = gyro;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(gyro);
        }

        /// <summary>
        /// Event handler for the pisces fish dish.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void PiscesFishDish_Click(object sender, RoutedEventArgs e)
        {
            PiscesFishDish fish = new PiscesFishDish();
            DataContext = fish;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(fish);
        }

        /// <summary>
        /// Event handler for the taurus tabouleh.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void TaurusTabouleh_Click(object sender, RoutedEventArgs e)
        {
            TaurusTabuleh side = new TaurusTabuleh();
            DataContext = side;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(side);
        }

        /// <summary>
        /// Event handler for the gemini stuffed grape leaves.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void GeminiStuffedGrapeLeaves_Click(object sender, RoutedEventArgs e)
        {
            GeminiStuffedGrapeLeaves side = new GeminiStuffedGrapeLeaves();
            DataContext = side;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(side);
        }

        /// <summary>
        /// Event handler for the sagittarius greek salad.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void SagittariusGreekSalad_Click(object sender, RoutedEventArgs e)
        {
            SagittariusGreekSalad side = new SagittariusGreekSalad();
            DataContext = side;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(side);
        }

        /// <summary>
        /// Event handler for the ares fries.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AresFries_Click(object sender, RoutedEventArgs e)
        {
            AriesFries side = new AriesFries();
            DataContext = side;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(side);
        }

        /// <summary>
        /// Event handler for the libra libation.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LibraLibation_Click(object sender, RoutedEventArgs e)
        {
            LibraLibation drink = new LibraLibation();
            DataContext = drink;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(drink);
        }

        /// <summary>
        /// Event handler for the capricorn mountain tea.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CapricornMountainTea_Click(object sender, RoutedEventArgs e)
        {
            CapricornMountainTea drink = new CapricornMountainTea();
            DataContext = drink;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(drink);
        }

        /// <summary>
        /// Event handler for the aquarius ice.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AquariusIce_Click(object sender, RoutedEventArgs e)
        {
            AquariusIce ice = new AquariusIce();
            DataContext = ice;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(ice);
        }

        /// <summary>
        /// Event handler for the cancer halva cake.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CancerHalvaCake_Click(object sender, RoutedEventArgs e)
        {
            CancerHalvaCake cake = new CancerHalvaCake();
            DataContext = cake;
            MenuItemSelectionControl menu = new MenuItemSelectionControl();
            menu.AddChild(cake);
        }
    }
}
