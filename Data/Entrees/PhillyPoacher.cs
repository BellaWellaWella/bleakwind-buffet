using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the Price of the burger
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// gets & sets the sausage preference
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// gets & sets the egg preference
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// gets & sets the hash browns preference
        /// </summary>
        public bool Roll { get; set; } = true;


        /// <summary>
        /// sets up the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin.");
                if (!Onion) instructions.Add("Hold onions.");
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
