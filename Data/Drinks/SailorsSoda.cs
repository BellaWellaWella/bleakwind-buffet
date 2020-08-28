/*
* Author: Bella Goddard
* Class name: SailorsSoda
* Purpose: To create the model for soda
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorsSoda
    {
        private Size size = Size.Small;

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
        /// gets & sets the flavor preference
        /// </summary>
        private SodaFlavor flavor = Enums.SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }

            set { flavor = value; }
        }

        /// <summary>
        /// gets & sets the ice preference
        /// </summary>
        public bool Ice { get; set; } = true;

        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else if (size == Size.Large)
                {
                    return 205;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


        }

        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else if (size == Size.Large)
                {
                    return 2.07;
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
                if (!Ice) instructions.Add("Hold ice");

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (size.ToString() + flavor.ToString()+ " Sailor Soda");
        }

    }
}
