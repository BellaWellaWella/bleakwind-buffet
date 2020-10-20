/*
 * Author: Bella Goddard
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using Xunit;
using System.Collections.Specialized;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests
{
    public class OrderTests
    {
        [Fact]
        public void ItemsChangedIsOrderChanged()
        {
            Combo c = new Combo();

            BriarheartBurger bb = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            c.Entree = bb;
            c.Drink = aa;
            c.Side = dw;

            Assert.PropertyChanged(c, "Drink", () =>
            {
                aa.Size = Size.Large;
                c.Drink = aa;
            });
        }

        [Fact]
        public void ShouldBeAIPropChangedItem()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        [Fact]
        public void ShouldBeAICollectionChangedItem()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }

        [Fact]
        public void ShouldBeAICollectionItem()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<ICollection<IOrderItem>>(o);
        }

        [Fact]
        public void AddingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();
            o.Add(new BriarheartBurger());
            

            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(new SailorSoda());
            });
        }

        [Fact]
        public void AddingItemNotifiesTaxProperty()
        {
            Order o = new Order();
            o.Add(new BriarheartBurger());


            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(new SailorSoda());
            });
        }

        [Fact]
        public void AddingItemNotifiesTotalProperty()
        {
            Order o = new Order();
            o.Add(new BriarheartBurger());


            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(new SailorSoda());
            });
        }

        [Fact]
        public void AddingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();
            o.Add(new BriarheartBurger());


            Assert.PropertyChanged(o, "TotalCalories", () =>
            {
                o.Add(new SailorSoda());
            });
        }

        [Fact]
        public void RemovingItemNotifiesSubtotalProperty()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);


            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTaxProperty()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);


            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTotalProperty()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);


            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Remove(b);
            });
        }

        [Fact]
        public void RemovingItemNotifiesCaloriesProperty()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            o.Add(b);


            Assert.PropertyChanged(o, "TotalCalories", () =>
            {
                o.Remove(b);
            });
        }
        
    }
}
