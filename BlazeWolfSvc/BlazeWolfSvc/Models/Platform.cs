using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Platform
    {
        public Platform()
        {
            this.GameDetails = new List<GameDetail>();
        }

        public int PlatformID { get; set; }
        public string Platform1 { get; set; }
        public virtual ICollection<GameDetail> GameDetails { get; set; }
    }
}
