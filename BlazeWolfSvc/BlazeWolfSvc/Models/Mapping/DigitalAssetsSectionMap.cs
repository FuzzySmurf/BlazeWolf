using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class DigitalAssetsSectionMap : EntityTypeConfiguration<DigitalAssetsSection>
    {
        public DigitalAssetsSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.DigitalAssetSectionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DigitalAssetsSection");
            this.Property(t => t.DigitalAssetSectionID).HasColumnName("DigitalAssetSectionID");
            this.Property(t => t.DigitalAssetID).HasColumnName("DigitalAssetID");
            this.Property(t => t.SectionID).HasColumnName("SectionID");

            // Relationships
            this.HasRequired(t => t.DigitalAsset)
                .WithMany(t => t.DigitalAssetsSections)
                .HasForeignKey(d => d.DigitalAssetID);
            this.HasRequired(t => t.Section)
                .WithMany(t => t.DigitalAssetsSections)
                .HasForeignKey(d => d.SectionID);

        }
    }
}
