using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the Price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// gets & sets the broccoli preference
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// gets & sets the mushroom preference
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// gets & sets the tomato preference
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// gets & sets the cheddar preference
        /// </summary>
        public bool Cheddar { get; set; } = true;


        /// <summary>
        /// sets up the special instructions
        /// </summary>
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
