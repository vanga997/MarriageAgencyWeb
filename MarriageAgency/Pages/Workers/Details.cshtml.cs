using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarriageAgency.Models;

namespace MarriageAgency.Pages_Workers
{
    public class DetailsModel : PageModel
    {
        private readonly MarriageAgencyContext _context;

        public DetailsModel(MarriageAgencyContext context)
        {
            _context = context;
        }

        public Worker Worker { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Worker = await _context.Worker.FirstOrDefaultAsync(m => m.WorkerID == id);

            if (Worker == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
