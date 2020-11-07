/*
* Author: Bella Goddard
* Class name: Index
* Purpose: The code-behind for index
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        
        //All the items in the list
        public IEnumerable<IOrderItem> AllItems { get; set; }

        /// <summary>
        /// the terms for the search
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// the category that is entered
        /// </summary>
        public string[] ItemCategory { get; set; }

        /// <summary>
        /// the minimum calories wanted
        /// </summary>
        //[BindProperty]
        public int? CalMin { get; set; } = null;

        /// <summary>
        /// the maximum calories wanted
        /// </summary>
        //[BindProperty]
        public int? CalMax { get; set; } = null;

        /// <summary>
        /// the minimum price wanted
        /// </summary>
        //[BindProperty]
        public double? PriceMin { get; set; } = null;

        /// <summary>
        /// the maximum price wanted
        /// </summary>
        //[BindProperty]
        public double? PriceMax { get; set; } = null;


        /// <summary>
        /// logger variable
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// index modle 
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// on get methon, not used yet
        /// </summary>
        public void OnGet(int? calMin, int? calMax, double? priceMin, double? priceMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            AllItems = Menu.Search(SearchTerms);

            ItemCategory = Request.Query["ItemCategory"];
            AllItems = Menu.FilterByCategory(AllItems, ItemCategory);

            CalMin = calMin;
            CalMax = calMax;
            PriceMin = priceMin;
            PriceMax = priceMax;

            AllItems = Menu.FilterByCalories(AllItems, CalMin, CalMax);
            AllItems = Menu.FilterByPrice(AllItems, PriceMin, PriceMax);
        }
    }
}
