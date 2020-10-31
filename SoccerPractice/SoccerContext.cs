namespace SoccerPractice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SoccerContext : DbContext
    {
        public SoccerContext()
            : base("name=SoccerContext")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithOptional(e => e.Team)
                .WillCascadeOnDelete();
        }
    }
}
