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
    
    public partial class TRN_DeliveryDetails
    {
        public System.Guid UniqueId { get; set; }
        public int DeliveryDetailId { get; set; }
        public int OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime ScheduleDeliveryDate { get; set; }
        public Nullable<bool> IsDelivered { get; set; }
        public int DeliveryPointId { get; set; }
        public int AddressDetailId { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MAS_DeliveryLocation MAS_DeliveryLocation { get; set; }
        public virtual TRN_UserAddressDetails TRN_UserAddressDetails { get; set; }
        public virtual TRN_Order TRN_Order { get; set; }
    }
}