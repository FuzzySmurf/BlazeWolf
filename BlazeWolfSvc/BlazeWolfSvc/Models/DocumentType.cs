using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            this.Documents = new List<Document>();
        }

        public int DocumentTypeID { get; set; }
        public string DocumentType1 { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
