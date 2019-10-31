using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string F_Name { get; set; }
        public string Course { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=  DESKTOP-95NNO4H\SQLEXPRESS; 
                Initial Catalog =  Students;
                Trusted_Connection = True;");
        }
    }
}
