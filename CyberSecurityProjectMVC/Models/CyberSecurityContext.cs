using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSecurityProjectMVC.Models
{
    public class CyberSecurityContext:DbContext
    {
        public CyberSecurityContext(DbContextOptions<CyberSecurityContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("Article");
        }
    }
}
