using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rockmuseet.Helpers;
using Rockmuseet.Interfaces;
using Rockmuseet.models;
using Rockmuseet.Pages;

namespace Rockmuseet
{
    public class DeleteHistory : PageModel
    {
        [BindProperty]
        public History history { get; set; }
        private IHistoryRepository repository;
        public List<History> histories { get; set; }
        public DeleteHistory(IHistoryRepository repo)

        {
            repository = repo;
        }
        public IActionResult OnGet()
        {
            histories = repository.GetAllHistories();
            return Page();

        }

        public IActionResult OnPost(History history)
        {

            {
                if (ModelState.IsValid)
                {
                    return Page();
                }
                repository.DeleteHistory(history);

                return RedirectToPage("Index");

            }

        }
    }
}
