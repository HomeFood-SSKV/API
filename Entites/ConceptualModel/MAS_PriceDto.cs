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
    public partial class MAS_PriceDto
    {
        [DataMember]
        public System.Guid UniqueId { get; set; }
        [DataMember]
        public int PriceId { get; set; }
        [DataMember]
        public int FoodId { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string GSTPrice { get; set; }
        [DataMember]
        public string GSTPercentage { get; set; }
        [JsonIgnore]
        [DataMember]
        public bool IsDeleted { get; set; }
    
    }
}