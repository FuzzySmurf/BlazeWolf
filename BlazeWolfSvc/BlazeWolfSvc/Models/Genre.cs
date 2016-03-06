using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Genre
    {
        public Genre()
        {
            this.GameDetails = new List<GameDetail>();
        }

        public int GenreID { get; set; }
        public string Genre1 { get; set; }
        public virtual ICollection<GameDetail> GameDetails { get; set; }
    }
}
