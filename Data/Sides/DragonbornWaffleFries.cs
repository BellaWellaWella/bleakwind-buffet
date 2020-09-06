/*
* Author: Bella Goddard
* Class name: DragonbornWaffleFries
* Purpose: To create the model for the fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class that represents the side, Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <value>
        /// A private backing varible for size
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
        /// gives the calories based on size
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 77;
                }
                else if (size == Size.Medium)
                {
                    return 89;
                }
                else if (size == Size.Large)
                {
                    return 100;
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
                    return .42;
                }
                else if (size == Size.Medium)
                {
                    return .76;
                }
                else if (size == Size.Large)
                {
                    return .96;
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

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (size.ToString() + " Dragonborn Waffle Fries");
        }
    }
}
