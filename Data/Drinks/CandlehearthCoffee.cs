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
    public class CandlehearthCoffee
    {
        private Size size = Size.Small;

        /// <summary>
        /// gets & sets the size preference
        /// </summary>
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



        /// <summary>
        /// gets & sets the ice preference
        /// </summary>
        public bool Ice { get; set; } = false;
        
        /// <summary>
        /// gets & sets the room for cream preference
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        
        /// <summary>
        /// gets & sets the decaf preference
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// gives the calories based on size
        /// </summary>
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

        /// <summary>
        /// gives the price based on size
        /// </summary>
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

        /// <summary>
        /// sets up the special instructions
        /// </summary>
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

