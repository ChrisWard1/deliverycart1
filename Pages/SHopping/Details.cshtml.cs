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
    public class DetailsModel : PageModel
    {
        private readonly deliverycart.Data.Context _context;

        public DetailsModel(deliverycart.Data.Context context)
        {
            _context = context;
        }

        public Vendor Vendor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vendor = await _context.Vendor.FirstOrDefaultAsync(m => m.VendorID == id);

            if (Vendor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
