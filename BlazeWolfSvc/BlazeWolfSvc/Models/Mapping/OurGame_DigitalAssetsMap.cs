using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class OurGame_DigitalAssetsMap : EntityTypeConfiguration<OurGame_DigitalAssets>
    {
        public OurGame_DigitalAssetsMap()
        {
            // Primary Key
            this.HasKey(t => t.OurGame_DigitalAssetID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OurGame_DigitalAssets");
            this.Property(t => t.OurGame_DigitalAssetID).HasColumnName("OurGame_DigitalAssetID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.DigitalAssetID).HasColumnName("DigitalAssetID");

            // Relationships
            this.HasOptional(t => t.DigitalAsset)
                .WithMany(t => t.OurGame_DigitalAssets)
                .HasForeignKey(d => d.DigitalAssetID);
            this.HasOptional(t => t.BlazeGame)
                .WithMany(t => t.OurGame_DigitalAssets)
                .HasForeignKey(d => d.GameID);

        }
    }
}
