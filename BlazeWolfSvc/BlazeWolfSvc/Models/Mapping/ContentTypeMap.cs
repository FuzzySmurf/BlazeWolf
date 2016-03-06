using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class ContentTypeMap : EntityTypeConfiguration<ContentType>
    {
        public ContentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ContentTypeID);

            // Properties
            this.Property(t => t.ContentType1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("ContentType");
            this.Property(t => t.ContentTypeID).HasColumnName("ContentTypeID");
            this.Property(t => t.ContentType1).HasColumnName("ContentType");
        }
    }
}
