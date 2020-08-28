using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the Price of the dish
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// gets the calories of the dish
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// gets & sets the sausage preference
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// gets & sets the egg preference
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// gets & sets the hash browns preference
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// gets & sets the pancake preference
        /// </summary>
        public bool Pancake { get; set; } = true;

       
        /// <summary>
        /// sets up the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Smokehouse Skeleton");
        }
    }
}
