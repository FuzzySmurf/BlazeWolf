using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class GameDetailMap : EntityTypeConfiguration<GameDetail>
    {
        public GameDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.GameDetailsID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GameDetails", "Game");
            this.Property(t => t.GameDetailsID).HasColumnName("GameDetailsID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.PlatformID).HasColumnName("PlatformID");
            this.Property(t => t.GenreID).HasColumnName("GenreID");
            this.Property(t => t.DimensionID).HasColumnName("DimensionID");
            this.Property(t => t.IsOnline).HasColumnName("IsOnline");
            this.Property(t => t.IsMultiplayer).HasColumnName("IsMultiplayer");
            this.Property(t => t.MaxPlayers).HasColumnName("MaxPlayers");

            // Relationships
            this.HasRequired(t => t.BlazeGame)
                .WithMany(t => t.GameDetails)
                .HasForeignKey(d => d.GameID);
            this.HasOptional(t => t.Dimension)
                .WithMany(t => t.GameDetails)
                .HasForeignKey(d => d.DimensionID);
            this.HasOptional(t => t.Genre)
                .WithMany(t => t.GameDetails)
                .HasForeignKey(d => d.GenreID);
            this.HasOptional(t => t.Platform)
                .WithMany(t => t.GameDetails)
                .HasForeignKey(d => d.PlatformID);

        }
    }
}
