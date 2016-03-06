using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class DocumentMap : EntityTypeConfiguration<Document>
    {
        public DocumentMap()
        {
            // Primary Key
            this.HasKey(t => t.DocumentID);

            // Properties
            this.Property(t => t.DocumentName)
                .HasMaxLength(100);

            this.Property(t => t.FileName)
                .HasMaxLength(100);

            this.Property(t => t.LinkReference)
                .HasMaxLength(255);

            this.Property(t => t.CreatedUser)
                .HasMaxLength(100);

            this.Property(t => t.ModifiedUser)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Documents");
            this.Property(t => t.DocumentID).HasColumnName("DocumentID");
            this.Property(t => t.DocumentTypeID).HasColumnName("DocumentTypeID");
            this.Property(t => t.DocumentName).HasColumnName("DocumentName");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.LinkReference).HasColumnName("LinkReference");
            this.Property(t => t.CreatedUser).HasColumnName("CreatedUser");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedUser).HasColumnName("ModifiedUser");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            this.HasOptional(t => t.DocumentType)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.DocumentTypeID);

        }
    }
}
