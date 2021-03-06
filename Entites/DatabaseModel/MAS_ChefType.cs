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
    [ModelMetadataType(typeof(MAS_ChefTypeMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(TRN_ChefDetails))]
    public partial class MAS_ChefType  :BusinessEntityBase 
    {
    public MAS_ChefType()
    {
    this.TRN_ChefDetails = new HashSet<TRN_ChefDetails>();
    }
    
     [DataMember]
    public System.Guid UniqueId { get; set; }
     [Key()]
     [DataMember]
    public int ChefTypeId { get; set; }
     [DataMember]
    public string ChefType { get; set; }
     [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual ICollection<TRN_ChefDetails> TRN_ChefDetails { get; set; }
    }
    
}
