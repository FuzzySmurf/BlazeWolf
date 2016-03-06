using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class DigitalAssetType
    {
        public DigitalAssetType()
        {
            this.DigitalAssets = new List<DigitalAsset>();
        }

        public int DigitalAssetTypeID { get; set; }
        public string DigitalAssetType1 { get; set; }
        public virtual ICollection<DigitalAsset> DigitalAssets { get; set; }
    }
}
