using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesGarden.Models;

    public class RazorPagesGardenContext : DbContext
    {
        public RazorPagesGardenContext (DbContextOptions<RazorPagesGardenContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesGarden.Models.Garden> Garden { get; set; }
    }
