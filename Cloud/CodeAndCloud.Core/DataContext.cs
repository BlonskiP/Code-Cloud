﻿using System;
using System.Collections.Generic;
using System.Text;
using CodeAndCloud.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeAndCloud.Core
{
    class DataContext : DbContext
    {
        public virtual DbSet<ContactModel> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                                        Server=(localdb)\MSSQLLocalDB;
                                        Database=CodeAndCloud;
                                        Trusted_Connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
