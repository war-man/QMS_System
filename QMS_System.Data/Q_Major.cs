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
    
    public partial class Q_Major
    {
        public Q_Major()
        {
            this.Q_ServiceStep = new HashSet<Q_ServiceStep>();
            this.Q_UserMajor = new HashSet<Q_UserMajor>();
            this.Q_DailyRequire_Detail = new HashSet<Q_DailyRequire_Detail>();
            this.Q_HisDailyRequire_De = new HashSet<Q_HisDailyRequire_De>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsShow { get; set; }
    
        public virtual ICollection<Q_ServiceStep> Q_ServiceStep { get; set; }
        public virtual ICollection<Q_UserMajor> Q_UserMajor { get; set; }
        public virtual ICollection<Q_DailyRequire_Detail> Q_DailyRequire_Detail { get; set; }
        public virtual ICollection<Q_HisDailyRequire_De> Q_HisDailyRequire_De { get; set; }
    }
}
