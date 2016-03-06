using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class DigitalAsset
    {
        public DigitalAsset()
        {
            this.OurGame_DigitalAssets = new List<OurGame_DigitalAssets>();
            this.DigitalAssetsSections = new List<DigitalAssetsSection>();
        }

        public int DigitalAssetID { get; set; }
        public Nullable<int> DigitalAssetTypeID { get; set; }
        public string DigitalAssetName { get; set; }
        public string FileName { get; set; }
        public string LinkReference { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<OurGame_DigitalAssets> OurGame_DigitalAssets { get; set; }
        public virtual ICollection<DigitalAssetsSection> DigitalAssetsSections { get; set; }
        public virtual DigitalAssetType DigitalAssetType { get; set; }
    }
}
