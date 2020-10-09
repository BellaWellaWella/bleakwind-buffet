using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing a combo, which is any combination of entree, drink and side. It will be discounted by $1 and will return the combination
    /// of calories and special instructions.
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public Combo()
        {
            Drink = drink;
            Entree = entree;
            Side = side;
        }


        private IOrderItem drink;
        /// <summary>
        /// represents the drink in the combo
        /// </summary>
        public IOrderItem Drink { 
            get 
            {
                return drink;
            }

            set
            {
                drink = value;
                drink.PropertyChanged += ItemEventChange;
                OnPropertyChanged("Drink");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");

            }
        }

        private IOrderItem side;
        /// <summary>
        /// represents the side in the combo
        /// </summary>
        public IOrderItem Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
                side.PropertyChanged += ItemEventChange;
                OnPropertyChanged("Side");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
             }
        }

        private IOrderItem entree;
        /// <summary>
        /// represents the entree in the combo
        /// </summary>
        public IOrderItem Entree
        {
            get
            {
                return entree;
            }

            set
            {
                entree = value;
                entree.PropertyChanged += ItemEventChange;
                OnPropertyChanged("Entree");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
                
            }
        }


        /// <summary>
        /// Declaring the event handler for PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method to handle property change
        /// </summary>
        /// <param name="propertyName">the property that is being changed</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// The price of the total combo minus a dollar
        /// </summary>
        /// <value>In US dollars</value>
        public double Price {
            get{
                double sum = 0;
                sum += Drink.Price;
                sum += Side.Price;
                sum += Entree.Price;
            
                return (sum - 1);
            }
        }

        /// <summary>
        /// The calories of the combo
        /// </summary>
        public uint Calories {
            get
            {
                uint sum = 0;
                sum += Drink.Calories;
                sum += Side.Calories;
                sum += Entree.Calories;
                return sum;
            }
        }

        /// <summary>
        /// Special instructions for the entire combo, including the name of each item
        /// </summary>
        public List<string> SpecialInstructions {
            get
            {
                List<string> instructions = new List<string>();

                instructions.Add(Entree.ToString());
                instructions.Add(Entree.SpecialInstructions.ToString());

                instructions.Add(Side.ToString());
                instructions.Add(Side.SpecialInstructions.ToString());

                instructions.Add(Drink.ToString());
                instructions.Add(Drink.SpecialInstructions.ToString());

                return instructions;
            }
        }

        private void ItemEventChange(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged("Price");
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged("Calories");
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                OnPropertyChanged("SpecialInstructions");
            }
        }

    }
}
