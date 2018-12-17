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
    
    public partial class MAS_FoodDto
    {
        public MAS_FoodDto()
        {
            this.MAS_DiscountDto = new HashSet<MAS_DiscountDto>();
            this.MAS_PriceDto = new HashSet<MAS_PriceDto>();
            this.TRN_MealPackMappingDto = new HashSet<TRN_MealPackMappingDto>();
            this.TRN_OrderDetailsDto = new HashSet<TRN_OrderDetailsDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Descriptions { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> FoodTypeID { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MAS_CategoryDto MAS_CategoryDto { get; set; }
        public virtual ICollection<MAS_DiscountDto> MAS_DiscountDto { get; set; }
        public virtual MAS_FoodTypeDto MAS_FoodTypeDto { get; set; }
        public virtual ICollection<MAS_PriceDto> MAS_PriceDto { get; set; }
        public virtual ICollection<TRN_MealPackMappingDto> TRN_MealPackMappingDto { get; set; }
        public virtual ICollection<TRN_OrderDetailsDto> TRN_OrderDetailsDto { get; set; }
    }
}
