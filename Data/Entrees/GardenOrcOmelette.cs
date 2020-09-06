/*
* Author: Bella Goddard
* Class name: GardenOrcOmlette
* Purpose: To create the model for the omelette
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the entree, Garden Orc Omlette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <value>
        /// Gets the Price of the omelette
        /// </value>
        public double Price => 4.57;

        /// <value>
        /// gets the calories of the omelette
        /// </value>
        public uint Calories => 404;

        /// <value>
        /// gets & sets the broccoli preference
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// gets & sets the mushroom preference
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// gets & sets the tomato preference
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// gets & sets the cheddar preference
        /// </value>
        public bool Cheddar { get; set; } = true;


        /// <value>
        /// sets up the special instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Garden Orc Omelette");
        }
    }
}
