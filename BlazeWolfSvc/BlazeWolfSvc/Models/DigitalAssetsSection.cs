using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class DigitalAssetsSection
    {
        public int DigitalAssetSectionID { get; set; }
        public int DigitalAssetID { get; set; }
        public int SectionID { get; set; }
        public virtual DigitalAsset DigitalAsset { get; set; }
        public virtual Section Section { get; set; }
    }
}
