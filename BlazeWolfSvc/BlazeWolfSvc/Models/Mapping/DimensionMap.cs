using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class DimensionMap : EntityTypeConfiguration<Dimension>
    {
        public DimensionMap()
        {
            // Primary Key
            this.HasKey(t => t.DimensionID);

            // Properties
            this.Property(t => t.Dimension1)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Dimensions", "Game");
            this.Property(t => t.DimensionID).HasColumnName("DimensionID");
            this.Property(t => t.Dimension1).HasColumnName("Dimension");
        }
    }
}
