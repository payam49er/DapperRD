using System;
using System.ComponentModel;

namespace DataAccess.Models
{
    public class ReWrite : IEntity
    {
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; }
        public string RedirecUrl { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime UpdateDate { get; set; }
        public Redirecttype RedirectType { get; set; }
        public string CreatedBy { get; set; }    //username of the user
    }

    public enum Redirecttype
    {
        [Description("301")]
        A = 301,
        [Description("302")]
        B = 302 
    }
}
