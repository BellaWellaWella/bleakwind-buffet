using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for Combo.xaml
    /// </summary>
    public partial class Combo : UserControl
    {
        Controller Ancestor;

        public Combo(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;

            List<string> entreeOptions = new List<string>();
            entreeOptions.Add("Briarheart Burger");
            entreeOptions.Add("Double Draugr");
            entreeOptions.Add("Garden Orc Omelette");
            entreeOptions.Add("Philly Poacher");
            entreeOptions.Add("Smokehouse Skeleton");
            entreeOptions.Add("Thalmor Triple");
            entreeOptions.Add("Thugs T-Bone");

            List<string> drinkOptions = new List<string>();
            drinkOptions.Add("Aretino Apple Juice"); 
            drinkOptions.Add("Candlehearth Coffee");
            drinkOptions.Add("Markarth Milk");
            drinkOptions.Add("Sailor's Soda");
            drinkOptions.Add("Warrior Water");

            List<string> sideOptions = new List<string>();
            sideOptions.Add("Dragonborn Waffle Fries");
            sideOptions.Add("Fried Miraak");
            sideOptions.Add("Mad Otar Grits");
            sideOptions.Add("Vokun Salad");

            EntreeComboBox.ItemsSource = entreeOptions;
            DrinkComboBox.ItemsSource = drinkOptions;
            SideComboBox.ItemsSource = sideOptions;

        }

        /// <summary>
        /// Button to go back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MenuChooser);
        }

        private void EntreeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Combo currentCombo)
            {
                if(EntreeComboBox.SelectedItem.Equals("Briarheart Burger"))
                {
                    currentCombo.Entree = new BriarheartBurger();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Double Draugr"))
                {
                    currentCombo.Entree = new DoubleDraugr();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Garden Orc Omelette"))
                {
                    currentCombo.Entree = new GardenOrcOmelette();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Philly Poacher"))
                {
                    currentCombo.Entree = new PhillyPoacher();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Thalmor Triple"))
                {
                    currentCombo.Entree = new ThalmorTriple();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Thugs T-Bone"))
                {
                    currentCombo.Entree = new ThugsTBone();
                }
                else if (EntreeComboBox.SelectedItem.Equals("Smokehouse Skeleton"))
                {
                    currentCombo.Entree = new SmokehouseSkeleton();
                }
            }
        }

        private void SideComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Combo currentCombo)
            {
                if (SideComboBox.SelectedItem.Equals("Aretino Apple Juice"))
                {
                    currentCombo.Side = new AretinoAppleJuice();
                }
                else if (SideComboBox.SelectedItem.Equals("Fried Miraak"))
                {
                    currentCombo.Side = new FriedMiraak();
                }
                else if (SideComboBox.SelectedItem.Equals("Mad Otar Grits"))
                {
                    currentCombo.Side = new MadOtarGrits();
                }
                else if (SideComboBox.SelectedItem.Equals("Vokun Salad"))
                {
                    currentCombo.Side = new VokunSalad();
                }
            }
        }

        private void DrinkComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Combo currentCombo)
            {
                if (DrinkComboBox.SelectedItem.Equals("Dragonborn Waffle Fries"))
                {
                    currentCombo.Drink = new DragonbornWaffleFries();
                }
                else if (DrinkComboBox.SelectedItem.Equals("Candlehearth Coffee"))
                {
                    currentCombo.Drink = new CandlehearthCoffee();
                }
                else if (DrinkComboBox.SelectedItem.Equals("Markarth Milk"))
                {
                    currentCombo.Drink = new MarkarthMilk();
                }
                else if (DrinkComboBox.SelectedItem.Equals("Sailor's Soda"))
                {
                    currentCombo.Drink = new SailorSoda();
                }
                else if (DrinkComboBox.SelectedItem.Equals("Warrior Water"))
                {
                    currentCombo.Drink = new WarriorWater();
                }
            }
        }
    }
}
