﻿/*
 * Author: Zachery Brunner
 * Modified by: Bella Goddard
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", dw.Description);
        }

        [Fact]
        public void ShouldBeAIPropChangedItem()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dw);
        }


        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var dw = new DragonbornWaffleFries();

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Large;
            });

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Medium;
            });
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCalProperty()
        {
            var dw = new DragonbornWaffleFries();

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Large;
                dw.Calories.Equals(100);
            });

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Medium;
                dw.Calories.Equals(89);

            });
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Small;
                dw.Calories.Equals(77);
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var dw = new DragonbornWaffleFries();

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Large;
                dw.Price.Equals(.96);
            });

            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Medium;
                dw.Price.Equals(.76);

            });
            Assert.PropertyChanged(dw, "Size", () =>
            {
                dw.Size = Size.Small;
                dw.Price.Equals(.42);
            });
        }

        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dw);
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dw);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dw =  new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = Size.Large;
            Assert.Equal(Size.Large, dw.Size);
            dw.Size = Size.Medium;
            Assert.Equal(Size.Medium, dw.Size);
            dw.Size = Size.Small;
            Assert.Equal(Size.Small, dw.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Empty(dw.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(price, dw.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(calories, dw.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(name, dw.ToString());
        }
    }
}