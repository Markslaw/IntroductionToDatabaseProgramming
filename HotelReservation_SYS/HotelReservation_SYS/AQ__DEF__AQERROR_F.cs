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
    
    public partial class AQ__DEF__AQERROR_F
    {
        public string Q_NAME { get; set; }
        public string ROW_ID { get; set; }
        public Nullable<System.Guid> MSGID { get; set; }
        public string CORRID { get; set; }
        public Nullable<decimal> PRIORITY { get; set; }
        public Nullable<decimal> STATE { get; set; }
        public Nullable<System.DateTime> DELAY { get; set; }
        public Nullable<decimal> EXPIRATION { get; set; }
        public Nullable<System.DateTime> ENQ_TIME { get; set; }
        public Nullable<decimal> ENQ_UID { get; set; }
        public string ENQ_TID { get; set; }
        public Nullable<System.DateTime> DEQ_TIME { get; set; }
        public Nullable<decimal> DEQ_UID { get; set; }
        public string DEQ_TID { get; set; }
        public Nullable<decimal> RETRY_COUNT { get; set; }
        public string EXCEPTION_QSCHEMA { get; set; }
        public string EXCEPTION_QUEUE { get; set; }
        public Nullable<decimal> CSCN { get; set; }
        public Nullable<decimal> DSCN { get; set; }
        public Nullable<decimal> CHAIN_NO { get; set; }
        public Nullable<decimal> LOCAL_ORDER_NO { get; set; }
        public Nullable<System.DateTime> TIME_MANAGER_INFO { get; set; }
        public decimal STEP_NO { get; set; }
        public byte[] USER_DATA { get; set; }
        public decimal QUEUE_ID { get; set; }
    }
}