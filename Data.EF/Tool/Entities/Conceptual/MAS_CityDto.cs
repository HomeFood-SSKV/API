//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neeyamo.Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAS_CityDto
    {
        public MAS_CityDto()
        {
            this.TRN_ChefDetailsDto = new HashSet<TRN_ChefDetailsDto>();
            this.TRN_UserAddressDetailsDto = new HashSet<TRN_UserAddressDetailsDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<TRN_ChefDetailsDto> TRN_ChefDetailsDto { get; set; }
        public virtual ICollection<TRN_UserAddressDetailsDto> TRN_UserAddressDetailsDto { get; set; }
    }
}
