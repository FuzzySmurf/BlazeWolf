using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlazeWolfSvc.Models.Mapping
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            // Primary Key
            this.HasKey(t => t.GenreID);

            // Properties
            this.Property(t => t.Genre1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Genre", "Game");
            this.Property(t => t.GenreID).HasColumnName("GenreID");
            this.Property(t => t.Genre1).HasColumnName("Genre");
        }
    }
}
