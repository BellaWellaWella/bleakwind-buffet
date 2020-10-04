/*
* Author: Bella Goddard
* Class name: ThugsTBone
* Purpose: To create the model for the t-bone
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class that represents the entree, Thugs T-Bone
    /// </summary>
    public class ThugsTBone : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Declaring the event handler for PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method for when the property changes
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <value>
        /// Gets the Price of the t-bone
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// gets the calories of the t-bone
        /// </value>
        public override uint Calories => 982;

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
            return ("Thugs T-Bone");
        }
    }
}
