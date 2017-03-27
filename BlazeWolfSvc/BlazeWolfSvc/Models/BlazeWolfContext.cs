using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BlazeWolfSvc.Models.Mapping;

namespace BlazeWolfSvc.Models
{
    public partial class BlazeWolfContext : DbContext
    {
        static BlazeWolfContext()
        {
            Database.SetInitializer<BlazeWolfContext>(new CreateDatabaseIfNotExists<BlazeWolfContext>());
        }

        public BlazeWolfContext()
            : base("Name=BlazeWolfContext")
        {
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentSection> ContentSections { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<DigitalAsset> DigitalAssets { get; set; }
        public DbSet<DigitalAssetsSection> DigitalAssetsSections { get; set; }
        public DbSet<DigitalAssetType> DigitalAssetTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<OurGame_DigitalAssets> OurGame_DigitalAssets { get; set; }
        public DbSet<OurGames_Documents> OurGames_Documents { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionType> SectionTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<BlazeGame> BlazeGames { get; set; }
        public DbSet<BlazeGamesContent> BlazeGamesContents { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<GameDetail> GameDetails { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContentMap());
            modelBuilder.Configurations.Add(new ContentSectionMap());
            modelBuilder.Configurations.Add(new ContentTypeMap());
            modelBuilder.Configurations.Add(new DigitalAssetMap());
            modelBuilder.Configurations.Add(new DigitalAssetsSectionMap());
            modelBuilder.Configurations.Add(new DigitalAssetTypeMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new DocumentTypeMap());
            modelBuilder.Configurations.Add(new OurGame_DigitalAssetsMap());
            modelBuilder.Configurations.Add(new OurGames_DocumentsMap());
            modelBuilder.Configurations.Add(new SectionMap());
            modelBuilder.Configurations.Add(new SectionTypeMap());
            modelBuilder.Configurations.Add(new StaffMap());
            modelBuilder.Configurations.Add(new BlazeGameMap());
            modelBuilder.Configurations.Add(new BlazeGamesContentMap());
            modelBuilder.Configurations.Add(new DimensionMap());
            modelBuilder.Configurations.Add(new GameDetailMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new PlatformMap());
        }
    }
}
