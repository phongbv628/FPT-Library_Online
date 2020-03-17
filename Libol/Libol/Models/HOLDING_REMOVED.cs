//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOLDING_REMOVED
    {
        public int ID { get; set; }
        public string CopyNumber { get; set; }
        public int ItemID { get; set; }
        public int LibID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public int LoanTypeID { get; set; }
        public string Shelf { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Reason { get; set; }
        public Nullable<System.DateTime> AcquiredDate { get; set; }
        public Nullable<System.DateTime> RemovedDate { get; set; }
        public string Volume { get; set; }
        public Nullable<int> UseCount { get; set; }
        public Nullable<int> PoID { get; set; }
        public Nullable<System.DateTime> DateLastUsed { get; set; }
        public string CallNumber { get; set; }
        public Nullable<int> AcquiredSourceID { get; set; }
        public string LiquidCode { get; set; }
    }
}