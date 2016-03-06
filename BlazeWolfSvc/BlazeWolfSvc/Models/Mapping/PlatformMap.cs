using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class PlatformMap : EntityTypeConfiguration<Platform>
    {
        public PlatformMap()
        {
            // Primary Key
            this.HasKey(t => t.PlatformID);

            // Properties
            this.Property(t => t.Platform1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Platform", "Game");
            this.Property(t => t.PlatformID).HasColumnName("PlatformID");
            this.Property(t => t.Platform1).HasColumnName("Platform");
        }
    }
}
