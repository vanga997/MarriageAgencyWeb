using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarriageAgency.Models;

namespace MarriageAgency.Pages_Positions
{
    public class DetailsModel : PageModel
    {
        private readonly MarriageAgencyContext _context;

        public DetailsModel(MarriageAgencyContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.PostName == id);

            if (Position == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
