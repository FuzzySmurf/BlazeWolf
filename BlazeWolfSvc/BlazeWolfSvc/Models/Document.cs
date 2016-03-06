using System;
using System.Collections.Generic;

namespace BlazeWolfSvc.Models
{
    public partial class Document
    {
        public Document()
        {
            this.OurGames_Documents = new List<OurGames_Documents>();
        }

        public int DocumentID { get; set; }
        public Nullable<int> DocumentTypeID { get; set; }
        public string DocumentName { get; set; }
        public string FileName { get; set; }
        public string LinkReference { get; set; }
        public string CreatedUser { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<OurGames_Documents> OurGames_Documents { get; set; }
    }
}
