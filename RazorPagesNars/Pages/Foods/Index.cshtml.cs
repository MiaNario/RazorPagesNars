#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesNars.Data;
using RazorPagesNars.Models;

namespace RazorPagesNars.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesNars.Data.RazorPagesNarsContext _context;

        public IndexModel(RazorPagesNars.Data.RazorPagesNarsContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var foods = from m in _context.Food
                        select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                foods = foods.Where(s => s.Name.Contains(SearchString));
            }
            Food = await foods.ToListAsync();
        }
    }
}
