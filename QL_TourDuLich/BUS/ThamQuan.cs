//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_TourDuLich.BUS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThamQuan
    {
        public string MaTour { get; set; }
        public string MaDiaDiem { get; set; }
        public int ThuTu { get; set; }
    
        public virtual DiaDiem DiaDiem { get; set; }
        public virtual TourDuLich TourDuLich { get; set; }
    }
}
