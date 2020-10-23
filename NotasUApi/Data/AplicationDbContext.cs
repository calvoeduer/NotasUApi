using Microsoft.EntityFrameworkCore;
using NotasUApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<Activity> Activities { get; set; }
    }
}
