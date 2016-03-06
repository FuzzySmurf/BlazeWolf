using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class BlazeGame
    {
        public BlazeGame()
        {
            this.OurGame_DigitalAssets = new List<OurGame_DigitalAssets>();
            this.OurGames_Documents = new List<OurGames_Documents>();
            this.BlazeGamesContents = new List<BlazeGamesContent>();
            this.GameDetails = new List<GameDetail>();
        }

        public int GameID { get; set; }
        public string Title { get; set; }
        public string CreatedUser { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<OurGame_DigitalAssets> OurGame_DigitalAssets { get; set; }
        public virtual ICollection<OurGames_Documents> OurGames_Documents { get; set; }
        public virtual ICollection<BlazeGamesContent> BlazeGamesContents { get; set; }
        public virtual ICollection<GameDetail> GameDetails { get; set; }
    }
}
