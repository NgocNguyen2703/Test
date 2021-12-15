using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Test.Models.PersonNTN535> PersonNTN535 { get; set; }

        public DbSet<Test.Models.NTN0535> NTN0535 { get; set; }
    }
