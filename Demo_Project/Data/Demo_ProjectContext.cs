using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo_Project.Models;

namespace Demo_Project.Data
{
    public class Demo_ProjectContext : DbContext
    {
        public Demo_ProjectContext (DbContextOptions<Demo_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Demo_Project.Models.Container> Container { get; set; } = default!;
    }
}
