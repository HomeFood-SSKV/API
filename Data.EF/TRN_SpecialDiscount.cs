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
    
    public partial class TRN_SpecialDiscount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRN_SpecialDiscount()
        {
            this.TRN_OrderAppliedDiscount = new HashSet<TRN_OrderAppliedDiscount>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int SpecialDiscountId { get; set; }
        public string DiscountName { get; set; }
        public int DiscountTypeID { get; set; }
        public string Descriptions { get; set; }
        public int UserId { get; set; }
        public bool IsDiscountUsed { get; set; }
        public int DiscountPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public Nullable<System.DateTime> ValidityFrom { get; set; }
        public Nullable<System.DateTime> ValidityTo { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MAS_DiscountType MAS_DiscountType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_OrderAppliedDiscount> TRN_OrderAppliedDiscount { get; set; }
        public virtual TRN_UserDetail TRN_UserDetail { get; set; }
    }
}
