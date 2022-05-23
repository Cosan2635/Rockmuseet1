using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet
{
    public class HistoriesModel : PageModel
    {
        private IHistoryRepository catalog;
        public HistoriesModel(IHistoryRepository repository)
        {
            catalog = repository;
        }
        public List<History> Histories { get; private set; }

        [BindProperty]
        public History History { get; set; }

        public void History_Click(Object sender, EventArgs e)
        {
            Console.WriteLine("History Clicked");
        }

        public IActionResult OnGet()
        {
            Histories = catalog.GetAllHistories();
            return Page();
        }
    }
}
