using System.Windows;
using System.Windows.Controls;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using GyroScope.Data.Drinks;
using GyroScope.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Initializes an order.
        /// </summary>
        public Order _order => (Order)DataContext;

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
            if (sender is Button)
            {
                VirgoClassicGyro gyro = new VirgoClassicGyro();              
                GyroCustomControl data = new GyroCustomControl();
                _order.Add(gyro);
                data.DataContext = gyro;                
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the leo lamb gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LeoLambGyro_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                LeoLambGyro gyro = new LeoLambGyro();              
                GyroCustomControl data = new GyroCustomControl();
                _order.Add(gyro);
                data.DataContext = gyro;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the scorpio spicy gyro.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void ScorpioSpicyGyro_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                ScorpioSpicyGyro gyro = new ScorpioSpicyGyro();                
                GyroCustomControl data = new GyroCustomControl();
                _order.Add(gyro);
                data.DataContext = gyro;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the pisces fish dish.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void PiscesFishDish_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                PiscesFishDish fish = new PiscesFishDish();
                PiscesFishDishControl data = new PiscesFishDishControl();
                _order.Add(fish);
                data.DataContext = fish;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the taurus tabouleh.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void TaurusTabouleh_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                TaurusTabuleh side = new TaurusTabuleh();
                SideSizecontrol data = new SideSizecontrol();
                _order.Add(side);
                data.DataContext = side;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the gemini stuffed grape leaves.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void GeminiStuffedGrapeLeaves_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                GeminiStuffedGrapeLeaves side = new GeminiStuffedGrapeLeaves();
                SideSizecontrol data = new SideSizecontrol();
                _order.Add(side);
                data.DataContext = side;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the sagittarius greek salad.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void SagittariusGreekSalad_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                SagittariusGreekSalad side = new SagittariusGreekSalad();
                SideSizecontrol data = new SideSizecontrol();
                _order.Add(side);
                data.DataContext = side;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the ares fries.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AresFries_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                AriesFries side = new AriesFries();
                SideSizecontrol data = new SideSizecontrol();
                _order.Add(side);
                data.DataContext = side;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the libra libation.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void LibraLibation_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                LibraLibation drink = new LibraLibation();
                LibraLibationControl data = new LibraLibationControl();
                _order.Add(drink);
                data.DataContext = drink;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the capricorn mountain tea.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CapricornMountainTea_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                CapricornMountainTea drink = new CapricornMountainTea();
                CapricornMountainTeaControl data = new CapricornMountainTeaControl();
                _order.Add(drink);
                data.DataContext = drink;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the aquarius ice.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void AquariusIce_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                AquariusIce ice = new AquariusIce();
                AquariusIceControl data = new AquariusIceControl();
                _order.Add(ice);
                data.DataContext = ice;
                MenuBorderItem.Child = data;
            }
        }

        /// <summary>
        /// Event handler for the cancer halva cake.
        /// </summary>
        /// <param name="sender">The object sending the event.</param>
        /// <param name="e">The event.</param>
        private void CancerHalvaCake_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                CancerHalvaCake cake = new CancerHalvaCake();
                CancerHalvaCakeControl data = new CancerHalvaCakeControl();
                _order.Add(cake);
                data.DataContext = cake;
                MenuBorderItem.Child = data;
            }
        }
    }
}
