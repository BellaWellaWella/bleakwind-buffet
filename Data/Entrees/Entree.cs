/*
* Author: Bella Goddard
* Class name: Entree
* Purpose: To create the base class for Entree
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class to represent Entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
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
        /// Declaring the event handler for PropertyChanged
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
        public ItemType itemType { get { return BleakwindBuffet.Data.Enums.ItemType.Entree; } }

        /// <summary>
        /// The description of the item
        /// </summary>
        public abstract string Description { get; }

    }
}
