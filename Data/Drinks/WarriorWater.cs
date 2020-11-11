/*
* Author: Bella Goddard
* Class name: Warrior Water
* Purpose: To create the model for water
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
    /// A class to represent the drink warrior water
    /// </summary>
    public class WarriorWater : Drink, INotifyPropertyChanged 
    {
        /// <summary>
        /// Constructor for Warrior Water
        /// </summary>
        public WarriorWater()
        {
            this.Ice = true;
            this.Lemon = false;
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


        private bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                OnPropertyChanged("Lemon");
                OnPropertyChanged("SpecialInstructions");

            }
        }


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

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get { return "It’s water. Just water."; }
        }
    }
}

