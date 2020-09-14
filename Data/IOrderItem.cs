using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface to order an item, implemented in all options through their Base Classes
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>In US dollars</value>
        double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
