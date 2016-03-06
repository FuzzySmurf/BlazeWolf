using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class BlazeGamesContentMap : EntityTypeConfiguration<BlazeGamesContent>
    {
        public BlazeGamesContentMap()
        {
            // Primary Key
            this.HasKey(t => t.BlazeGamesContentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BlazeGamesContent", "Game");
            this.Property(t => t.BlazeGamesContentID).HasColumnName("BlazeGamesContentID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.ContentID).HasColumnName("ContentID");

            // Relationships
            this.HasRequired(t => t.BlazeGame)
                .WithMany(t => t.BlazeGamesContents)
                .HasForeignKey(d => d.GameID);

        }
    }
}
