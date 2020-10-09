/*
* Author: Bella Goddard
* Class name: Side
* Purpose: To create the base class for Side
*/
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides 
{
    /// <summary>
    /// The base class for side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
