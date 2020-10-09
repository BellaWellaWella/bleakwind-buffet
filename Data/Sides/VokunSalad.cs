/*
* Author: Bella Goddard
* Class name: VokunSalad
* Purpose: To create the model for the fruit salad
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
    /// A class that represents the side, Vokun Salad
    /// </summary>
    public class VokunSalad : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The constructor for VokunSalad
        /// </summary>
        public VokunSalad()
        {
            this.Size = Size.Small;
        }

        /// <summary>
        /// PropertyChanged event handler
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
