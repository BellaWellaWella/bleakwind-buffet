using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone
    {
        /// <summary>
        /// Gets the Price of the t-bone
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// gets the calories of the t-bone
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// sets up the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }

        }

        /// <summary>
        /// ovverides the to string method
        /// </summary>
        /// <returns> the new string </returns>
        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
