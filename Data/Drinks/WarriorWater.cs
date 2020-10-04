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
        /// Declaring the event handler for PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method for on property changed
        /// </summary>
        /// <param name="propertyName">the property that is changing</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// private backing variable for size
        /// </summary>
        private Size size;

        /// <summary>
        /// gets & sets size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
            }
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
    }
}

