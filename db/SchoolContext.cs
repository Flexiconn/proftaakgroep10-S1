using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExample
{
    public class SchoolContext : DbContext
    {
        public DbSet<DbModel.meetData> meetDatas { get; set; }
        public DbSet<DbModel.plantData> plantDatas { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=data.db;");
        }
    }
}
