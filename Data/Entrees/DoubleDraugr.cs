/*
* Author: Bella Goddard
* Class name: DoubleDraugr
* Purpose: To create the model for the Double Draugr
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class that represents the entree, Double Draugr
    /// </summary>
    public class DoubleDraugr
    {
        /// <value>
        /// Gets the Price of the burger
        /// </value>
        public double Price => 7.32;

        /// <value>
        /// gets the calories of the burger
        /// </value>
        public uint Calories => 843;

        /// <value>
        /// gets & sets the ketchup preference
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// gets &sets the bun preference
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// gets & sets the mustard preference
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// gets & sets the pickle preference
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// gets & sets the cheese preference
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// gets & sets the tomato preference
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// gets & sets the lettuce preference
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// gets & sets the mayo preference
        /// </value>
        public bool Mayo { get; set; } = true;

        /// <value>
        /// sets up the special instructions
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}
