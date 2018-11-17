//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace DotnetCore.Business.Entities
{
    [Microsoft.AspNetCore.Mvc.ModelMetadataType(typeof(TRN_MealPackProcessingMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_MealPack))]
    [KnownType(typeof(TRN_Order))]
    [KnownType(typeof(TRN_UserDetail))]
    public partial class TRN_MealPackProcessing : BusinessEntityBase
    {
        [DataMember]
        public System.Guid UniqueId { get; set; }
        [DataMember]
        [Key]
        public int MealPackProcessingId { get; set; }
        [DataMember]
        public int MealPackId { get; set; }
        [DataMember]
        public int TotalMealCount { get; set; }
        [DataMember]
        public int UsedMealCount { get; set; }
        [DataMember]
        public int RemainingMealCount { get; set; }
        [DataMember]
        public System.DateTime ScheduleDates { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public virtual MAS_MealPack MAS_MealPack { get; set; }
        [DataMember]
        public virtual TRN_Order TRN_Order { get; set; }
        [DataMember]
        public virtual TRN_UserDetail TRN_UserDetail { get; set; }
    }

}