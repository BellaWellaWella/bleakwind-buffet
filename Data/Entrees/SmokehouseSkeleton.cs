/*
* Author: Bella Goddard
* Class name: SmokehouseSkeleton
* Purpose: To create the model for the smokehouse skeleton
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class that represennts the entree, Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged 
    {
        /// <summary>
        /// constructor for smokehouse skeleton
        /// </summary>
        public SmokehouseSkeleton()
        {
            this.Egg = true;
            this.HashBrowns = true;
            this.Pancake = true;
            this.SausageLink = true;
        }

        /// <value>
        /// Gets the Price of the dish
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// gets the calories of the dish
        /// </value>
        public override uint Calories => 602;

        private bool sausageLink = true;
        /// <value>
        /// gets & sets the sausage link preference
        /// </value>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                OnPropertyChanged("SausageLink");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <value>
        /// gets & sets the egg preference
        /// </value>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                OnPropertyChanged("Egg");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool hashBrowns = true;
        /// <value>
        /// gets & sets the hash browns preference
        /// </value>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
                OnPropertyChanged("HashBrowns");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool pancake = true;
        /// <value>
        /// gets & sets the sirloin preference
        /// </value>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                OnPropertyChanged("Pancake");
                OnPropertyChanged("SpecialInstructions");

            }
        }


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
