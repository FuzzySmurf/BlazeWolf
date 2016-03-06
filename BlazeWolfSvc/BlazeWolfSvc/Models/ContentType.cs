using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class ContentType
    {
        public ContentType()
        {
            this.Contents = new List<Content>();
        }

        public int ContentTypeID { get; set; }
        public string ContentType1 { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
    }
}
