#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesNars.Models;

namespace RazorPagesNars.Data
{
    public class RazorPagesNarsContext : DbContext
    {
        public RazorPagesNarsContext (DbContextOptions<RazorPagesNarsContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesNars.Models.Food> Food { get; set; }
    }
}
