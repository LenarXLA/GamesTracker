using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesTracker.Models;

namespace GamesTracker.Data
{
    public class GamesTrackerContext : DbContext
    {
        public GamesTrackerContext (DbContextOptions<GamesTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<GamesTracker.Models.Game>? Game { get; set; }
        public DbSet<GamesTracker.Models.GameWalkthrough>? GameWalkthrough { get; set; }
        public DbSet<GamesTracker.Models.GameRecent>? GameRecent { get; set; }
    }
}
