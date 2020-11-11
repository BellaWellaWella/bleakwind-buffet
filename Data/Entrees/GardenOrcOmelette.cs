/*
* Author: Bella Goddard
* Class name: GardenOrcOmlette
* Purpose: To create the model for the omelette
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the entree, Garden Orc Omlette
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    { 
        /// <summary>
        /// constructor for Garden orc omelette
        /// </summary>
        public GardenOrcOmelette()
        {
            this.Broccoli = true;
            this.Mushrooms = true;
            this.Tomato = true;
            this.Cheddar = true;
        }

        /// <value>
        /// Gets the Price of the omelette
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// gets the calories of the omelette
        /// </value>
        public override uint Calories => 404;

        private bool broccoli = true;
        /// <value>
        /// gets & sets the broccoli preference
        /// </value>
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                OnPropertyChanged("Broccoli");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        private bool mushrooms = true;
        /// <value>
        /// gets & sets the mushroom preference
        /// </value>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                OnPropertyChanged("Mushrooms");
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

        private bool cheddar = true;
        /// <value>
        /// gets & sets the cheddar preference
        /// </value>
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                OnPropertyChanged("Cheddar");
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

        /// <summary>
        /// The description of the item
        /// </summary>
        public override string Description
        {
            get { return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; }
        }
    }
}
