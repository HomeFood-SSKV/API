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
    
    public partial class MAS_PaymentTypeDto
    {
        public MAS_PaymentTypeDto()
        {
            this.TRN_OrderDto = new HashSet<TRN_OrderDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentType { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<TRN_OrderDto> TRN_OrderDto { get; set; }
    }
}
