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
    [ModelMetadataType(typeof(MAS_OrderTypeMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_MealPack))]
    [KnownType(typeof(TRN_Order))]
    public partial class MAS_OrderType  :BusinessEntityBase 
    {
    public MAS_OrderType()
    {
    this.MAS_MealPack = new HashSet<MAS_MealPack>();
    this.TRN_Order = new HashSet<TRN_Order>();
    }
    
     [DataMember]
    public System.Guid UniqueId { get; set; }
     [Key()]
     [DataMember]
    public int OrderTypeId { get; set; }
     [DataMember]
    public string OrderTypeCode { get; set; }
     [DataMember]
    public string Descriptions { get; set; }
     [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual ICollection<MAS_MealPack> MAS_MealPack { get; set; }
    [DataMember]
    public virtual ICollection<TRN_Order> TRN_Order { get; set; }
    }
    
}
