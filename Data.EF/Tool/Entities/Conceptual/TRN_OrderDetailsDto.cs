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
    
    public partial class TRN_OrderDetailsDto
    {
        public System.Guid UniqueId { get; set; }
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MAS_FoodDto MAS_FoodDto { get; set; }
        public virtual TRN_OrderDto TRN_OrderDto { get; set; }
    }
}
