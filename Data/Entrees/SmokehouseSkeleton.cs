/*
* Author: Bella Goddard
* Class name: SmokehouseSkeleton
* Purpose: To create the model for the smokehouse skeleton
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class that represennts the entree, Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        /// <value>
        /// Gets the Price of the dish
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// gets the calories of the dish
        /// </value>
        public override uint Calories => 602;

        /// <value>
        /// gets & sets the sausage preference
        /// </value>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// gets & sets the egg preference
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// gets & sets the hash browns preference
        /// </value>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// gets & sets the pancake preference
        /// </value>
        public bool Pancake { get; set; } = true;


        /// <value>
        /// sets up the special instructions
        /// </value>
        public override List<string> SpecialInstructions
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
