using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order
    {
        List<IOrderItem> order = new List<IOrderItem>();

        /// <summary>
        /// constructor for the order class
        /// </summary>
        public Order(){
            Number = nextOrderNumber;
            nextOrderNumber++;
        }


        private double salesTaxRate = 0.12;
        /// <summary>
        /// the sales tax rate 
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            private set
            {
                salesTaxRate = value;
            }
        }

        private double subtotal;
        /// <summary>
        /// the subtotal is the sum of all of the menu items in the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                foreach(IOrderItem item in order)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        private double tax;
        /// <summary>
        /// the tax is the sales tax times the subtotal
        /// </summary>
        public double Tax
        {
            get
            {

                tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }

        private double total;
        /// <summary>
        /// the total is the tax for the order plus the subtotal
        /// </summary>
        public double Total
        {
            get
            {
                total = Tax + Subtotal;
                return total;
            }
        }

        private uint calories;
        /// <summary>
        /// the calories for the entire order
        /// </summary>
        public double Calories
        {
            get
            {
                foreach(IOrderItem item in order)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        private static int nextOrderNumber = 1;
        /// <summary>
        /// represents the order number, each number should be unique
        /// </summary>
        public int Number
        {
            get
            {
                return nextOrderNumber;
            }
            private set
            {
                nextOrderNumber = value;
            }
        }

        /// <summary>
        /// method to add an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            order.Add(item);
        }

        /// <summary>
        /// method to remove an item from the order
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true or false if item was removed or not</returns>
        public bool Remove(IOrderItem item)
        {
            if (order.Contains(item))
            {
                order.Remove(item);
                return true;
            }
            return false;
        }
    }
}
