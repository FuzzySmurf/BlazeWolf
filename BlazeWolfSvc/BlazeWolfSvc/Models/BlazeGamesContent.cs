using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class BlazeGamesContent
    {
        public int BlazeGamesContentID { get; set; }
        public int GameID { get; set; }
        public int ContentID { get; set; }
        public virtual BlazeGame BlazeGame { get; set; }
    }
}
