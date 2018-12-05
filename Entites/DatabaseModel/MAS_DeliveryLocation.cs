//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace DotnetCore.Business.Entities
{
    [ModelMetadataType(typeof(MAS_DeliveryLocationMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(TRN_DeliveryDetails))]
    [KnownType(typeof(TRN_UserAddressDetails))]
    public partial class MAS_DeliveryLocation  :BusinessEntityBase 
    {
    public MAS_DeliveryLocation()
    {
    this.TRN_DeliveryDetails = new HashSet<TRN_DeliveryDetails>();
    this.TRN_UserAddressDetails = new HashSet<TRN_UserAddressDetails>();
    }
    
    [DataMember]
    public System.Guid UniqueId { get; set; }
    [DataMember]
    public int DeliveyPointId { get; set; }
    [DataMember]
    public string DeliveryPointName { get; set; }
    [DataMember]
    public int AreaId { get; set; }
    [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual ICollection<TRN_DeliveryDetails> TRN_DeliveryDetails { get; set; }
    [DataMember]
    public virtual ICollection<TRN_UserAddressDetails> TRN_UserAddressDetails { get; set; }
    }
    
}
