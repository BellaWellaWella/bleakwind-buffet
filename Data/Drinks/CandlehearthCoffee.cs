/*
* Author: Bella Goddard
* Class name: CandlehearthCoffee
* Purpose: To create the model for coffee
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
    /// A class that represents the drink, Candlehearth coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for Candlehearth Coffee
        /// </summary>
        public CandlehearthCoffee()
        {
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
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

        /// <summary>
        /// Gets the cream preference
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value;
                OnPropertyChanged("RoomForCream");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the caffine preference
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                OnPropertyChanged("Decaf");
                OnPropertyChanged("Name");
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
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else if (Size == Size.Large)
                {
                    return 20;
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
                    return .75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else if (Size == Size.Large)
                {
                    return 1.75;
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
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            if(!Decaf)
                return (Size.ToString() + " Candlehearth Coffee");
            else
                return (Size.ToString() + " Decaf Candlehearth Coffee");
        }

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get { return "Fair trade, fresh ground dark roast coffee."; }
        }
    }
}

