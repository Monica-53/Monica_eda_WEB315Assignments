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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesGardenContext _context;

        public DetailsModel(RazorPagesGardenContext context)
        {
            _context = context;
        }

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
    }
}
