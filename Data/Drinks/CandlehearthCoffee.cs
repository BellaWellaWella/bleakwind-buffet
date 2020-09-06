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
    public class CandlehearthCoffee
    {
        /// <value>
        /// A private backing variable for size
        /// </value>
        private Size size = Size.Small;

        /// <value>
        /// gets & sets the size preference
        /// </value>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }



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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else if (size == Size.Large)
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
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return .75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else if (size == Size.Large)
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
        public List<string> SpecialInstructions
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
                return (size.ToString() + " Candlehearth Coffee");
            else
                return (size.ToString() + " Decaf Candlehearth Coffee");
        }
    }
}

