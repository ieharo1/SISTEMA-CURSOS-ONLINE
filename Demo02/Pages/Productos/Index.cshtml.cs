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
    public class IndexModel : PageModel
    {
        private readonly Demo02.Data.Demo02Context _context;

        public IndexModel(Demo02.Data.Demo02Context context)
        {
            _context = context;
        }

        public IList<producto> producto { get;set; }

        public async Task OnGetAsync()
        {
            producto = await _context.producto.ToListAsync();
        }
    }
}
