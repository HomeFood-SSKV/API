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
    
    public partial class MAS_FoodTypeDto
    {
        public MAS_FoodTypeDto()
        {
            this.MAS_FoodDto = new HashSet<MAS_FoodDto>();
            this.TRN_ChefOtherDetailsDto = new HashSet<TRN_ChefOtherDetailsDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int FoodTypeID { get; set; }
        public string FoodType { get; set; }
        public Nullable<int> FoodTypeCode { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<MAS_FoodDto> MAS_FoodDto { get; set; }
        public virtual ICollection<TRN_ChefOtherDetailsDto> TRN_ChefOtherDetailsDto { get; set; }
    }
}
