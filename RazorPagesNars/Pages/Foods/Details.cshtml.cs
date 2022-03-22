#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesNars.Data;
using RazorPagesNars.Models;

namespace RazorPagesNars.Pages.Foods
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesNars.Data.RazorPagesNarsContext _context;

        public DetailsModel(RazorPagesNars.Data.RazorPagesNarsContext context)
        {
            _context = context;
        }

        public Food Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Food = await _context.Food.FirstOrDefaultAsync(m => m.ID == id);

            if (Food == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
