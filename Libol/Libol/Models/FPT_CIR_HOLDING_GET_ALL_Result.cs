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
    
    public partial class FPT_CIR_HOLDING_GET_ALL_Result
    {
        public int ID { get; set; }
        public string FULLNAME { get; set; }
        public string ROLLNUMBER { get; set; }
        public string BOOKNAME { get; set; }
        public string BOOKCODE { get; set; }
        public System.DateTime CREATEDATE { get; set; }
        public Nullable<System.DateTime> TIMEOUTDATE { get; set; }
        public bool CheckMail { get; set; }
        public Nullable<bool> InTurn { get; set; }
        public string ORDER_STATUS { get; set; }
    }
}
