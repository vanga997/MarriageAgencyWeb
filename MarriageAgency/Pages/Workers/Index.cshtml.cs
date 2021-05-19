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
    public class IndexModel : PageModel
    {
        private readonly MarriageAgencyContext _context;

        public IndexModel(MarriageAgencyContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get;set; }

        public async Task OnGetAsync()
        {
            Worker = await _context.Worker.ToListAsync();
        }
    }
}
