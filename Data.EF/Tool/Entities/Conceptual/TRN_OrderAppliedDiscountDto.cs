//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neeyamo.Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRN_OrderAppliedDiscountDto
    {
        public System.Guid UniqueId { get; set; }
        public int AppliedDiscountId { get; set; }
        public int DiscountId { get; set; }
        public int SpecialDiscountId { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderId { get; set; }
    
        public virtual MAS_DiscountDto MAS_DiscountDto { get; set; }
        public virtual TRN_OrderDto TRN_OrderDto { get; set; }
        public virtual TRN_SpecialDiscountDto TRN_SpecialDiscountDto { get; set; }
    }
}
