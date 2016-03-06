using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class DigitalAssetTypeMap : EntityTypeConfiguration<DigitalAssetType>
    {
        public DigitalAssetTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DigitalAssetTypeID);

            // Properties
            this.Property(t => t.DigitalAssetType1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DigitalAssetType");
            this.Property(t => t.DigitalAssetTypeID).HasColumnName("DigitalAssetTypeID");
            this.Property(t => t.DigitalAssetType1).HasColumnName("DigitalAssetType");
        }
    }
}
