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
    
    public partial class MAS_DiscountTypeDto
    {
        public MAS_DiscountTypeDto()
        {
            this.MAS_DiscountDto = new HashSet<MAS_DiscountDto>();
            this.TRN_SpecialDiscountDto = new HashSet<TRN_SpecialDiscountDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int DiscountTypeID { get; set; }
        public string DiscountType { get; set; }
        public string Descriptions { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<MAS_DiscountDto> MAS_DiscountDto { get; set; }
        public virtual ICollection<TRN_SpecialDiscountDto> TRN_SpecialDiscountDto { get; set; }
    }
}
