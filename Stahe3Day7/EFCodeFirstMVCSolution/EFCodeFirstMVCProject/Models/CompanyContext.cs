﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstMVCProject.Models
{
    public class CompanyContext :DbContext
    {
        public CompanyContext() { }
        public CompanyContext(DbContextOptions<CompanyContext> options):base(options)
        {

        }
        public virtual string Check { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}
