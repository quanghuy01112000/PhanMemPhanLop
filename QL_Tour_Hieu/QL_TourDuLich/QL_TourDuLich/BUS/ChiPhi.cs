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
    
    public partial class ChiPhi
    {
        public int MaChiPhi { get; set; }
        public Nullable<int> MaDoan { get; set; }
        public Nullable<double> SoTien { get; set; }
        public Nullable<int> MaLoaiChiPhi { get; set; }
    
        public virtual DoanDuLich DoanDuLich { get; set; }
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
