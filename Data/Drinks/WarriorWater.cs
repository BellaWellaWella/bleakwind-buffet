/*
* Author: Bella Goddard
* Class name: Warrior Water
* Purpose: To create the model for water
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class to represent the drink warrior water
    /// </summary>
    public class WarriorWater
    {

        //private double price = 0.00;
        /// <value>
        /// A private backing variable for size
        /// </value>
        private Size size = Size.Small;

        /// <value>
        /// A get & set for size
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
        /// gets & sets the Lemon preference
        /// </value>
        public bool Lemon { get; set; } = false;

        /// <value>
        /// gets & sets the ice preference
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Gets & sets the calories property
        /// </value>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0;
                }
                else if (size == Size.Medium)
                {
                    return 0;
                }
                else if (size == Size.Large)
                {
                    return 0;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        
        
        }

        /// <value>
        /// Gets & sets the price property
        /// </value>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 0.00;
                }
                else if (size == Size.Medium)
                {
                    return 0.00;
                }
                else if (size == Size.Large)
                {
                    return 0.00;
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
      
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (size.ToString() + " Warrior Water");
        }
    }
}

