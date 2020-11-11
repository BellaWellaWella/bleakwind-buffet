/*
* Author: Bella Goddard
* Class name: Drink
* Purpose: To create the base class for Drink
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {


        //private backing variable for size
        private Size size = Size.Small;

        /// <summary>
        /// gets & sets the size preference
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Size");
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }


        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method to handle if the property changed
        /// </summary>
        /// <param name="propertyName"> the property that is being changed</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Method to return name in order to display updated size
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// the type of item
        /// </summary>
        public ItemType itemType { get { return BleakwindBuffet.Data.Enums.ItemType.Drink; } }

        /// <summary>
        /// the description of the item
        /// </summary>
        public abstract string Description { get; }
    }
}
