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
    
    public partial class MAS_RoleDto
    {
        public MAS_RoleDto()
        {
            this.TRN_GroupRightsDto = new HashSet<TRN_GroupRightsDto>();
            this.TRN_UserDetailDto = new HashSet<TRN_UserDetailDto>();
        }
    
        public System.Guid UniqueId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<TRN_GroupRightsDto> TRN_GroupRightsDto { get; set; }
        public virtual ICollection<TRN_UserDetailDto> TRN_UserDetailDto { get; set; }
    }
}
