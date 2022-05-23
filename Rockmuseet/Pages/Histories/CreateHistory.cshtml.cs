using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rockmuseet.models;
using Rockmuseet.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rockmuseet
{
    public class CreateHistoryModel : PageModel
    {
        private IHistoryRepository repository;
        [BindProperty]
        public History History { get; set; }
        public List<History> histories { get; set; }
        public CreateHistoryModel(IHistoryRepository repo)
        {
            repository = repo;
        }



        public void OnGet()
        {
            histories = repository.GetAllHistories();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return Page();
            }
            repository.AddHistory(History);
            histories = repository.GetAllHistories();
            return RedirectToPage("CreateHistory");
        }


    }
}
