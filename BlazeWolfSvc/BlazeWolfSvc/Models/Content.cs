using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Content
    {
        public Content()
        {
            this.ContentSections = new List<ContentSection>();
        }

        public int ContentID { get; set; }
        public string Content1 { get; set; }
        public Nullable<int> ContentTypeID { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<ContentSection> ContentSections { get; set; }
        public virtual ContentType ContentType { get; set; }
    }
}
