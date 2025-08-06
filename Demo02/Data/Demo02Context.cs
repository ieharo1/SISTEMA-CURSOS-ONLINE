using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo02.Models;

namespace Demo02.Data
{
    public class Demo02Context : DbContext
    {
        public Demo02Context (DbContextOptions<Demo02Context> options)
            : base(options)
        {
        }

        public DbSet<Demo02.Models.producto> producto { get; set; }
    }
}
