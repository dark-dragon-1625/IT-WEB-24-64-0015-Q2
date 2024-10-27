using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ABC_Academy.Model;

namespace ABC_Academy.Data
{
    public class ABC_AcademyContext : DbContext
    {
        public ABC_AcademyContext (DbContextOptions<ABC_AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<ABC_Academy.Model.Course> Course { get; set; } = default!;
        public DbSet<ABC_Academy.Model.Student> Student { get; set; } = default!;
    }
}
