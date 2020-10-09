/*
* Author: Bella Goddard
* Class name: DragonbornWaffleFries
* Purpose: To create the model for the fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class that represents the side, Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// The constructor for DragonbornWaffleFries
        /// </summary>
        public DragonbornWaffleFries()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// declaration of the event handler for PropertyChanged
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
            set
            {
                size = value;
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("Size");
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
                    return 77;
                }
                else if (Size == Size.Medium)
                {
                    return 89;
                }
                else if (Size == Size.Large)
                {
                    return 100;
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
                    return .42;
                }
                else if (Size == Size.Medium)
                {
                    return .76;
                }
                else if (Size == Size.Large)
                {
                    return .96;
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
            return (Size.ToString() + " Dragonborn Waffle Fries");
        }
    }
}
