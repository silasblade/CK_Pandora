//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNSTS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoanNhanVien
    {
        public TaiKhoanNhanVien()
        {
            this.ThongTinNhanViens = new HashSet<ThongTinNhanVien>();
        }
    
        public string MaNV { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<ThongTinNhanVien> ThongTinNhanViens { get; set; }
    }
}