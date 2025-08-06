using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Demo02.Data;
using Demo02.Models;

namespace Demo02.Pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly Demo02.Data.Demo02Context _context;

        public CreateModel(Demo02.Data.Demo02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public producto producto { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.producto.Add(producto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
