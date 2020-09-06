/*
* Author: Bella Goddard
* Class name: PhillyPoacher
* Purpose: To create the model for the philly poacher
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the entree, Philly poacher
    /// </summary>
    public class PhillyPoacher
    {
        /// <value>
        /// Gets the Price of the burger
        /// </value>
        public double Price => 7.23;

        /// <value>
        /// gets the calories of the burger
        /// </value>
        public uint Calories => 784;

        /// <value>
        /// gets & sets the sausage preference
        /// </value>
        public bool Sirloin { get; set; } = true;

        /// <value>
        /// gets & sets the egg preference
        /// </value>
        public bool Onion { get; set; } = true;

        /// <value>
        /// gets & sets the hash browns preference
        /// </value>
        public bool Roll { get; set; } = true;


        /// <value>
        /// sets up the special instructions
        /// </value>
        public List<string> SpecialInstructions
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
