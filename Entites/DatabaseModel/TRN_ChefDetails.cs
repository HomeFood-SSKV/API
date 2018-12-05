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
    [ModelMetadataType(typeof(TRN_ChefDetailsMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_ChefType))]
    [KnownType(typeof(MAS_City))]
    [KnownType(typeof(TRN_UserDetail))]
    [KnownType(typeof(TRN_ChefOtherDetails))]
    [KnownType(typeof(TRN_MapOrderToChef))]
    public partial class TRN_ChefDetails  :BusinessEntityBase 
    {
    public TRN_ChefDetails()
    {
    this.TRN_ChefOtherDetails = new HashSet<TRN_ChefOtherDetails>();
    this.TRN_MapOrderToChef = new HashSet<TRN_MapOrderToChef>();
    }
    
    [DataMember]
    public System.Guid UniqueId { get; set; }
    [DataMember]
    public int ChefId { get; set; }
    [DataMember]
    public string ChefFullName { get; set; }
    [DataMember]
    public int ChefTypeId { get; set; }
    [DataMember]
    public string MobileNumber { get; set; }
    [DataMember]
    public string AlternateMobileNumber { get; set; }
    [DataMember]
    public string PhoneNumber { get; set; }
    [DataMember]
    public string EmailId { get; set; }
    [DataMember]
    public int CityId { get; set; }
    [DataMember]
    public string AreaName { get; set; }
    [DataMember]
    public string AddressLine1 { get; set; }
    [DataMember]
    public string AddressLine2 { get; set; }
    [DataMember]
    public int UserId { get; set; }
    [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual MAS_ChefType MAS_ChefType { get; set; }
    [DataMember]
    public virtual MAS_City MAS_City { get; set; }
    [DataMember]
    public virtual TRN_UserDetail TRN_UserDetail { get; set; }
    [DataMember]
    public virtual ICollection<TRN_ChefOtherDetails> TRN_ChefOtherDetails { get; set; }
    [DataMember]
    public virtual ICollection<TRN_MapOrderToChef> TRN_MapOrderToChef { get; set; }
    }
    
}
