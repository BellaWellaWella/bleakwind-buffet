
/*
* Author: Bella Goddard
* Class name: AretinoAppleJuice
* Purpose: To create the model for Aretino Apple Juice
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
    /// A Class that represents the drink, Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        public AretinoAppleJuice()
        {
            this.Ice = false;
            this.Size = Size.Small;
        }
        /// <summary>
        /// declaring the event handler for PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method to handle if the property changed
        /// </summary>
        /// <param name="propertyName"> the property that is being changed</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //private backing variable for size
        private Size size = Size.Small;

        /// <summary>
        /// gets & sets the size preference
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value;
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Size");
            }
        }



        /// <value>
        /// gets & sets the ice preference
        /// </value>

        private bool ice = false;

        public bool Ice
        {
            get { return ice; }
            set { ice =  value;
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
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else if (Size == Size.Large)
                {
                    return 132;
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
                    return .62;
                }
                else if (Size == Size.Medium)
                {
                    return .87;
                }
                else if (Size == Size.Large)
                {
                    return 1.01;
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
            return (Size.ToString() + " Aretino Apple Juice");
        }
    }
}
