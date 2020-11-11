/*
* Author: Bella Goddard
* Class name: IOrderItem
* Purpose: To create the model for an IOrderItem
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface to order an item, implemented in all options through their Base Classes
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the thing
        /// </summary>
        /// <value>In US dollars</value>
        double Price { get; }

        /// <summary>
        /// The calories of the thing
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The name of the thing
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of the thing
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special instructions to prepare the thing
        /// </summary>
        List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ItemType itemType { get; }
    }
}
