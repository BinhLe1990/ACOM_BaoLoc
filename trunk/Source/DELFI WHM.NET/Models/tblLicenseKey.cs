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
    
    public partial class tblLicenseKey
    {
        public int ID { get; set; }
        public string Hardware { get; set; }
        public string CPUInfo { get; set; }
        public string RequestKey { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string ProductKey { get; set; }
        public Nullable<System.DateTime> ActiveDate { get; set; }
        public string ComputerName { get; set; }
        public string UserUse { get; set; }
    }
}
