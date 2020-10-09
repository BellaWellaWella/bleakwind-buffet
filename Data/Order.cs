using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Declaring the event handler for PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// method to handle property change
        /// </summary>
        /// <param name="propertyName">the property that is being changed</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            var handler = CollectionChanged;
            if (handler != null)
                handler(this, args);
        }


        //inner list to hold order
        Collection<IOrderItem> orderItems = new Collection<IOrderItem>();

        /// <summary>
        /// constructor for the order class
        /// </summary>
        public Order(){
            Number = nextOrderNumber;
            nextOrderNumber++;
            orderItems = new Collection<IOrderItem>();
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
                foreach(IOrderItem item in orderItems)
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

        private uint totalCalories;
        /// <summary>
        /// the calories for the entire order
        /// </summary>
        public double TotalCalories
        {
            get
            {
                foreach(IOrderItem item in orderItems)
                {
                    totalCalories += item.Calories;
                }
                return totalCalories;
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

        public int Count
        {
            get
            {
                return orderItems.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// method to add an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Total");
            OnPropertyChanged("TotalCalories");
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, orderItems));
            item.PropertyChanged += ItemEventChange;
        }

        /// <summary>
        /// method to remove an item from the order
        /// </summary>
        /// <param name="item"></param>
        /// <returns>true or false if item was removed or not</returns>
        public bool Remove(IOrderItem item)
        {
            if (orderItems.Contains(item))
            {
                orderItems.Remove(item);
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, orderItems));
                OnPropertyChanged("Subtotal");
                OnPropertyChanged("Tax");
                OnPropertyChanged("Total");
                OnPropertyChanged("TotalCalories");
                item.PropertyChanged -= ItemEventChange;

                return true;
            }
            return false;
        }

        /// <summary>
        /// clears the list order
        /// </summary>
        public void Clear()
        {
            orderItems.Clear();
        }

        /// <summary>
        /// determines if the item is in the list order
        /// </summary>
        /// <param name="item"> the thing we are looking for</param>
        /// <returns>T/F based on if it is in the list</returns>
        public bool Contains(IOrderItem item)
        {
            bool found = false;

            foreach(IOrderItem thing in orderItems)
            {
                if (thing.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            if(array == null)
            {
                throw new ArgumentNullException("The array cannot be null");
            }
            if(arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative");
            }

            for (int i = 0; i < orderItems.Count; i++)
            {
                array[i + arrayIndex] = orderItems[i];
            }
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            throw new NotImplementedException();    
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void ItemEventChange(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged("Subtotal");
                OnPropertyChanged("Tax");
                OnPropertyChanged("Total");
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged("TotalCalories");
            }
        }
    }
}
