//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QMS_System.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Q_StatusType
    {
        public Q_StatusType()
        {
            this.Q_Status = new HashSet<Q_Status>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    
        public virtual ICollection<Q_Status> Q_Status { get; set; }
    }
}
