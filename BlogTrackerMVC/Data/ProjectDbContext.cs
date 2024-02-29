using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogTrackerWebAPI.Models;

namespace BlogTrackerMVC.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext (DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTrackerWebAPI.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<BlogTrackerWebAPI.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<BlogTrackerWebAPI.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
