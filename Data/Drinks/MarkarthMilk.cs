/*
* Author: Bella Goddard
* Class name: MarkarthMilk
* Purpose: To create the model for milk
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class that represents the drink Markarth Milk
    /// </summary>
    public class MarkarthMilk
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
        /// gives the calories based on size
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else if (size == Size.Large)
                {
                    return 93;
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
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else if (Size == Size.Large)
                {
                    return 1.22;
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

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (Size.ToString()  + " Markarth Milk");
        }
    }
}

