using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class OurGames_DocumentsMap : EntityTypeConfiguration<OurGames_Documents>
    {
        public OurGames_DocumentsMap()
        {
            // Primary Key
            this.HasKey(t => t.OurGames_DocumentID);

            // Properties
            // Table & Column Mappings
            this.ToTable("OurGames_Documents");
            this.Property(t => t.OurGames_DocumentID).HasColumnName("OurGames_DocumentID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");

            // Relationships
            this.HasOptional(t => t.Document)
                .WithMany(t => t.OurGames_Documents)
                .HasForeignKey(d => d.DocumentID);
            this.HasOptional(t => t.BlazeGame)
                .WithMany(t => t.OurGames_Documents)
                .HasForeignKey(d => d.GameID);

        }
    }
}
