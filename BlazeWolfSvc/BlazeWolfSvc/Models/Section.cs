using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Section
    {
        public Section()
        {
            this.ContentSections = new List<ContentSection>();
            this.DigitalAssetsSections = new List<DigitalAssetsSection>();
        }

        public int SectionID { get; set; }
        public int SectionTypeID { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<ContentSection> ContentSections { get; set; }
        public virtual ICollection<DigitalAssetsSection> DigitalAssetsSections { get; set; }
        public virtual SectionType SectionType { get; set; }
    }
}
