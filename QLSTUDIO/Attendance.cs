//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSTUDIO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int attendance_id { get; set; }
        public int schedule_id { get; set; }
        public int member_id { get; set; }
        public System.DateTime attendance_date { get; set; }
        public string status { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
