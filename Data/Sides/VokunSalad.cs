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
    public class VokunSalad : Side
    {
        /// <value>
        /// gives the calories based on size
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 41;
                }
                else if (Size == Size.Medium)
                {
                    return 52;
                }
                else if (Size == Size.Large)
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
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.93;
                }
                else if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else if (Size == Size.Large)
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
        public override List<string> SpecialInstructions
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
            return (Size.ToString() + " Vokun Salad");
        }
    }
}
