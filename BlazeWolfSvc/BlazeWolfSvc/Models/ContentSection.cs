using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class ContentSection
    {
        public int ContentSectionID { get; set; }
        public int ContentID { get; set; }
        public int SectionID { get; set; }
        public virtual Content Content { get; set; }
        public virtual Section Section { get; set; }
    }
}
