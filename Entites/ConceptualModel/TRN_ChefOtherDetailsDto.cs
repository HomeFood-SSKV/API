//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotnetCore.Business.Entities
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public partial class TRN_ChefOtherDetailsDto
    {
        [DataMember]
        public System.Guid UniqueId { get; set; }
        [DataMember]
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
        [JsonIgnore]
        public bool IsDeleted { get; set; }
    }
}