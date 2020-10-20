/*
 * Author: Bella Goddard
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Linq;

namespace BleakwindBuffet.DataTests
{
    public class ComboTests
    {

        [Fact]
        public void ItemsChangedIsComboChanged()
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
            Combo c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new WarriorWater();
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesPriceProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new WarriorWater();
                //c.Price.Equals(c.Drink.Price + c.Entree.Price + c.Side.Price);
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesCalProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Drink = new WarriorWater();
                //c.Calories.Equals(c.Drink.Calories + c.Entree.Calories + c.Side.Calories);
            });
        }

        [Fact]
        public void ChangingDrinkNotifiesSIProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = new WarriorWater();
                //c.SpecialInstructions.Contains(c.Drink.SpecialInstructions.ToString());
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesPriceProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Entree = new SmokehouseSkeleton();
                //c.Price.Equals(c.Drink.Price + c.Entree.Price + c.Side.Price);
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesCalProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Entree = new SmokehouseSkeleton();
                //c.Calories.Equals(c.Drink.Calories + c.Entree.Calories + c.Side.Calories);
            });
        }

        [Fact]
        public void ChangingEntreeNotifiesSIProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Drink = new WarriorWater();
                //c.SpecialInstructions.Contains(c.Drink.SpecialInstructions.ToString());
            });
        }

        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new VokunSalad();
            });
        }

        [Fact]
        public void ChangingSideNotifiesPriceProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Side = new VokunSalad();
                //c.Price.Equals(c.Drink.Price + c.Entree.Price + c.Side.Price);
            });
        }

        [Fact]
        public void ChangingSideNotifiesCalProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Side = new VokunSalad();
                //c.Calories.Equals(c.Drink.Calories + c.Entree.Calories + c.Side.Calories);
            });
        }

        [Fact]
        public void ChangingSideNotifiesSIProperty()
        {
            Combo c = new Combo();
            c.Drink = new AretinoAppleJuice();
            c.Entree = new BriarheartBurger();
            c.Side = new DragonbornWaffleFries();

            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Side = new VokunSalad();
                //c.SpecialInstructions.Contains(c.Drink.SpecialInstructions.ToString());
            });
        }
    }
}
