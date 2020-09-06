/*
* Author: Bella Goddard
* Class name: MadOtarGrits
* Purpose: To create the model for grits
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class that represents the side, Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
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
                    return 105;
                }
                else if (size == Size.Medium)
                {
                    return 142;
                }
                else if (size == Size.Large)
                {
                    return 179;
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
                    return 1.22;
                }
                else if (size == Size.Medium)
                {
                    return 1.58;
                }
                else if (size == Size.Large)
                {
                    return 1.93;
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
            return (size.ToString() + " Mad Otar Grits");
        }
    }
}
