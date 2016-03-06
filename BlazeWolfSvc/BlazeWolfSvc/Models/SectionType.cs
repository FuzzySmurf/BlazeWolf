using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class SectionType
    {
        public SectionType()
        {
            this.Sections = new List<Section>();
        }

        public int SectionTypeID { get; set; }
        public string SectionType1 { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
