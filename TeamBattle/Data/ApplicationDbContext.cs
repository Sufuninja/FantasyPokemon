using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeamBattle.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<BattleTeam> BattleTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().OwnsMany(b => b.BattleTeams, a =>
            {
                a.WithOwner().HasForeignKey("OwnerId");
                a.Property<int>("Id");
                a.HasKey("Id");
                a.OwnsMany(c => c.Members, d =>
                {
                    d.WithOwner().HasForeignKey("BattleTeamId");
                    d.Property<int>("Id");
                    d.HasKey("Id");
                    d.Property<string>("PokiApiId");
                });
            });

            base.OnModelCreating(builder);
        }
    }

    [Owned]
    public class BattleTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members { get; set; }
    }

    [Owned]
    public class Member 
    {
        public int Id { get; set; }
        public int BattleTeamId { get; set; }
        public string PokiApiId { get; set; }
    }
}
