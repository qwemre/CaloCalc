using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class CaloCalcDbContext :DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }

        

        public DbSet<Kategori> Kategoriler { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CaloCalcDbContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=DESKTOP-HNK2G88\\MSSQLSERVER01;initial catalog=Prj_KD15_CaloCalc;integrated security=true");
        }
    }

}
