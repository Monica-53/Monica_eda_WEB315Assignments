using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesGarden.Models;

namespace MedasGardening.pages_Gardens
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesGardenContext _context;

        public CreateModel(RazorPagesGardenContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Garden Garden { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Garden.Add(Garden);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
