using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class DigitalAssetMap : EntityTypeConfiguration<DigitalAsset>
    {
        public DigitalAssetMap()
        {
            // Primary Key
            this.HasKey(t => t.DigitalAssetID);

            // Properties
            this.Property(t => t.DigitalAssetName)
                .HasMaxLength(255);

            this.Property(t => t.FileName)
                .HasMaxLength(255);

            this.Property(t => t.LinkReference)
                .HasMaxLength(255);

            this.Property(t => t.CreatedUser)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DigitalAssets");
            this.Property(t => t.DigitalAssetID).HasColumnName("DigitalAssetID");
            this.Property(t => t.DigitalAssetTypeID).HasColumnName("DigitalAssetTypeID");
            this.Property(t => t.DigitalAssetName).HasColumnName("DigitalAssetName");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.LinkReference).HasColumnName("LinkReference");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.DigitalAssetType)
                .WithMany(t => t.DigitalAssets)
                .HasForeignKey(d => d.DigitalAssetTypeID);

        }
    }
}
