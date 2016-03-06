using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class ContentMap : EntityTypeConfiguration<Content>
    {
        public ContentMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentID);

            // Properties
            this.Property(t => t.Content1)
                .HasMaxLength(500);

            this.Property(t => t.CreatedUser)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.ModifiedUser)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Content");
            this.Property(t => t.ContentID).HasColumnName("ContentID");
            this.Property(t => t.Content1).HasColumnName("Content");
            this.Property(t => t.ContentTypeID).HasColumnName("ContentTypeID");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.ContentType)
                .WithMany(t => t.Contents)
                .HasForeignKey(d => d.ContentTypeID);

        }
    }
}
