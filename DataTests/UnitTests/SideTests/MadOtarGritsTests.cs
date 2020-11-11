/*
 * Author: Zachery Brunner
 * Modified By: Bella Goddard
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", mo.Description);
        }

        [Fact]
        public void ShouldBeAIPropChangedItem()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mo);
        }


        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var mo = new MadOtarGrits();

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Large;
            });

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Medium;
            });
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesCalProperty()
        {
            var mo = new MadOtarGrits();

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Large;
                mo.Calories.Equals(179);
            });

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Medium;
                mo.Calories.Equals(142);

            });
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Small;
                mo.Calories.Equals(105);
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var mo = new MadOtarGrits();

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Large;
                mo.Price.Equals(1.93);
            });

            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Medium;
                mo.Price.Equals(1.58);

            });
            Assert.PropertyChanged(mo, "Size", () =>
            {
                mo.Size = Size.Small;
                mo.Price.Equals(1.22);
            });
        }

        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mo);
        }

        [Fact]
        public void ShouldBeAIOrderItem()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mo);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(price, mo.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(name, mo.ToString());
        }
    }
}