﻿using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;


namespace NZWalks.API.Data
{
    public class NzWalksDbContext: DbContext
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options): base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalksDifficulty { get; set; }

    }
}
