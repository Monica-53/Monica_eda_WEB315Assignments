using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesGarden.Models;

namespace MedasGardening.pages_Gardens
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesGardenContext _context;

        public DeleteModel(RazorPagesGardenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Garden Garden { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Garden = await _context.Garden.FirstOrDefaultAsync(m => m.ID == id);

            if (Garden == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Garden = await _context.Garden.FindAsync(id);

            if (Garden != null)
            {
                _context.Garden.Remove(Garden);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
