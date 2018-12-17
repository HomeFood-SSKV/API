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
    [ModelMetadataType(typeof(TRN_OrderMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_OrderStatus))]
    [KnownType(typeof(MAS_OrderType))]
    [KnownType(typeof(MAS_PaymentType))]
    [KnownType(typeof(TRN_DeliveryDetails))]
    [KnownType(typeof(TRN_MapOrderToChef))]
    [KnownType(typeof(TRN_MealPackProcessing))]
    [KnownType(typeof(TRN_OrderDetails))]
    [KnownType(typeof(TRN_OrderAppliedDiscount))]
    [KnownType(typeof(TRN_UserDetail))]
    public partial class TRN_Order  :BusinessEntityBase 
    {
    public TRN_Order()
    {
    this.TRN_DeliveryDetails = new HashSet<TRN_DeliveryDetails>();
    this.TRN_MapOrderToChef = new HashSet<TRN_MapOrderToChef>();
    this.TRN_MealPackProcessing = new HashSet<TRN_MealPackProcessing>();
    this.TRN_OrderDetails = new HashSet<TRN_OrderDetails>();
    this.TRN_OrderAppliedDiscount = new HashSet<TRN_OrderAppliedDiscount>();
    }
    
     [DataMember]
    public System.Guid UniqueId { get; set; }
     [Key()]
     [DataMember]
    public int OrderId { get; set; }
     [DataMember]
    public int UserId { get; set; }
     [DataMember]
    public int OrderTypeId { get; set; }
     [DataMember]
    public int OrderStatusId { get; set; }
     [DataMember]
    public Nullable<System.DateTime> OrderCreatedDatetime { get; set; }
     [DataMember]
    public int PaymentTypeId { get; set; }
     [DataMember]
    public Nullable<int> TotalQuantity { get; set; }
     [DataMember]
    public Nullable<int> ActualPrice { get; set; }
     [DataMember]
    public Nullable<int> TotalPrice { get; set; }
     [DataMember]
    public Nullable<int> TotalDiscount { get; set; }
     [DataMember]
    public bool IsDeleted { get; set; }
    
    [DataMember]
    public virtual MAS_OrderStatus MAS_OrderStatus { get; set; }
    [DataMember]
    public virtual MAS_OrderType MAS_OrderType { get; set; }
    [DataMember]
    public virtual MAS_PaymentType MAS_PaymentType { get; set; }
    [DataMember]
    public virtual ICollection<TRN_DeliveryDetails> TRN_DeliveryDetails { get; set; }
    [DataMember]
    public virtual ICollection<TRN_MapOrderToChef> TRN_MapOrderToChef { get; set; }
    [DataMember]
    public virtual ICollection<TRN_MealPackProcessing> TRN_MealPackProcessing { get; set; }
    [DataMember]
    public virtual ICollection<TRN_OrderDetails> TRN_OrderDetails { get; set; }
    [DataMember]
    public virtual ICollection<TRN_OrderAppliedDiscount> TRN_OrderAppliedDiscount { get; set; }
    [DataMember]
    public virtual TRN_UserDetail TRN_UserDetail { get; set; }
    }
    
}
