/*
* Author: Bella Goddard
* Class name: Menu
* Purpose: To create the model for menu
*/

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BleakwindBuffet.Data.Menu
{
    public static class Menu
    {
        /// <summary>
        /// A method to return all entrees
        /// </summary>
        /// <returns> an iEnumerable list of all entrees</returns>
        public static IEnumerable<IOrderItem>  Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            
            foreach (IOrderItem entree in entrees)
            {
                Console.WriteLine(entree.ToString());
            }
            return entrees;
        }

        /// <summary>
        /// A method to list all of the sides
        /// </summary>
        /// <returns> an iEnumerable list of all sides </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            FriedMiraak LMirak = new FriedMiraak();
            LMirak.Size = Size.Large;
            FriedMiraak MMirak = new FriedMiraak();
            MMirak.Size = Size.Medium;
            FriedMiraak SMirak = new FriedMiraak();
            SMirak.Size = Size.Small;
            sides.Add(LMirak);
            sides.Add(MMirak);
            sides.Add(SMirak);

            DragonbornWaffleFries Ldw = new DragonbornWaffleFries();
            Ldw.Size = Size.Large;
            DragonbornWaffleFries mdw = new DragonbornWaffleFries();
            mdw.Size = Size.Medium;
            DragonbornWaffleFries sdw = new DragonbornWaffleFries();
            sdw.Size = Size.Small;
            sides.Add(Ldw);
            sides.Add(mdw);
            sides.Add(sdw);

            MadOtarGrits lmo = new MadOtarGrits();
            lmo.Size = Size.Large;
            MadOtarGrits mmo = new MadOtarGrits();
            mmo.Size = Size.Medium;
            MadOtarGrits smo = new MadOtarGrits();
            smo.Size = Size.Small;
            sides.Add(lmo);
            sides.Add(mmo);
            sides.Add(smo);

            VokunSalad lvs = new VokunSalad();
            lvs.Size = Size.Large;
            VokunSalad mvs = new VokunSalad();
            mvs.Size = Size.Medium;
            VokunSalad svs = new VokunSalad();
            svs.Size = Size.Small;
            sides.Add(lvs);
            sides.Add(mvs);
            sides.Add(svs);
            
            foreach (IOrderItem side in sides)
            {
                Console.WriteLine(side.ToString());
            }
            return sides;
        }

        /// <summary>
        /// A method to list all drink options
        /// </summary>
        /// <returns>an IEnumerable list of all drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();


            AretinoAppleJuice Laa = new AretinoAppleJuice();
            Laa.Size = Size.Large;
            AretinoAppleJuice Maa = new AretinoAppleJuice();
            Maa.Size = Size.Medium;
            AretinoAppleJuice Saa = new AretinoAppleJuice();
            Saa.Size = Size.Small;
            drinks.Add(Laa);
            drinks.Add(Maa);
            drinks.Add(Saa);

            CandlehearthCoffee Lcc = new CandlehearthCoffee();
            Lcc.Size = Size.Large;
            CandlehearthCoffee Mcc = new CandlehearthCoffee();
            Mcc.Size = Size.Medium;
            CandlehearthCoffee Scc = new CandlehearthCoffee();
            Scc.Size = Size.Small;
            drinks.Add(Lcc);
            drinks.Add(Mcc);
            drinks.Add(Scc);

            CandlehearthCoffee DLcc = new CandlehearthCoffee();
            DLcc.Size = Size.Large;
            DLcc.Decaf = true;
            CandlehearthCoffee DMcc = new CandlehearthCoffee();
            DMcc.Size = Size.Medium;
            DMcc.Decaf = true;
            CandlehearthCoffee DScc = new CandlehearthCoffee();
            DScc.Size = Size.Small;
            DScc.Decaf = true;
            drinks.Add(DLcc);
            drinks.Add(DMcc);
            drinks.Add(DScc);

            MarkarthMilk Lmm = new MarkarthMilk();
            Lmm.Size = Size.Large;
            MarkarthMilk Mmm = new MarkarthMilk();
            Mmm.Size = Size.Medium;
            MarkarthMilk Smm = new MarkarthMilk();
            Smm.Size = Size.Small;
            drinks.Add(Lmm);
            drinks.Add(Mmm);
            drinks.Add(Smm);

            WarriorWater Lww = new WarriorWater();
            Lww.Size = Size.Large;
            WarriorWater Mww = new WarriorWater();
            Mww.Size = Size.Medium;
            WarriorWater Sww = new WarriorWater();
            Sww.Size = Size.Small;
            drinks.Add(Lww);
            drinks.Add(Mww);
            drinks.Add(Sww);

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
            drinks.Add(BLss);
            drinks.Add(BMss);
            drinks.Add(BSss);

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
            drinks.Add(CLss);
            drinks.Add(CMss);
            drinks.Add(CSss);

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
            drinks.Add(GLss);
            drinks.Add(GMss);
            drinks.Add(GSss);

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
            drinks.Add(LLss);
            drinks.Add(LMss);
            drinks.Add(LSss);

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
            drinks.Add(PLss);
            drinks.Add(PMss);
            drinks.Add(PSss);

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
            drinks.Add(WLss);
            drinks.Add(WMss);
            drinks.Add(WSss);

            foreach (IOrderItem drink in drinks)
            {
                Console.WriteLine(drink.ToString());
            }

            return drinks;
        }

        /// <summary>
        /// A method to list all items on the menu
        /// </summary>
        /// <returns>a IEnumerable List of all menu items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();


            //drinks
            AretinoAppleJuice Laa = new AretinoAppleJuice();
            Laa.Size = Size.Large;
            AretinoAppleJuice Maa = new AretinoAppleJuice();
            Maa.Size = Size.Medium;
            AretinoAppleJuice Saa = new AretinoAppleJuice();
            Saa.Size = Size.Small;
            fullMenu.Add(Laa);
            fullMenu.Add(Maa);
            fullMenu.Add(Saa);

            CandlehearthCoffee Lcc = new CandlehearthCoffee();
            Lcc.Size = Size.Large;
            CandlehearthCoffee Mcc = new CandlehearthCoffee();
            Mcc.Size = Size.Medium;
            CandlehearthCoffee Scc = new CandlehearthCoffee();
            Scc.Size = Size.Small;
            fullMenu.Add(Lcc);
            fullMenu.Add(Mcc);
            fullMenu.Add(Scc);

            CandlehearthCoffee DLcc = new CandlehearthCoffee();
            DLcc.Size = Size.Large;
            DLcc.Decaf = true;
            CandlehearthCoffee DMcc = new CandlehearthCoffee();
            DMcc.Size = Size.Medium;
            DMcc.Decaf = true;
            CandlehearthCoffee DScc = new CandlehearthCoffee();
            DScc.Size = Size.Small;
            DScc.Decaf = true;
            fullMenu.Add(DLcc);
            fullMenu.Add(DMcc);
            fullMenu.Add(DScc);

            MarkarthMilk Lmm = new MarkarthMilk();
            Lmm.Size = Size.Large;
            MarkarthMilk Mmm = new MarkarthMilk();
            Mmm.Size = Size.Medium;
            MarkarthMilk Smm = new MarkarthMilk();
            Smm.Size = Size.Small;
            fullMenu.Add(Lmm);
            fullMenu.Add(Mmm);
            fullMenu.Add(Smm);

            WarriorWater Lww = new WarriorWater();
            Lww.Size = Size.Large;
            WarriorWater Mww = new WarriorWater();
            Mww.Size = Size.Medium;
            WarriorWater Sww = new WarriorWater();
            Sww.Size = Size.Small;
            fullMenu.Add(Lww);
            fullMenu.Add(Mww);
            fullMenu.Add(Sww);

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
            fullMenu.Add(BLss);
            fullMenu.Add(BMss);
            fullMenu.Add(BSss);
            
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
            fullMenu.Add(CLss);
            fullMenu.Add(CMss);
            fullMenu.Add(CSss);

            //GrapeFruit Sailor Soda
            SailorSoda GLss = new SailorSoda();
            GLss.Size = Size.Large;
            GLss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GMss = new SailorSoda();
            GMss.Size = Size.Medium;
            GMss.Flavor = SodaFlavor.Grapefruit;
            SailorSoda GSss = new SailorSoda();
            GSss.Size = Size.Small;
            GMss.Flavor = SodaFlavor.Grapefruit;
            fullMenu.Add(GLss);
            fullMenu.Add(GMss);
            fullMenu.Add(GSss);

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
            fullMenu.Add(LLss);
            fullMenu.Add(LMss);
            fullMenu.Add(LSss);

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
            fullMenu.Add(PLss);
            fullMenu.Add(PMss);
            fullMenu.Add(PSss);

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
            fullMenu.Add(WLss);
            fullMenu.Add(WMss);
            fullMenu.Add(WSss);


            //entrees
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new DoubleDraugr());
            fullMenu.Add(new GardenOrcOmelette());
            fullMenu.Add(new PhillyPoacher());
            fullMenu.Add(new SmokehouseSkeleton());
            fullMenu.Add(new ThalmorTriple());
            fullMenu.Add(new ThugsTBone());

            //sides
            FriedMiraak LMirak = new FriedMiraak();
            LMirak.Size = Size.Large;
            FriedMiraak MMirak = new FriedMiraak();
            MMirak.Size = Size.Medium;
            FriedMiraak SMirak = new FriedMiraak();
            SMirak.Size = Size.Small;
            fullMenu.Add(LMirak);
            fullMenu.Add(MMirak);
            fullMenu.Add(SMirak);

            DragonbornWaffleFries Ldw = new DragonbornWaffleFries();
            Ldw.Size = Size.Large;
            DragonbornWaffleFries mdw = new DragonbornWaffleFries();
            mdw.Size = Size.Medium;
            DragonbornWaffleFries sdw = new DragonbornWaffleFries();
            sdw.Size = Size.Small;
            fullMenu.Add(Ldw);
            fullMenu.Add(mdw);
            fullMenu.Add(sdw);

            MadOtarGrits lmo = new MadOtarGrits();
            lmo.Size = Size.Large;
            MadOtarGrits mmo = new MadOtarGrits();
            mmo.Size = Size.Medium;
            MadOtarGrits smo = new MadOtarGrits();
            smo.Size = Size.Small;
            fullMenu.Add(lmo);
            fullMenu.Add(mmo);
            fullMenu.Add(smo);

            VokunSalad lvs = new VokunSalad();
            lvs.Size = Size.Large;
            VokunSalad mvs = new VokunSalad();
            mvs.Size = Size.Medium;
            VokunSalad svs = new VokunSalad();
            svs.Size = Size.Small;
            fullMenu.Add(lvs);
            fullMenu.Add(mvs);
            fullMenu.Add(svs);

            foreach (IOrderItem item in fullMenu)
            {
                Console.WriteLine(item.ToString());
            }
            return fullMenu;

        }

        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }


        /// <summary>
        /// method to search the list for a certain term
        /// </summary>
        /// <param name="items">the list of items we are searching through</param>
        /// <param name="s"> the string we are searching for </param>
        /// <returns> a list of items in the list that have the word</returns>
        public static IEnumerable<IOrderItem> Search(string s)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (s == null) return All;

            foreach (IOrderItem item in All)
            {
                //Add the movie if title matches/contains
                if (item.Name != null && item.Name.Contains(s))
                {
                    results.Add(item);
                }
            }

            return results;
        }


        /// <summary>
        /// A method to filter a list by each cateogory
        /// </summary>
        /// <param name="items">all the items we are searching through</param>
        /// <param name="catagory">the cateogry we are looking for</param>
        /// <returns>a list of items in the category</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> catagory)
        {
            if (catagory == null || catagory.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if (catagory.Contains(item.itemType.ToString())){
                    results.Add(item);
                }
            }


            return results;
        }

        /// <summary>
        /// A method to filter items in a list by their calories
        /// </summary>
        /// <param name="items">all the items we are searching through</param>
        /// <param name="min"> the minimum calories</param>
        /// <param name="max">the maximum calories</param>
        /// <returns>A list of items within the specified calorie range</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// A method to filter items in a list by their price
        /// </summary>
        /// <param name="items">all the items we are searching through</param>
        /// <param name="min"> the minimum price</param>
        /// <param name="max">the maximum price</param>
        /// <returns>A list of items within the specified price range</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
