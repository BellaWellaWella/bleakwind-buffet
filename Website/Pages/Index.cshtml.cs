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

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Getting a reference to entrees
        /// </summary>
        public IEnumerable<IOrderItem> Entrees {get { return Menu.Entrees(); } }

        /// <summary>
        /// getting a reference to drinks
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get { return Menu.Drinks(); } }

        /// <summary>
        /// getting a reference to sides
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get { return Menu.Sides(); } }

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
        public void OnGet()
        {

        }
    }
}
