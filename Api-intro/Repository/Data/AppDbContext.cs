
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FullName = "Ali Ramazanov",
                    Address = "Xetai",
                    Age = 21
                },
                new Employee
                {
                    Id = 2,
                    FullName = "Aydin Aliyev",
                    Address = "Sumqayit",
                    Age = 25
                },
                new Employee
                {
                    Id = 3,
                    FullName = "Anar Abbasov",
                    Address = "23",
                    Age = 27
                });
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id =1,
                    Name = "Azerbaijan"
                },
                new Country
                {
                    Id = 2,
                    Name = "Turkiye"
                },
                new Country
                {
                    Id = 3,
                    Name = "England"
                });

            /*new EmployeeConfiguration().Configure(modelBuilder.Entity<Employee>());*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
