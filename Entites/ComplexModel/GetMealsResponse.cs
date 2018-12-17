using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.ComplexModel
{
    public class SupportedCategory
    {
        public string categoryId { get; set; }
        public string categoryName { get; set; }
    }

    public class SupportedDate
    {
        public string dateId { get; set; }
        public string date { get; set; }
    }

    public class SupportedType
    {
        public string foodTypeId { get; set; }
        public string foodType { get; set; }
    }

    public class SupportedDiscount
    {
        public string discountId { get; set; }
        public string discountName { get; set; }
        public string discountPrice { get; set; }
    }

    public class DiscountedTotalprice
    {
        public string dateId { get; set; }
        public string Price { get; set; }
    }



    public class Price
    {
        public string priceId { get; set; }
        public string Actualprice { get; set; }
        public string GSTPrice { get; set; }
        public IList<DiscountedTotalprice> DiscountedTotalprice { get; set; }
        public string price { get; set; }
        public string actualPrice { get; set; }
        public string gstPrice { get; set; }
        public IList<DiscountedTotalprice> discountedTotalprice { get; set; }
    }

    public class data
    {
        public string foodId { get; set; }
        public string foodName { get; set; }
        public string foodDescription { get; set; }
        public string imgUrl { get; set; }
        public string foodTypeId { get; set; }
        public string categoryId { get; set; }
        public Price price { get; set; }
        public IList<string> discount { get; set; }
    }

    public class AvailabilityMapping
    {
        public string dateId { get; set; }
        public IList<string> foodId { get; set; }
    }

    public class GetMealsResponse
    {
        public IList<SupportedCategory> supportedCategory { get; set; }
        public IList<SupportedDate> supportedDates { get; set; }
        public IList<SupportedType> supportedType { get; set; }
        public IList<SupportedDiscount> supportedDiscount { get; set; }
        public IList<data> Data { get; set; }
        public IList<AvailabilityMapping> availabilityMapping { get; set; }
    }


}
