//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesaChallengePortal.DatabaseLink
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question : AccesaChallengePortal.Interfaces.IEntity
    {
        public Question()
        {
            this.Responses = new HashSet<Respons>();
        }
    
        public int Id { get; set; }
        public string Body { get; set; }
        public Nullable<int> ChallengeId { get; set; }
        public Nullable<bool> RequiresFile { get; set; }
    
        public virtual Challenge Challenge { get; set; }
        public virtual ICollection<Respons> Responses { get; set; }
    }
}
