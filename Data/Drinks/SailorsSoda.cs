﻿/*
* Author: Bella Goddard
* Class name: SailorSoda
* Purpose: To create the model for soda
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class that represents the drink sailor soda
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for Sailor soda
        /// </summary>
        public SailorSoda()
        {
            this.Ice = true;
            this.Flavor = SodaFlavor.Cherry;
            this.Size = Size.Small;
        }

       
        /// <value>
        /// gets & sets the ice preference
        /// </value>

        private bool ice = true;

        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                OnPropertyChanged("Ice");
                OnPropertyChanged("SpecialInstructions");

            }
        }


        /// <value>
        /// gets & sets the flavor preference
        /// </value>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }

            set { flavor = value;
                OnPropertyChanged("Flavor");
                OnPropertyChanged("Name");
            }
        }

       

        /// <value>
        /// gets & sets the calorie property
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else if (Size == Size.Large)
                {
                    return 205;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


        }

        /// <value>
        /// gets & sets the price property
        /// </value>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else if (Size == Size.Large)
                {
                    return 2.07;
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

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return (Size.ToString() + " "+ Flavor.ToString() + " Sailor Soda");
        }


        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get { return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice."; }
        }

    }
}
