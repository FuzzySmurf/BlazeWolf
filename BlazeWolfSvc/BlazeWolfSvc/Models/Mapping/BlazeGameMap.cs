using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class BlazeGameMap : EntityTypeConfiguration<BlazeGame>
    {
        public BlazeGameMap()
        {
            // Primary Key
            this.HasKey(t => t.GameID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            this.Property(t => t.CreatedUser)
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BlazeGames", "Game");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
