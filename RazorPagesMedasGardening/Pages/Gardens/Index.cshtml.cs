using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesGarden.Models;

namespace RazorPagesGarden.Pages.Gardens
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesGardenContext _context;

        public IndexModel(RazorPagesGardenContext context)
        {
            _context = context;
        }

        public IList<Garden> Garden { get;set; }

        public async Task OnGetAsync()
        {
            Garden = await _context.Garden.ToListAsync();
        }
    }
}
