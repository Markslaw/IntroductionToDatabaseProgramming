//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservation_SYS
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVIEW_LOG
    {
        public decimal ID { get; set; }
        public Nullable<decimal> FILTERID { get; set; }
        public Nullable<System.DateTime> RUN_BEGIN { get; set; }
        public Nullable<System.DateTime> RUN_END { get; set; }
        public string TYPE { get; set; }
        public string STATUS { get; set; }
        public string MESSAGE { get; set; }
        public Nullable<decimal> COMPLETED { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ERROR_CODE { get; set; }
    }
}