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
    
    public partial class Q_HisDailyRequire
    {
        public Q_HisDailyRequire()
        {
            this.Q_HisDailyRequire_De = new HashSet<Q_HisDailyRequire_De>();
            this.Q_HisDailyRequire_WorkDetail = new HashSet<Q_HisDailyRequire_WorkDetail>();
        }
    
        public int Id { get; set; }
        public int TicketNumber { get; set; }
        public int ServiceId { get; set; }
        public Nullable<int> BusinessId { get; set; }
        public System.DateTime PrintTime { get; set; }
        public string CarNumber { get; set; }
        public string PhoneNumber { get; set; }
        public System.TimeSpan ServeTimeAllow { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> CustomerDOB { get; set; }
        public string CustomerAddress { get; set; }
        public string STT_PhongKham { get; set; }
        public string MaBenhNhan { get; set; }
        public string MaPhongKham { get; set; }
    
        public virtual Q_Business Q_Business { get; set; }
        public virtual ICollection<Q_HisDailyRequire_De> Q_HisDailyRequire_De { get; set; }
        public virtual Q_Service Q_Service { get; set; }
        public virtual ICollection<Q_HisDailyRequire_WorkDetail> Q_HisDailyRequire_WorkDetail { get; set; }
    }
}
