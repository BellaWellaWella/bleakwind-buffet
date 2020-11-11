/*
* Author: Bella Goddard
* Class name: ThalmorTriple
* Purpose: To create the model for the Thalmor Triple
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{

    /// <summary>
    /// A class that represents the entree, Thlmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// constructor for Thalmor Triple
        /// </summary>
        public ThalmorTriple()
        {
            this.Ketchup = true;
            this.Bun = true;
            this.Mustard = true;
            this.Pickle = true;
            this.Cheese = true;
            this.Tomato = true;
            this.Lettuce = true;
            this.Mayo = true;
            this.Bacon = true;
            this.Egg = true;
        }

        /// <value>
        /// Gets the Price of the burger
        /// </value>
        public override double Price => 8.32;

        /// <value>
        /// gets the calories of the burger
        /// </value>
        public override uint Calories => 943;

        private bool ketchup = true;
        /// <value>
        /// gets & sets the ketchup preference
        /// </value>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                OnPropertyChanged("Ketchup");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool bun = true;
        /// <value>
        /// gets & sets the bun preference
        /// </value>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                OnPropertyChanged("Bun");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <value>
        /// gets & sets the mustard preference
        /// </value>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                OnPropertyChanged("Mustard");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <value>
        /// gets & sets the pickle preference
        /// </value>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                OnPropertyChanged("Pickle");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <value>
        /// gets & sets the cheese preference
        /// </value>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                OnPropertyChanged("Cheese");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool tomato = true;
        /// <value>
        /// gets & sets the tomato preference
        /// </value>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                OnPropertyChanged("Tomato");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool lettuce = true;
        /// <value>
        /// gets & sets the lettuce preference
        /// </value>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                OnPropertyChanged("Lettuce");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <value>
        /// gets & sets the mayo preference
        /// </value>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                OnPropertyChanged("Mayo");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <value>
        /// gets & sets the bacon preference
        /// </value>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                OnPropertyChanged("Bacon");
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

        /// <value>
        /// sets up the special instructions
        /// </value>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get { return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }
        }
    }
}
