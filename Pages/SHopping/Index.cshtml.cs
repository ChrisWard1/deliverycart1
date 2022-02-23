#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using deliverycart.Data;
using deliverycart.Models;

namespace deliverycart1.Pages_SHopping
{
    public class IndexModel : PageModel
    {
        private readonly deliverycart.Data.Context _context;

        public IndexModel(deliverycart.Data.Context context)
        {
            _context = context;
        }

        public IList<Vendor> Vendor { get;set; }

        public async Task OnGetAsync()
        {
            Vendor = await _context.Vendor.ToListAsync();
        }
    }
}
