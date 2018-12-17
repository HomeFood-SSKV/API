using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.ComplexModel
{
   

    public class AddressType
    {
        public string addressTypeId { get; set; }
        public string addressTypeName { get; set; }
    }

    public class DeliveryPoint
    {
        public string deliveryPointId { get; set; }
        public string deliveryPointName { get; set; }
        public string areaId { get; set; }
    }

    public class Area
    {
        public string areaId { get; set; }
        public string areaName { get; set; }
        public string locationId { get; set; }
    }

    public class Location
    {
        public string locationId { get; set; }
        public string locationName { get; set; }
        public string cityId { get; set; }
    }

    public class City
    {
        public string cityId { get; set; }
        public string cityName { get; set; }
    }

    public class Data
    {
        public string addressId { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string areaId { get; set; }
        public string deliveryPointId { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string locationId { get; set; }
        public string cityId { get; set; }
        public string pincode { get; set; }
        public string addressTypeId { get; set; }
    }

    public class GetAllDeliveryAddressResponse
    {
        public List<AddressType> addressType { get; set; }
        public List<DeliveryPoint> deliveryPoint { get; set; }
        public List<Area> area { get; set; }
        public List<Location> location { get; set; }
        public List<City> city { get; set; }
        public List<Data> data { get; set; }
    }
}
