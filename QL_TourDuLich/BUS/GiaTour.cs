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
    
    public partial class GiaTour
    {
        public string MaGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<System.DateTime> ThoiGianBatDau { get; set; }
        public Nullable<System.DateTime> ThoiGianKetThuc { get; set; }
        public string MaTour { get; set; }
    
        public virtual TourDuLich TourDuLich { get; set; }
    }
}
