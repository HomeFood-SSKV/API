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
    
    public partial class MAS_DiscountType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAS_DiscountType()
        {
            this.MAS_Discount = new HashSet<MAS_Discount>();
            this.TRN_SpecialDiscount = new HashSet<TRN_SpecialDiscount>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int DiscountTypeID { get; set; }
        public string DiscountType { get; set; }
        public string Descriptions { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAS_Discount> MAS_Discount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_SpecialDiscount> TRN_SpecialDiscount { get; set; }
    }
}
