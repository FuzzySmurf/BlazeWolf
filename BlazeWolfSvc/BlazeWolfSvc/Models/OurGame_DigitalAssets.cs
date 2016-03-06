using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class OurGame_DigitalAssets
    {
        public int OurGame_DigitalAssetID { get; set; }
        public Nullable<int> GameID { get; set; }
        public Nullable<int> DigitalAssetID { get; set; }
        public virtual DigitalAsset DigitalAsset { get; set; }
        public virtual BlazeGame BlazeGame { get; set; }
    }
}
