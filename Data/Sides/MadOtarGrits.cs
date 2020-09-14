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
    public class MadOtarGrits : Side
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
                    return 105;
                }
                else if (Size == Size.Medium)
                {
                    return 142;
                }
                else if (Size == Size.Large)
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
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.22;
                }
                else if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else if (Size == Size.Large)
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
        public override List<string> SpecialInstructions
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
            return (Size.ToString() + " Mad Otar Grits");
        }
    }
}
