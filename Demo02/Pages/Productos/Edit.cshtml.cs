using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo02.Data;
using Demo02.Models;

namespace Demo02.Pages.Productos
{
    public class EditModel : PageModel
    {
        private readonly Demo02.Data.Demo02Context _context;

        public EditModel(Demo02.Data.Demo02Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productoExists(producto.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool productoExists(int id)
        {
            return _context.producto.Any(e => e.id == id);
        }
    }
}
