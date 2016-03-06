using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class GameDetail
    {
        public int GameDetailsID { get; set; }
        public int GameID { get; set; }
        public Nullable<int> PlatformID { get; set; }
        public Nullable<int> GenreID { get; set; }
        public Nullable<int> DimensionID { get; set; }
        public bool IsOnline { get; set; }
        public bool IsMultiplayer { get; set; }
        public Nullable<int> MaxPlayers { get; set; }
        public virtual BlazeGame BlazeGame { get; set; }
        public virtual Dimension Dimension { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Platform Platform { get; set; }
    }
}
