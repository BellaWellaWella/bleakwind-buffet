/*
* Author: Bella Goddard
* Class name: ThugsTBone
* Purpose: To create the model for the t-bone
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class that represents the entree, Thugs T-Bone
    /// </summary>
    public class ThugsTBone
    {
        /// <value>
        /// Gets the Price of the t-bone
        /// </value>
        public double Price => 6.44;

        /// <value>
        /// gets the calories of the t-bone
        /// </value>
        public uint Calories => 982;

        /// <value>
        /// sets up the special instructions
        /// </value>
        public List<string> SpecialInstructions
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
