/*
* Author: Bella Goddard
* Class name: AretinoAppleJuice
* Purpose: To create the model for Fried Miraak
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
    /// A class that represents the side, Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// PropertyChanged Event handler
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
        private Size size;

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
                    return 151;
                }
                else if (Size == Size.Medium)
                {
                    return 236;
                }
                else if (Size == Size.Large)
                {
                    return 306;
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
                    return 1.78;
                }
                else if (Size == Size.Medium)
                {
                    return 2.01;
                }
                else if (Size == Size.Large)
                {
                    return 2.88;
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
            return (Size.ToString() + " Fried Miraak");
        }
    }
}
