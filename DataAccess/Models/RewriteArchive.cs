using System;

namespace DataAccess.Models
{
    public class RewriteArchive : IEntity
    {
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; }
        public string RedirecUrl { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public Redirecttype RedirectType { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }  //username 
        //Todo: should we add this field as well to know who deleted the redirected url ? might be different person than the creator
    }
}
