using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the Price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 743;

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
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Briarheart Burger");
        }

    }
}
