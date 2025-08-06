using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Demo02.Data;
using Demo02.Models;

namespace Demo02.Pages.Productos
{
    public class DetailsModel : PageModel
    {
        private readonly Demo02.Data.Demo02Context _context;

        public DetailsModel(Demo02.Data.Demo02Context context)
        {
            _context = context;
        }

        public producto producto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            producto = await _context.producto.FirstOrDefaultAsync(m => m.id == id);

            if (producto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
