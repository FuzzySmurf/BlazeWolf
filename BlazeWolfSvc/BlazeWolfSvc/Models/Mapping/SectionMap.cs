using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class SectionMap : EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            // Primary Key
            this.HasKey(t => t.SectionID);

            // Properties
            this.Property(t => t.SectionName)
                .HasMaxLength(255);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.CreatedUser)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Sections");
            this.Property(t => t.SectionID).HasColumnName("SectionID");
            this.Property(t => t.SectionTypeID).HasColumnName("SectionTypeID");
            this.Property(t => t.SectionName).HasColumnName("SectionName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasRequired(t => t.SectionType)
                .WithMany(t => t.Sections)
                .HasForeignKey(d => d.SectionTypeID);

        }
    }
}
