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
    
    public partial class MenuTopping
    {
        public MenuTopping()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public string Ten { get; set; }
        public Nullable<double> Gia { get; set; }
    
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
