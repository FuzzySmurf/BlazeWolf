using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Dimension
    {
        public Dimension()
        {
            this.GameDetails = new List<GameDetail>();
        }

        public int DimensionID { get; set; }
        public string Dimension1 { get; set; }
        public virtual ICollection<GameDetail> GameDetails { get; set; }
    }
}
