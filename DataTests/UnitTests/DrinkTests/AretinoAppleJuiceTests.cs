/*
 * Author: Zachery Brunner
 * Modified By: Bella Goddard
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", aj.Description);
        }

        [Fact]
        public void ShouldBeAIPropChangedItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var aj = new AretinoAppleJuice();

            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });

            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var aa = new AretinoAppleJuice();

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Large;
            });

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Medium;
            });
            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCalProperty()
        {
            var aa = new AretinoAppleJuice();

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Large;
                aa.Calories.Equals(132);
            });

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Medium;
                aa.Calories.Equals(88);

            });
            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Small;
                aa.Calories.Equals(44);
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var aa = new AretinoAppleJuice();

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Large;
                aa.Price.Equals(1.01);
            });

            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Medium;
                aa.Price.Equals(.87);

            });
            Assert.PropertyChanged(aa, "Size", () =>
            {
                aa.Size = Size.Small;
                aa.Price.Equals(.62);
            });
        }


        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);

        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice
            {
                Ice = true
            };
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);


        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice
            {
                Size = size
            };
            Assert.Equal(name, aj.ToString());
        }
    }
}