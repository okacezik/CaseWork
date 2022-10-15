using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class CaseContext : DbContext
    {
        //veritabanı ile bağlantı kuruldu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CaseDatabase;Trusted_Connection=true");
        }

        //Patient class'ı veritabanındaki Patients tablosu ile ilişkilendirildi
        public DbSet<Patient> Patients { get; set; } 
    }
}
