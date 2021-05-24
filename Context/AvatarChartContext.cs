using Microsoft.EntityFrameworkCore;
using SetApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetApi.Context
{
    public class AvatarChartContext :DbContext
    {
        public AvatarChartContext(DbContextOptions<AvatarChartContext> options) : base(options)
        {

        }
        public DbSet<AvatarChart> AvatarCharts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvatarChart>().HasKey(c => c.modelId);


        }
    }
}
