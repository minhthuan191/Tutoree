﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Tutoree.Models;
using Tutoree.Utils.Interface;

namespace Tutoree.Utils
{
    public class DBContext : DbContext
    {
        private IConfig Config;
        public DBContext(IConfig config)
        {
            this.Config = config;
        }

        public DbSet<Student> Student { set; get; }
        public DbSet<Tutor> Tutor { set; get; }
        
        public DbSet<Tutor_Student> Tutor_Student { set; get; }
        public DbSet<Subject> Subject { set; get; }
        public DbSet<Major> Major { set; get; }
        public DbSet<Location> Location { set; get; }
        public DbSet<TeachingSubject> TeachingSubject { set; get; }
        
        public DbSet<TeachingSchedule> TeachingSchedule { set; get; }
    
        public DbSet<SchoolYear> SchoolYear { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=13.212.106.245,1433;Database=Tutoree;User ID=sa;Password=1234567890Aa;Trusted_Connection=true;Integrated Security=false;TrustServerCertificate=true");
        }


        public static async Task InitDatabase(IConfig config)
        {
            var dbContext = new DBContext(config);
            bool result = await dbContext.Database.EnsureCreatedAsync();
            if (result)
            {
                Console.WriteLine("Database created");
            }
        }
    }
}
