using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class ContentSectionMap : EntityTypeConfiguration<ContentSection>
    {
        public ContentSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentSectionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContentSection");
            this.Property(t => t.ContentSectionID).HasColumnName("ContentSectionID");
            this.Property(t => t.ContentID).HasColumnName("ContentID");
            this.Property(t => t.SectionID).HasColumnName("SectionID");

            // Relationships
            this.HasRequired(t => t.Content)
                .WithMany(t => t.ContentSections)
                .HasForeignKey(d => d.ContentID);
            this.HasRequired(t => t.Section)
                .WithMany(t => t.ContentSections)
                .HasForeignKey(d => d.SectionID);

        }
    }
}
