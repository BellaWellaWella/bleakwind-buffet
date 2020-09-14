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
    public class WarriorWater : Drink
    {

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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0;
                }
                else if (Size == Size.Medium)
                {
                    return 0;
                }
                else if (Size == Size.Large)
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
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.00;
                }
                else if (Size == Size.Medium)
                {
                    return 0.00;
                }
                else if (Size == Size.Large)
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
        public override List<string> SpecialInstructions
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
            return (Size.ToString() + " Warrior Water");
        }
    }
}

