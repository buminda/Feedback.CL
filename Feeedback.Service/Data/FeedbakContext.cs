using Feeedback.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeedback.Service.Data
{
    public class FeedbakContext : DbContext
    {
        public FeedbakContext(DbContextOptions<FeedbakContext> options) : base(options)
        {
        }

        public DbSet<FeedbackData> FeedbackData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackData>().ToTable("FeedbackData");            
        }
    }
}
