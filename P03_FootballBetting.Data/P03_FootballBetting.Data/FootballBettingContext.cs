﻿using Microsoft.EntityFrameworkCore;
using System;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {
        }

        public FootballBettingContext(DbContextOptions options)
            :base (options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-0NSKHNUT\\SQLEXPRESS;Database=StudentSystem;Integrated Security=True");
            }
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.GameId });

                entity.HasOne(e => e.Player).WithMany(p => p.PlayerStatistics).HasForeignKey(e => e.PlayerId);

                entity.HasOne(e => e.Game).WithMany(g => g.PlayerStatistics).HasForeignKey(e => e.GameId);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasOne(e => e.PrimaryKitColor).WithMany(p => p.PrimaryKitTeams).HasForeignKey(e => e.PrimaryKitColorId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.SecondaryKitColor).WithMany(p => p.SecondaryKitTeams).HasForeignKey(e => e.SecondaryKitColorId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Town).WithMany(t => t.Teams).HasForeignKey(e => e.TownId);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasOne(e => e.HomeTeam).WithMany(t => t.HomeGames).HasForeignKey(e => e.HomeTeamId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.AwayTeam).WithMany(t => t.AwayGames).HasForeignKey(e => e.AwayTeamId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasOne(e => e.Country).WithMany(c => c.Towns).HasForeignKey(e => e.CountryId);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.IsInjured).HasDefaultValue(false);

                entity.HasOne(e => e.Team).WithMany(t => t.Players).HasForeignKey(e => e.TeamId);

                entity.HasOne(e => e.Position).WithMany(p => p.Players).HasForeignKey(e => e.PositionId);
            });

            modelBuilder.Entity<Bet>(entity =>
            {
                entity.HasOne(e => e.Game).WithMany(g => g.Bets).HasForeignKey(e => e.GameId);

                entity.HasOne(e => e.User).WithMany(u => u.Bets).HasForeignKey(e => e.UserId);
            });
        }
    }
}
