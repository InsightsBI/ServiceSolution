//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insights.DataLayer.Tables
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserReport
    {
        public int UserReportID { get; set; }
        public Nullable<int> ReportID { get; set; }
        public Nullable<int> DashboardId { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Dashboard Dashboard { get; set; }
        public virtual Report Report { get; set; }
        public virtual User User { get; set; }
    }
}
