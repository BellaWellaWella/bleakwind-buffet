/*
* Author: Bella Goddard
* Class name: ThalmorTriple
* Purpose: To create the model for the Thalmor Triple
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the Price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// gets & sets the ketchup preference
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// gets &sets the bun preference
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// gets & sets the mustard preference
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// gets & sets the pickle preference
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// gets & sets the cheese preference
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// gets & sets the tomato preference
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// gets & sets the lettuce preference
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// gets & sets the mayo preference
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// gets & sets the bacon preference
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// gets & sets the egg preference
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// sets up the special instructions
        /// </summary>
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
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Thalmor Triple");
        }
    }
}
