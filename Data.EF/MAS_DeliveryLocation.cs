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
    
    public partial class MAS_DeliveryLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAS_DeliveryLocation()
        {
            this.TRN_DeliveryDetails = new HashSet<TRN_DeliveryDetails>();
            this.TRN_UserAddressDetails = new HashSet<TRN_UserAddressDetails>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int DeliveyPointId { get; set; }
        public string DeliveryPointName { get; set; }
        public int AreaId { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_DeliveryDetails> TRN_DeliveryDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRN_UserAddressDetails> TRN_UserAddressDetails { get; set; }
    }
}
