using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Entites.ComplexModel
{
    [Serializable]
    class AddOrUpdateAddressRequest
    {
        [DataMember]
        public string userId { get; set; }
        [DataMember]
        public string adressId { get; set; }
        [DataMember]
        public string fullName { get; set; }
        [DataMember]
        public string phoneNumber { get; set; }
        [DataMember]
        public string areaDataId { get; set; }
        [DataMember]
        public string deliveryPointId { get; set; }
        [DataMember]
        public string addressLine1 { get; set; }
        [DataMember]
        public string addressLine2 { get; set; }
        [DataMember]
        public string cityId { get; set; }
        [DataMember]
        public string pincode { get; set; }
        [DataMember]
        public string addressTypeId { get; set; }
    }
}
