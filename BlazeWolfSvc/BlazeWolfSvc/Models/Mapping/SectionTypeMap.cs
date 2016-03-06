using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class SectionTypeMap : EntityTypeConfiguration<SectionType>
    {
        public SectionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SectionTypeID);

            // Properties
            this.Property(t => t.SectionType1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SectionType");
            this.Property(t => t.SectionTypeID).HasColumnName("SectionTypeID");
            this.Property(t => t.SectionType1).HasColumnName("SectionType");
        }
    }
}
