//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDonBanBuon
    {
        public int MaHoaDonBanBuon { get; set; }
        public int MaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SoLuongVoThuVe { get; set; }
    
        public virtual HoaDonBanBuon HoaDonBanBuon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
