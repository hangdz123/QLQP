//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLQP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> idNCC { get; set; }
        public string MoTa { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> idSP { get; set; }
        public string Img { get; set; }
    
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
