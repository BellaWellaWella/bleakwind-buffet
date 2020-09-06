/*
* Author: Bella Goddard
* Class name: VokunSalad
* Purpose: To create the model for the fruit salad
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class that represents the side, Vokun Salad
    /// </summary>
    public class VokunSalad
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
        /// gives the calories based on size
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else if (size == Size.Large)
                {
                    return 73;
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
                    return 0.93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else if (size == Size.Large)
                {
                    return 1.82;
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

        /// <value>
        /// ovverides the to string method
        /// </value>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (size.ToString() + " Vokun Salad");
        }
    }
}
