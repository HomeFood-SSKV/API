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
    [ModelMetadataType(typeof(MAS_CityMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_Area))]
    [KnownType(typeof(TRN_ChefDetails))]
    [KnownType(typeof(TRN_UserAddressDetails))]
    public partial class MAS_City  :BusinessEntityBase 
    {
    public MAS_City()
    {
    this.MAS_Area = new HashSet<MAS_Area>();
    this.TRN_ChefDetails = new HashSet<TRN_ChefDetails>();
    this.TRN_UserAddressDetails = new HashSet<TRN_UserAddressDetails>();
    }
    
     [DataMember]
    public System.Guid UniqueId { get; set; }
     [Key()]
     [DataMember]
    public int CityId { get; set; }
     [DataMember]
    public string CityName { get; set; }
     [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual ICollection<MAS_Area> MAS_Area { get; set; }
    [DataMember]
    public virtual ICollection<TRN_ChefDetails> TRN_ChefDetails { get; set; }
    [DataMember]
    public virtual ICollection<TRN_UserAddressDetails> TRN_UserAddressDetails { get; set; }
    }
    
}
