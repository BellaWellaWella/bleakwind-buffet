using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    public class CashModelView
    {

        public double Total
        {
            get { return CashDrawer.Total; }
        }
        
        //Drawer Money Variables
        /// <summary>
        /// Drawer number of  Hundred Dollar Bills
        /// </summary>
        public int DrawerHundred => CashDrawer.Hundreds;
        /// <summary>
        /// Drawer number of  Fifty Dollar Bills
        /// </summary>
        public int DrawerFifty => CashDrawer.Fifties;
        /// <summary>
        /// Drawer number of  Twenty Dollar Bills
        /// </summary>
        public int DrawerTwenty => CashDrawer.Twenties;
        /// <summary>
        /// Drawer number of  Ten Dollar Bills
        /// </summary>
        public int DrawerTen => CashDrawer.Tens;
        /// <summary>
        /// Drawer number of  Five Dollar Bills
        /// </summary>
        public int DrawerFive => CashDrawer.Fives;
        /// <summary>
        /// Drawer number of  Two Dollar Bills
        /// </summary>
        public int DrawerTwo => CashDrawer.Twos;
        /// <summary>
        /// Drawer number of  One Dollar Bills
        /// </summary>
        public int DrawerOneBill => CashDrawer.Ones;

        /// <summary>
        /// Drawer number of  One Dollar Coins
        /// </summary>
        public int DrawerOneCoin => CashDrawer.Dollars;
        /// <summary>
        /// Drawer number of  Fifty Cent Coins
        /// </summary>
        public int DrawerFiftyCent => CashDrawer.HalfDollars;
        /// <summary>
        /// Drawer number of  TwentyFive Cent Coins
        /// </summary>
        public int DrawerTwentyFiveCent => CashDrawer.Quarters;
        /// <summary>
        /// Drawer number of  Ten Cent Coins
        /// </summary>
        public int DrawerTenCent => CashDrawer.Dimes;
        /// <summary>
        /// Drawer number of  Five Cent Coins
        /// </summary>
        public int DrawerFiveCent => CashDrawer.Nickels;
        /// <summary>
        /// Drawer number of  One Cent Coins
        /// </summary>
        public int DrawerOneCent => CashDrawer.Pennies;

        //Customer Payed Money Variables
        public int PayedHundered;
        public int PayedFifty;
        public int PayedTwenty;
        public int PayedTen;
        public int PayedFive;
        public int PayedTwo;
        public int PayedOneBill;
        public int PayedOneCoin;
        public int PayedFiftyCent;
        public int PayedTwentyFiveCent;
        public int PayedTenCent;
        public int PayedFiveCent;
        public int PayedOneCent;


        //Change Money Variables
        public int ChangeHundered;
        public int ChangeFifty;
        public int ChangeTwenty;
        public int ChangeTen;
        public int ChangeFive;
        public int ChangeTwo;
        public int ChangeOneBill;
        public int ChangeOneCoin;
        public int ChangeFiftyCent;
        public int ChangeTwentyFiveCent;
        public int ChangeTenCent;
        public int ChangeFiveCent;
        public int ChangeOneCent;


    }
}
