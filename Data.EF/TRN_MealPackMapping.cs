//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRN_MealPackMapping
    {
        public System.Guid UniqueId { get; set; }
        public int MealPackMappingId { get; set; }
        public int MealPackId { get; set; }
        public int FoodId { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MAS_Food MAS_Food { get; set; }
        public virtual MAS_MealPack MAS_MealPack { get; set; }
    }
}
