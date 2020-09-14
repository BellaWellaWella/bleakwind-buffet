/*
* Author: Bella Goddard
* Class name: CandlehearthCoffee
* Purpose: To create the model for coffee
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class that represents the drink, Candlehearth coffee
    /// </summary>
    public class CandlehearthCoffee : Drink
    {



        /// <value>
        /// gets & sets the ice preference
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// gets & sets the room for cream preference
        /// </value>
        public bool RoomForCream { get; set; } = false;

        /// <value>
        /// gets & sets the decaf preference
        /// </value>
        public bool Decaf { get; set; } = false;

        /// <value>
        /// gives the calories based on size
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else if (Size == Size.Large)
                {
                    return 20;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


        }

        /// <value>
        /// gives the price based on size
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return .75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else if (Size == Size.Large)
                {
                    return 1.75;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        /// <value>
        /// sets up the special instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            if(!Decaf)
                return (Size.ToString() + " Candlehearth Coffee");
            else
                return (Size.ToString() + " Decaf Candlehearth Coffee");
        }
    }
}

