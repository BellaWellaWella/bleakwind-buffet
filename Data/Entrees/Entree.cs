/*
* Author: Bella Goddard
* Class name: Entree
* Purpose: To create the base class for Entree
*/

using System;
using System.Collections.Generic;
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

    }
}
