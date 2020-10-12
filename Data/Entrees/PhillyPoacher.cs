/*
* Author: Bella Goddard
* Class name: PhillyPoacher
* Purpose: To create the model for the philly poacher
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{

    /// <summary>
    /// A class representing the entree, Philly poacher
    /// </summary>
    public class PhillyPoacher : Entree, INotifyPropertyChanged 
    {
        /// <summary>
        /// constructor for philly poacher
        /// </summary>
        public PhillyPoacher()
        {
            this.Sirloin = true;
            this.Onion = true;
            this.Roll = true;
        }

        /// <value>
        /// Gets the Price of the burger
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// gets the calories of the burger
        /// </value>
        public override uint Calories => 784;

        private bool sirloin = true;
        /// <value>
        /// gets & sets the sirloin preference
        /// </value>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                OnPropertyChanged("Sirloin");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool onion = true;
        /// <value>
        /// gets & sets the onion preference
        /// </value>
        public bool Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                OnPropertyChanged("Onion");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool roll = true;
        /// <value>
        /// gets & sets the roll preference
        /// </value>
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                OnPropertyChanged("Roll"); 
                OnPropertyChanged("SpecialInstructions");
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
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Philly Poacher");
        }
    }
}
