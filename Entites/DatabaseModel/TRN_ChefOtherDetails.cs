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
    [Microsoft.AspNetCore.Mvc.ModelMetadataType(typeof(TRN_ChefOtherDetailsMetadata))]
    [DataContract(IsReference = true)]
    [KnownType(typeof(MAS_FoodType))]
    [KnownType(typeof(TRN_ChefDetails))]
    public partial class TRN_ChefOtherDetails : BusinessEntityBase
    {
        [DataMember]
        public System.Guid UniqueId { get; set; }
        [DataMember]
        [Key]
        public int ChefOtherDetailID { get; set; }
        [DataMember]
        public int ChefId { get; set; }
        [DataMember]
        public int FoodTypeId { get; set; }
        [DataMember]
        public string SpecialistAt { get; set; }
        [DataMember]
        public string Descriptions { get; set; }
        [DataMember]
        public Nullable<int> AvaiableDays { get; set; }
        [DataMember]
        public string AvailableTime { get; set; }
        [DataMember]
        public bool AvaiableForLunch { get; set; }
        [DataMember]
        public bool AvailableForDinner { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public virtual MAS_FoodType MAS_FoodType { get; set; }
        [DataMember]
        public virtual TRN_ChefDetails TRN_ChefDetails { get; set; }
    }

}
