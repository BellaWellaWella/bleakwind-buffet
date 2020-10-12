/*
* Author: Bella Goddard
* Class name: MarkarthMilk
* Purpose: To create the model for milk
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
    /// A class that represents the drink Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for Markarth Milk
        /// </summary>
        public MarkarthMilk()
        {
            this.Ice = false;
            this.Size = Size.Small;
        }

        /// <value>
        /// gets & sets the ice preference
        /// </value>

        private bool ice = false;

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
        /// gives the calories based on size
        /// </value>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else if (Size == Size.Large)
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
        public override double Price
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
        public override List<string> SpecialInstructions
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

