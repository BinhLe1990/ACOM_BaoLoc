//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DELFI_WHM.NET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSoanHang
    {
        public int ID { get; set; }
        public string QRCode { get; set; }
        public string ItemCode { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
        public string DocumentType { get; set; }
        public string WeightNote { get; set; }
        public string DocumentNo { get; set; }
        public string UserName { get; set; }
        public Nullable<int> IDBatchDetail { get; set; }
    }
}
