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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TourDLEntities : DbContext
    {
        public TourDLEntities()
            : base("name=TourDLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiPhi> ChiPhis { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<DoanDuLich> DoanDuLiches { get; set; }
        public virtual DbSet<GiaTour> GiaTours { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiChiPhi> LoaiChiPhis { get; set; }
        public virtual DbSet<LoaiHinhDuLich> LoaiHinhDuLiches { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NoiDungTour> NoiDungTours { get; set; }
        public virtual DbSet<PhanBoNhanVien_Doan> PhanBoNhanVien_Doan { get; set; }
        public virtual DbSet<ThamQuan> ThamQuans { get; set; }
        public virtual DbSet<TourDuLich> TourDuLiches { get; set; }
    }
}
