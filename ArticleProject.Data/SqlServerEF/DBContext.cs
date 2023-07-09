using ArticleProject.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleProject.Data.SqlServerEF
{
    public class DBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=ArticleProjectDB;Trusted_Connection=True");
        }
        public DbSet<Category>? Category { get; set; }
        public DbSet<Author>? Author { get; set; }
        public DbSet<AuthorPost>? AuthorPost { get; set; }
    }
}
