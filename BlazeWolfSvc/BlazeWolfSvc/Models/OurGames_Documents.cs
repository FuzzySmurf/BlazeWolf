using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class OurGames_Documents
    {
        public int OurGames_DocumentID { get; set; }
        public Nullable<int> GameID { get; set; }
        public Nullable<int> DocumentID { get; set; }
        public virtual Document Document { get; set; }
        public virtual BlazeGame BlazeGame { get; set; }
    }
}
