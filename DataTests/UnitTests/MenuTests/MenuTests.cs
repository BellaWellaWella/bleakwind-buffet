/*
 * Author: Bella Goddard
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnSides()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mo = new MadOtarGrits();
            VokunSalad vs = new VokunSalad();

            DragonbornWaffleFries Mdw = new DragonbornWaffleFries();
            FriedMiraak Mfm = new FriedMiraak();
            MadOtarGrits Mmo = new MadOtarGrits();
            VokunSalad Mvs = new VokunSalad();

            DragonbornWaffleFries Ldw = new DragonbornWaffleFries();
            FriedMiraak Lfm = new FriedMiraak();
            MadOtarGrits Lmo = new MadOtarGrits();
            VokunSalad Lvs = new VokunSalad();

            Mdw.Size = Size.Medium;
            Mfm.Size = Size.Medium;
            Mmo.Size = Size.Medium;
            Mvs.Size = Size.Medium;

            Ldw.Size = Size.Large;
            Lfm.Size = Size.Large;
            Lmo.Size = Size.Large;
            Lvs.Size = Size.Large;

            Assert.Collection<IOrderItem>(Menu.Sides(),
                item => Assert.Equal(item.ToString(), Lfm.ToString()),
                item => Assert.Equal(item.ToString(), Mfm.ToString()),
                item => Assert.Equal(item.ToString(), fm.ToString()),
                item => Assert.Equal(item.ToString(), Ldw.ToString()),
                item => Assert.Equal(item.ToString(), Mdw.ToString()),
                item => Assert.Equal(item.ToString(), dw.ToString()),
                item => Assert.Equal(item.ToString(), Lmo.ToString()),
                item => Assert.Equal(item.ToString(), Mmo.ToString()),
                item => Assert.Equal(item.ToString(), mo.ToString()),
                item => Assert.Equal(item.ToString(), Lvs.ToString()),
                item => Assert.Equal(item.ToString(), Mvs.ToString()),
                item => Assert.Equal(item.ToString(), vs.ToString()));


        }

        [Fact]
        public void ShouldReturnDrinks()
        {
            AretinoAppleJuice Laa = new AretinoAppleJuice();
            Laa.Size = Size.Large;
            AretinoAppleJuice Maa = new AretinoAppleJuice();
            Maa.Size = Size.Medium;
            AretinoAppleJuice Saa = new AretinoAppleJuice();

            CandlehearthCoffee Lcc = new CandlehearthCoffee();
            Lcc.Size = Size.Large;
            CandlehearthCoffee Mcc = new CandlehearthCoffee();
            Mcc.Size = Size.Medium;
            CandlehearthCoffee Scc = new CandlehearthCoffee();
            

            CandlehearthCoffee DLcc = new CandlehearthCoffee();
            DLcc.Size = Size.Large;
            DLcc.Decaf = true;
            CandlehearthCoffee DMcc = new CandlehearthCoffee();
            DMcc.Size = Size.Medium;
            DMcc.Decaf = true;
            CandlehearthCoffee DScc = new CandlehearthCoffee();
            DScc.Decaf = true;

            MarkarthMilk Lmm = new MarkarthMilk();
            Lmm.Size = Size.Large;
            MarkarthMilk Mmm = new MarkarthMilk();
            Mmm.Size = Size.Medium;
            MarkarthMilk Smm = new MarkarthMilk();

            WarriorWater Lww = new WarriorWater();
            Lww.Size = Size.Large;
            WarriorWater Mww = new WarriorWater();
            Mww.Size = Size.Medium;
            WarriorWater Sww = new WarriorWater();


            //Blackberry Sailor Soda
            SailorSoda BLss = new SailorSoda();
            BLss.Size = Size.Large;
            BLss.Flavor = SodaFlavor.Blackberry;
            SailorSoda BMss = new SailorSoda();
            BMss.Size = Size.Medium;
            BMss.Flavor = SodaFlavor.Blackberry;
            SailorSoda BSss = new SailorSoda();
            BSss.Size = Size.Small;
            BSss.Flavor = SodaFlavor.Blackberry;
            

            //Cherry Sailor Soda
            SailorSoda CLss = new SailorSoda();
            CLss.Flavor = SodaFlavor.Cherry;
            CLss.Size = Size.Large;
            SailorSoda CMss = new SailorSoda();
            CMss.Size = Size.Medium;
            CMss.Flavor = SodaFlavor.Cherry;
            SailorSoda CSss = new SailorSoda();
            CSss.Size = Size.Small;
            CSss.Flavor = SodaFlavor.Cherry;
           

            //Grapefruit Sailor Soda
            SailorSoda GLss = new SailorSoda();
            GLss.Size = Size.Large;
            GLss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GMss = new SailorSoda();
            GMss.Size = Size.Medium;
            GMss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GSss = new SailorSoda();
            GSss.Size = Size.Small;
            GMss.Flavor = SodaFlavor.Grapefruit;


            //Lemon Sailor Soda
            SailorSoda LLss = new SailorSoda();
            LLss.Size = Size.Large;
            LLss.Flavor = SodaFlavor.Lemon;
            SailorSoda LMss = new SailorSoda();
            LMss.Size = Size.Medium;
            LMss.Flavor = SodaFlavor.Lemon;
            SailorSoda LSss = new SailorSoda();
            LSss.Size = Size.Small;
            LSss.Flavor = SodaFlavor.Lemon;


            //Peach Sailor Soda
            SailorSoda PLss = new SailorSoda();
            PLss.Size = Size.Large;
            PLss.Flavor = SodaFlavor.Peach;
            SailorSoda PMss = new SailorSoda();
            PMss.Size = Size.Medium;
            PMss.Flavor = SodaFlavor.Peach;
            SailorSoda PSss = new SailorSoda();
            PSss.Size = Size.Small;
            PSss.Flavor = SodaFlavor.Peach;


            //Watermelon Sailor Soda
            SailorSoda WLss = new SailorSoda();
            WLss.Size = Size.Large;
            WLss.Flavor = SodaFlavor.Watermelon;
            SailorSoda WMss = new SailorSoda();
            WMss.Size = Size.Medium;
            WMss.Flavor = SodaFlavor.Watermelon;
            SailorSoda WSss = new SailorSoda();
            WSss.Size = Size.Small;
            WMss.Flavor = SodaFlavor.Watermelon;

            Assert.Collection<IOrderItem>(Menu.Drinks(),
                item => Assert.Equal(item.ToString(), Laa.ToString()),
                item => Assert.Equal(item.ToString(), Maa.ToString()),
                item => Assert.Equal(item.ToString(), Saa.ToString()),
                item => Assert.Equal(item.ToString(), Lcc.ToString()),
                item => Assert.Equal(item.ToString(), Mcc.ToString()),
                item => Assert.Equal(item.ToString(), Scc.ToString()),
                item => Assert.Equal(item.ToString(), DLcc.ToString()),
                item => Assert.Equal(item.ToString(), DMcc.ToString()),
                item => Assert.Equal(item.ToString(), DScc.ToString()),
                item => Assert.Equal(item.ToString(), Lmm.ToString()),
                item => Assert.Equal(item.ToString(), Mmm.ToString()),
                item => Assert.Equal(item.ToString(), Smm.ToString()),
                item => Assert.Equal(item.ToString(), Lww.ToString()),
                item => Assert.Equal(item.ToString(), Mww.ToString()),
                item => Assert.Equal(item.ToString(), Sww.ToString()),
                item => Assert.Equal(item.ToString(), BLss.ToString()),
                item => Assert.Equal(item.ToString(), BMss.ToString()),
                item => Assert.Equal(item.ToString(), BSss.ToString()),
                item => Assert.Equal(item.ToString(), CLss.ToString()),
                item => Assert.Equal(item.ToString(), CMss.ToString()),
                item => Assert.Equal(item.ToString(), CSss.ToString()),
                item => Assert.Equal(item.ToString(), GLss.ToString()),
                item => Assert.Equal(item.ToString(), GMss.ToString()),
                item => Assert.Equal(item.ToString(), GSss.ToString()),
                item => Assert.Equal(item.ToString(), LLss.ToString()),
                item => Assert.Equal(item.ToString(), LMss.ToString()),
                item => Assert.Equal(item.ToString(), LSss.ToString()),
                item => Assert.Equal(item.ToString(), PLss.ToString()),
                item => Assert.Equal(item.ToString(), PMss.ToString()),
                item => Assert.Equal(item.ToString(), PSss.ToString()),
                item => Assert.Equal(item.ToString(), WLss.ToString()),
                item => Assert.Equal(item.ToString(), WMss.ToString()),
                item => Assert.Equal(item.ToString(), WSss.ToString()));
        }

        [Fact]
        public void ShouldReturnEntrees()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette go = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();


            Assert.Collection<IOrderItem>(Menu.Entrees(),
                item => Assert.Equal(item.ToString(), bb.ToString()),
                item => Assert.Equal(item.ToString(), dd.ToString()),
                item => Assert.Equal(item.ToString(), go.ToString()),
                item => Assert.Equal(item.ToString(), pp.ToString()),
                item => Assert.Equal(item.ToString(), ss.ToString()),
                item => Assert.Equal(item.ToString(), tt.ToString()),
                item => Assert.Equal(item.ToString(), ttb.ToString()));

                
        }

        [Fact]
        public void ShouldReturnEverything()
        {
            AretinoAppleJuice Laa = new AretinoAppleJuice();
            Laa.Size = Size.Large;
            AretinoAppleJuice Maa = new AretinoAppleJuice();
            Maa.Size = Size.Medium;
            AretinoAppleJuice Saa = new AretinoAppleJuice();

            CandlehearthCoffee Lcc = new CandlehearthCoffee();
            Lcc.Size = Size.Large;
            CandlehearthCoffee Mcc = new CandlehearthCoffee();
            Mcc.Size = Size.Medium;
            CandlehearthCoffee Scc = new CandlehearthCoffee();


            CandlehearthCoffee DLcc = new CandlehearthCoffee();
            DLcc.Size = Size.Large;
            DLcc.Decaf = true;
            CandlehearthCoffee DMcc = new CandlehearthCoffee();
            DMcc.Size = Size.Medium;
            DMcc.Decaf = true;
            CandlehearthCoffee DScc = new CandlehearthCoffee();
            DScc.Decaf = true;

            MarkarthMilk Lmm = new MarkarthMilk();
            Lmm.Size = Size.Large;
            MarkarthMilk Mmm = new MarkarthMilk();
            Mmm.Size = Size.Medium;
            MarkarthMilk Smm = new MarkarthMilk();

            WarriorWater Lww = new WarriorWater();
            Lww.Size = Size.Large;
            WarriorWater Mww = new WarriorWater();
            Mww.Size = Size.Medium;
            WarriorWater Sww = new WarriorWater();


            //Blackberry Sailor Soda
            SailorSoda BLss = new SailorSoda();
            BLss.Size = Size.Large;
            BLss.Flavor = SodaFlavor.Blackberry;
            SailorSoda BMss = new SailorSoda();
            BMss.Size = Size.Medium;
            BMss.Flavor = SodaFlavor.Blackberry;
            SailorSoda BSss = new SailorSoda();
            BSss.Size = Size.Small;
            BSss.Flavor = SodaFlavor.Blackberry;


            //Cherry Sailor Soda
            SailorSoda CLss = new SailorSoda();
            CLss.Flavor = SodaFlavor.Cherry;
            CLss.Size = Size.Large;
            SailorSoda CMss = new SailorSoda();
            CMss.Size = Size.Medium;
            CMss.Flavor = SodaFlavor.Cherry;
            SailorSoda CSss = new SailorSoda();
            CSss.Size = Size.Small;
            CSss.Flavor = SodaFlavor.Cherry;


            //Grapefruit Sailor Soda
            SailorSoda GLss = new SailorSoda();
            GLss.Size = Size.Large;
            GLss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GMss = new SailorSoda();
            GMss.Size = Size.Medium;
            GMss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GSss = new SailorSoda();
            GSss.Size = Size.Small;
            GMss.Flavor = SodaFlavor.Grapefruit;


            //Lemon Sailor Soda
            SailorSoda LLss = new SailorSoda();
            LLss.Size = Size.Large;
            LLss.Flavor = SodaFlavor.Lemon;
            SailorSoda LMss = new SailorSoda();
            LMss.Size = Size.Medium;
            LMss.Flavor = SodaFlavor.Lemon;
            SailorSoda LSss = new SailorSoda();
            LSss.Size = Size.Small;
            LSss.Flavor = SodaFlavor.Lemon;


            //Peach Sailor Soda
            SailorSoda PLss = new SailorSoda();
            PLss.Size = Size.Large;
            PLss.Flavor = SodaFlavor.Peach;
            SailorSoda PMss = new SailorSoda();
            PMss.Size = Size.Medium;
            PMss.Flavor = SodaFlavor.Peach;
            SailorSoda PSss = new SailorSoda();
            PSss.Size = Size.Small;
            PSss.Flavor = SodaFlavor.Peach;


            //Watermelon Sailor Soda
            SailorSoda WLss = new SailorSoda();
            WLss.Size = Size.Large;
            WLss.Flavor = SodaFlavor.Watermelon;
            SailorSoda WMss = new SailorSoda();
            WMss.Size = Size.Medium;
            WMss.Flavor = SodaFlavor.Watermelon;
            SailorSoda WSss = new SailorSoda();
            WSss.Size = Size.Small;
            WMss.Flavor = SodaFlavor.Watermelon;

            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette go = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();

            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            FriedMiraak fm = new FriedMiraak();
            MadOtarGrits mo = new MadOtarGrits();
            VokunSalad vs = new VokunSalad();

            DragonbornWaffleFries Mdw = new DragonbornWaffleFries();
            FriedMiraak Mfm = new FriedMiraak();
            MadOtarGrits Mmo = new MadOtarGrits();
            VokunSalad Mvs = new VokunSalad();

            DragonbornWaffleFries Ldw = new DragonbornWaffleFries();
            FriedMiraak Lfm = new FriedMiraak();
            MadOtarGrits Lmo = new MadOtarGrits();
            VokunSalad Lvs = new VokunSalad();

            Mdw.Size = Size.Medium;
            Mfm.Size = Size.Medium;
            Mmo.Size = Size.Medium;
            Mvs.Size = Size.Medium;

            Ldw.Size = Size.Large;
            Lfm.Size = Size.Large;
            Lmo.Size = Size.Large;
            Lvs.Size = Size.Large;

            Assert.Collection<IOrderItem>(Menu.FullMenu(),
                 item => Assert.Equal(item.ToString(), Laa.ToString()),
                item => Assert.Equal(item.ToString(), Maa.ToString()),
                item => Assert.Equal(item.ToString(), Saa.ToString()),
                item => Assert.Equal(item.ToString(), Lcc.ToString()),
                item => Assert.Equal(item.ToString(), Mcc.ToString()),
                item => Assert.Equal(item.ToString(), Scc.ToString()),
                item => Assert.Equal(item.ToString(), DLcc.ToString()),
                item => Assert.Equal(item.ToString(), DMcc.ToString()),
                item => Assert.Equal(item.ToString(), DScc.ToString()),
                item => Assert.Equal(item.ToString(), Lmm.ToString()),
                item => Assert.Equal(item.ToString(), Mmm.ToString()),
                item => Assert.Equal(item.ToString(), Smm.ToString()),
                item => Assert.Equal(item.ToString(), Lww.ToString()),
                item => Assert.Equal(item.ToString(), Mww.ToString()),
                item => Assert.Equal(item.ToString(), Sww.ToString()),
                item => Assert.Equal(item.ToString(), BLss.ToString()),
                item => Assert.Equal(item.ToString(), BMss.ToString()),
                item => Assert.Equal(item.ToString(), BSss.ToString()),
                item => Assert.Equal(item.ToString(), CLss.ToString()),
                item => Assert.Equal(item.ToString(), CMss.ToString()),
                item => Assert.Equal(item.ToString(), CSss.ToString()),
                item => Assert.Equal(item.ToString(), GLss.ToString()),
                item => Assert.Equal(item.ToString(), GMss.ToString()),
                item => Assert.Equal(item.ToString(), GSss.ToString()),
                item => Assert.Equal(item.ToString(), LLss.ToString()),
                item => Assert.Equal(item.ToString(), LMss.ToString()),
                item => Assert.Equal(item.ToString(), LSss.ToString()),
                item => Assert.Equal(item.ToString(), PLss.ToString()),
                item => Assert.Equal(item.ToString(), PMss.ToString()),
                item => Assert.Equal(item.ToString(), PSss.ToString()),
                item => Assert.Equal(item.ToString(), WLss.ToString()),
                item => Assert.Equal(item.ToString(), WMss.ToString()),
                item => Assert.Equal(item.ToString(), WSss.ToString()),
                item => Assert.Equal(item.ToString(), bb.ToString()),
                item => Assert.Equal(item.ToString(), dd.ToString()),
                item => Assert.Equal(item.ToString(), go.ToString()),
                item => Assert.Equal(item.ToString(), pp.ToString()),
                item => Assert.Equal(item.ToString(), ss.ToString()),
                item => Assert.Equal(item.ToString(), tt.ToString()),
                item => Assert.Equal(item.ToString(), ttb.ToString()),
                item => Assert.Equal(item.ToString(), Lfm.ToString()),
                item => Assert.Equal(item.ToString(), Mfm.ToString()),
                item => Assert.Equal(item.ToString(), fm.ToString()),
                item => Assert.Equal(item.ToString(), Ldw.ToString()),
                item => Assert.Equal(item.ToString(), Mdw.ToString()),
                item => Assert.Equal(item.ToString(), dw.ToString()),
                item => Assert.Equal(item.ToString(), Lmo.ToString()),
                item => Assert.Equal(item.ToString(), Mmo.ToString()),
                item => Assert.Equal(item.ToString(), mo.ToString()),
                item => Assert.Equal(item.ToString(), Lvs.ToString()),
                item => Assert.Equal(item.ToString(), Mvs.ToString()),
                item => Assert.Equal(item.ToString(), vs.ToString()));
        }
    }
}
