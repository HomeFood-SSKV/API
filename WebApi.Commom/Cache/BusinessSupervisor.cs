
using DotnetCore.Business;
using DotnetCore.Business.Entities;
using DotnetCore.Business.Interfaces;
using DotnetCore.Web.Helpers;
using Neeyamo.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Common;

namespace DotnetCore.Web.Models
{
    public class BusinessSupervisor
    {
        private static IBusiness _dotnetcoreSvr;
        public static IBusiness DotnetCoreSvr
        {
            get
            {
                if (_dotnetcoreSvr == null)
                    _dotnetcoreSvr = new DotnetCoreSvr();
                return _dotnetcoreSvr;
            }
            set
            {
                _dotnetcoreSvr = value;
            }
        }


        private readonly string sessionRights = enumTableList.MAS_Rights.ToString();
        private readonly string sessionGroupRights = enumTableList.TRN_GroupRights.ToString();
        private readonly string sessionUserPassword = enumTableList.TRN_UserPassword.ToString();
        private readonly string sessionUserRights = enumTableList.TRN_UserRights.ToString();
        private readonly string sessionAddressType = enumTableList.MAS_AddressType.ToString();
        private readonly string sessionArea = enumTableList.MAS_Area.ToString();
        private readonly string sessionCategory = enumTableList.MAS_Category.ToString();
        private readonly string sessionChefType = enumTableList.MAS_ChefType.ToString();
        private readonly string sessionCity = enumTableList.MAS_City.ToString();
        private readonly string sessionDeliveryLocation = enumTableList.MAS_DeliveryLocation.ToString();
        private readonly string sessionDiscount = enumTableList.MAS_Discount.ToString();
        private readonly string sessionDiscountType = enumTableList.MAS_DiscountType.ToString();
        private readonly string sessionFood = enumTableList.MAS_Food.ToString();
        private readonly string sessionFoodType = enumTableList.MAS_FoodType.ToString();
        private readonly string sessionMealPack = enumTableList.MAS_MealPack.ToString();
        private readonly string sessionOrderStatus = enumTableList.MAS_OrderStatus.ToString();
        private readonly string sessionOrderType = enumTableList.MAS_OrderType.ToString();
        private readonly string sessionPaymentType = enumTableList.MAS_PaymentType.ToString();
        private readonly string sessionPrice = enumTableList.MAS_AddressType.ToString();
        private readonly string sessionRole = enumTableList.MAS_Price.ToString();
        private readonly string sessionChefDetails = enumTableList.TRN_ChefDetails.ToString();
        private readonly string sessionChefOrder = enumTableList.TRN_ChefOrder.ToString();
        private readonly string sessionChefOtherDetails = enumTableList.TRN_ChefOtherDetails.ToString();
        private readonly string sessionDeliveryDetails = enumTableList.TRN_DeliveryDetails.ToString();
        private readonly string sessionLoginDetail = enumTableList.TRN_LoginDetail.ToString();
        private readonly string sessionMapOrderToChef = enumTableList.TRN_MapOrderToChef.ToString();
        private readonly string sessionMealPackMapping = enumTableList.TRN_MealPackMapping.ToString();
        private readonly string sessionMealPackProcessing = enumTableList.TRN_MealPackProcessing.ToString();
        private readonly string sessionOrder = enumTableList.TRN_Order.ToString();
        private readonly string sessionOrderAppliedDiscount = enumTableList.TRN_OrderAppliedDiscount.ToString();
        private readonly string sessionOrderDetails = enumTableList.TRN_OrderDetails.ToString();
        private readonly string sessionSpecialDiscount = enumTableList.TRN_SpecialDiscount.ToString();
        private readonly string sessionUserAddressDetails = enumTableList.TRN_UserAddressDetails.ToString();
        private readonly string sessionUserDetail = enumTableList.TRN_UserDetail.ToString();
        private readonly int Zero = 0;

        public void ResetAll()
        {
            ResetAddressType();
            ResetArea();
            ResetCategory();
            ResetChefType();
            ResetCity();
            ResetDeliveryLocation();
            ResetDiscount();
            ResetDiscountType();
            ResetFood();
            ResetFoodType();
            ResetMealPack();
            ResetOrderType();
            ResetPaymentType();
            ResetPrice();
            ResetRole();
            ResetChefDetails();
            ResetChefOrder();
            ResetChefOtherDetails();
            ResetDeliveryDetails();
           // ResetLoginDetail();
            ResetMapOrderToChef();
            ResetMealPackMapping();
            ResetMealPackProcessing();
            ResetOrder();
            ResetOrderAppliedDiscount();
            ResetOrderDetails();
            ResetSpecialDiscount();
            ResetUserAddressDetails();
            ResetUserDetail();
        }

        public async Task<List<MAS_AddressTypeDto>> GetMASAddressType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                List<MAS_AddressTypeDto> fieldListTemp;
                if (!RedisDbWrapper.Get(sessionAddressType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASAddressType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionAddressType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_AddressTypeDto> GetMASAddressTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASAddressType(ct);
                return result.FirstOrDefault(s => s.AddressTypeId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASAddressType(MAS_AddressTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASAddressType(customObject, commit, ct);
            if (result != 0)
                ResetAddressType();
            return result;
        }

        public async Task<bool> UpdateMASAddressType(MAS_AddressTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASAddressType(customObject, commit, ct);
            if (result)
                ResetAddressType();
            return result;
        }

        public async Task<bool> DeleteAMSAddressType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await GetMASAddressTypeById(id, ct);
            if (result != null)
            {
                result.IsDeleted = true;
                var isUpdated = await UpdateMASAddressType(result, commit, ct);
                if (isUpdated)
                    ResetAddressType();
                return isUpdated;
            }
            return false;
        }


        private void ResetAddressType()
        {
            Task.Run(() =>
           {
               EntityChangeObserverMaster.DataSetObserver(sessionAddressType, Zero, Zero, Zero);
           });
        }




        public async Task<List<MAS_RightsDto>> GetMASRights(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                List<MAS_RightsDto> fieldListTemp;
                if (!RedisDbWrapper.Get(sessionRights, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASRights(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionRights, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_RightsDto> GetMASRightsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASRights(ct);
                return result.FirstOrDefault(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASRights(MAS_RightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASRights(customObject, commit, ct);
            if (result != 0)
                ResetRights();
            return result;
        }

        public async Task<bool> UpdateMASRights(MAS_RightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASRights(customObject, commit, ct);
            if (result)
                ResetRights();
            return result;
        }

        public async Task<bool> DeleteMASRights(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await GetMASRightsById(id, ct);
            if (result != null)
            {
                result.IsDeleted = true;
                var isUpdated = await UpdateMASRights(result, commit, ct);
                if (isUpdated)
                    ResetRights();
                return isUpdated;
            }
            return false;
        }


        private void ResetRights()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionRights, Zero, Zero, Zero);
            });
        }



        public async Task<List<MAS_AreaDto>> GetMASArea(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                List<MAS_AreaDto> fieldListTemp;
                if (!RedisDbWrapper.Get(sessionArea, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASArea(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionArea, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_AreaDto> GetAreaById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASArea(ct);
                return result.FirstOrDefault(s => s.AreaId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASArea(MAS_AreaDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASArea(customObject, commit, ct);
            if (result != 0)
                ResetArea();
            return result;
        }

        public async Task<bool> UpdateMASArea(MAS_AreaDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASArea(customObject, commit, ct);
            if (result)
                ResetArea();
            return result;
        }

        public async Task<bool> DeleteMASArea(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetAreaById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASArea(resultItem, commit, ct);
                if (isUpdated)
                    ResetArea();
                return isUpdated;
            }
            return false;
        }


        private void ResetArea()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionArea, Zero, Zero, Zero);
            });
        }

        public async Task<List<MAS_CategoryDto>> GetMASCategory(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                List<MAS_CategoryDto> fieldListTemp = new List<MAS_CategoryDto>();
                if (!RedisDbWrapper.Get(sessionCategory, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASCategory(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionCategory, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_CategoryDto> GetCategoryById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASCategory(ct);
                return result.FirstOrDefault(s => s.CategoryId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASCategory(MAS_CategoryDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASCategory(customObject, commit, ct);
            if (result != 0)
                ResetCategory();
            return result;
        }

        public async Task<bool> UpdateMASCategory(MAS_CategoryDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASCategory(customObject, commit, ct);
            if (result)
                ResetCategory();
            return result;
        }

        public async Task<bool> DeleteMASCategory(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetCategoryById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASCategory(resultItem, commit, ct);
                if (isUpdated)
                    ResetCategory();
                return isUpdated;
            }
            return false;
        }


        private void ResetCategory()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionCategory, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_ChefTypeDto>> GetMASChefType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_ChefTypeDto>();
                if (!RedisDbWrapper.Get(sessionChefType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASChefType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionChefType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_ChefTypeDto> GetChefTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASChefType(ct);
                return result.FirstOrDefault(s => s.ChefTypeId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASChefType(MAS_ChefTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASChefType(customObject, commit, ct);
            if (result != 0)
                ResetChefType();
            return result;
        }

        public async Task<bool> UpdateMASChefType(MAS_ChefTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASChefType(customObject, commit, ct);
            if (result)
                ResetChefType();
            return result;
        }

        public async Task<bool> DeleteMASChefType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetChefTypeById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASChefType(resultItem, commit, ct);
                if (isUpdated)
                    ResetChefType();
                return isUpdated;
            }
            return false;
        }


        private void ResetChefType()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionChefType, Zero, Zero, Zero);
            });
        }



        public async Task<List<MAS_CityDto>> GetMASCity(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_CityDto>();
                if (!RedisDbWrapper.Get(sessionCity, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASCity(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionCity, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_CityDto> GetCityById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASCity(ct);
                return result.FirstOrDefault(s => s.CityId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASCity(MAS_CityDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASCity(customObject, commit, ct);
            if (result != 0)
                ResetCity();
            return result;
        }

        public async Task<bool> UpdateMASCity(MAS_CityDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASCity(customObject, commit, ct);
            if (result)
                ResetCity();
            return result;
        }

        public async Task<bool> DeleteMASCity(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetCityById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASCity(resultItem, commit, ct);
                if (isUpdated)
                    ResetCity();
                return isUpdated;
            }
            return false;
        }


        private void ResetCity()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionCity, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_DeliveryLocationDto>> GetMASDeliveryLocation(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_DeliveryLocationDto>();
                if (!RedisDbWrapper.Get(sessionDeliveryLocation, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASDeliveryLocation(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionDeliveryLocation, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_DeliveryLocationDto> GetDeliveryLocationById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASDeliveryLocation(ct);
                return result.FirstOrDefault(s => s.DeliveyPointId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASDeliveryLocation(MAS_DeliveryLocationDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASDeliveryLocation(customObject, commit, ct);
            if (result != 0)
                ResetDeliveryLocation();
            return result;
        }

        public async Task<bool> UpdateMASDeliveryLocation(MAS_DeliveryLocationDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASDeliveryLocation(customObject, commit, ct);
            if (result)
                ResetDeliveryLocation();
            return result;
        }

        public async Task<bool> DeleteMASDeliveryLocation(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetDeliveryLocationById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASDeliveryLocation(resultItem, commit, ct);
                if (isUpdated)
                    ResetDeliveryLocation();
                return isUpdated;
            }
            return false;
        }


        private void ResetDeliveryLocation()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionDeliveryLocation, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_DiscountDto>> GetMASDiscount(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_DiscountDto>();
                if (!RedisDbWrapper.Get(sessionDiscount, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASDiscount(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionDiscount, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_DiscountDto> GetDiscountById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASDiscount(ct);
                return result.FirstOrDefault(s => s.DiscountId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASDiscount(MAS_DiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASDiscount(customObject, commit, ct);
            if (result != 0)
                ResetDiscount();
            return result;
        }

        public async Task<bool> UpdateMASDiscount(MAS_DiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASDiscount(customObject, commit, ct);
            if (result)
                ResetDiscount();
            return result;
        }

        public async Task<bool> DeleteMASDiscount(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetDiscountById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASDiscount(resultItem, commit, ct);
                if (isUpdated)
                    ResetDiscount();
                return isUpdated;
            }
            return false;
        }


        private void ResetDiscount()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionDiscount, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_DiscountTypeDto>> GetMASDiscountType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_DiscountTypeDto>();
                if (!RedisDbWrapper.Get(sessionDiscountType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASDiscountType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionDiscountType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_DiscountTypeDto> GetDiscountTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASDiscountType(ct);
                return result.FirstOrDefault(s => s.DiscountTypeID == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASDiscountType(MAS_DiscountTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASDiscountType(customObject, commit, ct);
            if (result != 0)
                ResetDiscountType();
            return result;
        }

        public async Task<bool> UpdateMASDiscountType(MAS_DiscountTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASDiscountType(customObject, commit, ct);
            if (result)
                ResetDiscountType();
            return result;
        }

        public async Task<bool> DeleteMASDiscountType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetDiscountTypeById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASDiscountType(resultItem, commit, ct);
                if (isUpdated)
                    ResetDiscountType();
                return isUpdated;
            }
            return false;
        }

        private void ResetDiscountType()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionDiscountType, Zero, Zero, Zero);
            });
        }

        public async Task<List<MAS_FoodDto>> GetMASFood(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_FoodDto>();
                if (!RedisDbWrapper.Get(sessionFood, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASFood(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionFood, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_FoodDto> GetFoodById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASFood(ct);
                return result.FirstOrDefault(s => s.FoodId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASFood(MAS_FoodDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASFood(customObject, commit, ct);
            if (result != 0)
                ResetFood();
            return result;
        }

        public async Task<bool> UpdateMASFood(MAS_FoodDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASFood(customObject, commit, ct);
            if (result)
                ResetFood();
            return result;
        }

        public async Task<bool> DeleteMASFood(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetFoodById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASFood(resultItem, commit, ct);
                if (isUpdated)
                    ResetFood();
                return isUpdated;
            }
            return false;
        }


        private void ResetFood()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionFood, Zero, Zero, Zero);
            });
        }



        public async Task<List<MAS_FoodTypeDto>> GetMASFoodType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_FoodTypeDto>();
                if (!RedisDbWrapper.Get(sessionFoodType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASFoodType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionFoodType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_FoodTypeDto> GetFoodTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASFoodType(ct);
                return result.FirstOrDefault(s => s.FoodTypeID == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASFoodType(MAS_FoodTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASFoodType(customObject, commit, ct);
            if (result != 0)
                ResetFoodType();
            return result;
        }

        public async Task<bool> UpdateMASFoodType(MAS_FoodTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASFoodType(customObject, commit, ct);
            if (result)
                ResetFoodType();
            return result;
        }

        public async Task<bool> DeleteMASFoodType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetFoodTypeById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASFoodType(resultItem, commit, ct);
                if (isUpdated)
                    ResetFoodType();
                return isUpdated;
            }
            return false;
        }


        private void ResetFoodType()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionFoodType, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_MealPackDto>> GetMASMealPack(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_MealPackDto>();
                if (!RedisDbWrapper.Get(sessionMealPack, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASMealPack(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionMealPack, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_MealPackDto> GetMealPackById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASMealPack(ct);
                return result.FirstOrDefault(s => s.MealPackId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASMealPack(MAS_MealPackDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASMealPack(customObject, commit, ct);
            if (result != 0)
                ResetMealPack();
            return result;
        }

        public async Task<bool> UpdateMASMealPack(MAS_MealPackDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASMealPack(customObject, commit, ct);
            if (result)
                ResetMealPack();
            return result;
        }

        public async Task<bool> DeleteMASMealPack(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetMealPackById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASMealPack(resultItem, commit, ct);
                if (isUpdated)
                    ResetMealPack();
                return isUpdated;
            }
            return false;
        }


        private void ResetMealPack()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionMealPack, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_OrderStatusDto>> GetMASOrderStatus(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_OrderStatusDto>();
                if (!RedisDbWrapper.Get(sessionOrderStatus, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASOrderStatus(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionOrderStatus, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_OrderStatusDto> GetOrderStatusById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASOrderStatus(ct);
                return result.FirstOrDefault(s => s.OrderStatusId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASOrderStatus(MAS_OrderStatusDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASOrderStatus(customObject, commit, ct);
            if (result != 0)
                ResetOrderStatus();
            return result;
        }

        public async Task<bool> UpdateMASOrderStatus(MAS_OrderStatusDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASOrderStatus(customObject, commit, ct);
            if (result)
                ResetOrderStatus();
            return result;
        }

        public async Task<bool> DeleteMASOrderStatus(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetOrderStatusById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASOrderStatus(resultItem, commit, ct);
                if (isUpdated)
                    ResetOrderStatus();
                return isUpdated;
            }
            return false;
        }


        private void ResetOrderStatus()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionOrderStatus, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_OrderTypeDto>> GetMASOrderType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_OrderTypeDto>();
                if (!RedisDbWrapper.Get(sessionOrderType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASOrderType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionOrderType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_OrderTypeDto> GetOrderTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASOrderType(ct);
                return result.FirstOrDefault(s => s.OrderTypeId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASOrderType(MAS_OrderTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASOrderType(customObject, commit, ct);
            if (result != 0)
                ResetOrderType();
            return result;
        }

        public async Task<bool> UpdateMASOrderType(MAS_OrderTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASOrderType(customObject, commit, ct);
            if (result)
                ResetOrderType();
            return result;
        }

        public async Task<bool> DeleteMASOrderType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetOrderTypeById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASOrderType(resultItem, commit, ct);
                if (isUpdated)
                    ResetOrderType();
                return isUpdated;
            }
            return false;
        }


        private void ResetOrderType()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionOrderType, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_PaymentTypeDto>> GetMASPaymentType(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_PaymentTypeDto>();
                if (!RedisDbWrapper.Get(sessionPaymentType, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASPaymentType(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionPaymentType, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_PaymentTypeDto> GetPaymentTypeById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASPaymentType(ct);
                return result.FirstOrDefault(s => s.PaymentTypeId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASPaymentType(MAS_PaymentTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASPaymentType(customObject, commit, ct);
            if (result != 0)
                ResetPaymentType();
            return result;
        }

        public async Task<bool> UpdateMASPaymentType(MAS_PaymentTypeDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASPaymentType(customObject, commit, ct);
            if (result)
                ResetPaymentType();
            return result;
        }

        public async Task<bool> DeleteMASPaymentType(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetPaymentTypeById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASPaymentType(resultItem, commit, ct);
                if (isUpdated)
                    ResetPaymentType();
                return isUpdated;
            }
            return false;
        }


        private void ResetPaymentType()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionPaymentType, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_PriceDto>> GetMASPrice(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_PriceDto>();
                if (!RedisDbWrapper.Get(sessionPrice, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASPrice(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionPrice, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_PriceDto> GetPriceById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASPrice(ct);
                return result.FirstOrDefault(s => s.PriceId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASPrice(MAS_PriceDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASPrice(customObject, commit, ct);
            if (result != 0)
                ResetPrice();
            return result;
        }

        public async Task<bool> UpdateMASPrice(MAS_PriceDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASPrice(customObject, commit, ct);
            if (result)
                ResetPrice();
            return result;
        }

        public async Task<bool> DeleteMASPrice(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetPriceById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASPrice(resultItem, commit, ct);
                if (isUpdated)
                    ResetPrice();
                return isUpdated;
            }
            return false;
        }


        private void ResetPrice()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionPrice, Zero, Zero, Zero);
            });
        }
        public async Task<List<MAS_RoleDto>> GetMASRole(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<MAS_RoleDto>();
                if (!RedisDbWrapper.Get(sessionRole, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetMASRole(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionRole, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<MAS_RoleDto> GetRoleById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetMASRole(ct);
                return result.FirstOrDefault(s => s.RoleId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertMASRole(MAS_RoleDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertMASRole(customObject, commit, ct);
            if (result != 0)
                ResetRole();
            return result;
        }

        public async Task<bool> UpdateMASRole(MAS_RoleDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateMASRole(customObject, commit, ct);
            if (result)
                ResetRole();
            return result;
        }

        public async Task<bool> DeleteMASRole(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetRoleById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateMASRole(resultItem, commit, ct);
                if (isUpdated)
                    ResetRole();
                return isUpdated;
            }
            return false;
        }


        private void ResetRole()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionChefDetails, Zero, Zero, Zero);
            });
        }




        public async Task<List<TRN_ChefDetailsDto>> GetTRNChefDetails(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_ChefDetailsDto>();
                if (!RedisDbWrapper.Get(sessionChefDetails, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNChefDetails(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionChefDetails, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_ChefDetailsDto> GetChefDetailsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNChefDetails(ct);
                return result.FirstOrDefault(s => s.ChefId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNChefDetails(TRN_ChefDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNChefDetails(customObject, commit, ct);
            if (result != 0)
                ResetChefDetails();
            return result;
        }

        public async Task<bool> UpdateTRNChefDetails(TRN_ChefDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNChefDetails(customObject, commit, ct);
            if (result)
                ResetChefDetails();
            return result;
        }

        public async Task<bool> DeleteTRNChefDetails(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetChefDetailsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNChefDetails(resultItem, commit, ct);
                if (isUpdated)
                    ResetChefDetails();
                return isUpdated;
            }
            return false;
        }


        private void ResetChefDetails()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionChefDetails, Zero, Zero, Zero);
            });
        }
        public async Task<List<TRN_ChefOrderDto>> GetTRNChefOrder(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_ChefOrderDto>();
                if (!RedisDbWrapper.Get(sessionChefOrder, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNChefOrder(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionChefOrder, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_ChefOrderDto> GetChefOrderById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNChefOrder(ct);
                return result.FirstOrDefault(s => s.ChefOrderId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNChefOrder(TRN_ChefOrderDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNChefOrder(customObject, commit, ct);
            if (result != 0)
                ResetChefOrder();
            return result;
        }

        public async Task<bool> UpdateTRNChefOrder(TRN_ChefOrderDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNChefOrder(customObject, commit, ct);
            if (result)
                ResetChefOrder();
            return result;
        }

        public async Task<bool> DeleteTRNChefOrder(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetChefOrderById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNChefOrder(resultItem, commit, ct);
                if (isUpdated)
                    ResetChefOrder();
                return isUpdated;
            }
            return false;
        }


        private void ResetChefOrder()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionChefOrder, Zero, Zero, Zero);
            });
        }
        public async Task<List<TRN_ChefOtherDetailsDto>> GetTRNChefOtherDetails(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_ChefOtherDetailsDto>();
                if (!RedisDbWrapper.Get(sessionChefOtherDetails, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNChefOtherDetails(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionChefOtherDetails, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_ChefOtherDetailsDto> GetChefOtherDetailsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNChefOtherDetails(ct);
                return result.FirstOrDefault(s => s.ChefOtherDetailID == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNChefOtherDetails(TRN_ChefOtherDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNChefOtherDetails(customObject, commit, ct);
            if (result != 0)
                ResetChefOtherDetails();
            return result;
        }

        public async Task<bool> UpdateTRNChefOtherDetails(TRN_ChefOtherDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNChefOtherDetails(customObject, commit, ct);
            if (result)
                ResetChefOtherDetails();
            return result;
        }

        public async Task<bool> DeleteTRNChefOtherDetails(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetChefOtherDetailsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNChefOtherDetails(resultItem, commit, ct);
                if (isUpdated)
                    ResetChefOtherDetails();
                return isUpdated;
            }
            return false;
        }


        private void ResetChefOtherDetails()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionChefOtherDetails, Zero, Zero, Zero);
            });
        }
        public async Task<List<TRN_DeliveryDetailsDto>> GetTRNDeliveryDetails(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_DeliveryDetailsDto>();
                if (!RedisDbWrapper.Get(sessionDeliveryDetails, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNDeliveryDetails(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionDeliveryDetails, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_DeliveryDetailsDto> GetDeliveryDetailsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNDeliveryDetails(ct);
                return result.FirstOrDefault(s => s.DeliveryDetailId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNDeliveryDetails(TRN_DeliveryDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNDeliveryDetails(customObject, commit, ct);
            if (result != 0)
                ResetDeliveryDetails();
            return result;
        }

        public async Task<bool> UpdateTRNDeliveryDetails(TRN_DeliveryDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNDeliveryDetails(customObject, commit, ct);
            if (result)
                ResetDeliveryDetails();
            return result;
        }

        public async Task<bool> DeleteTRNDeliveryDetails(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetDeliveryDetailsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNDeliveryDetails(resultItem, commit, ct);
                if (isUpdated)
                    ResetDeliveryDetails();
                return isUpdated;
            }
            return false;
        }


        private void ResetDeliveryDetails()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionDeliveryDetails, Zero, Zero, Zero);
            });
        }



        //public async Task<List<TRN_LoginDetailDto>> GetTRNLoginDetail(CancellationToken ct = default(CancellationToken))
        //{
        //    try
        //    {
        //        var fieldListTemp = new List<TRN_LoginDetailDto>();
        //        if (!RedisDbWrapper.Get(sessionLoginDetail, Zero, Zero, Zero, out fieldListTemp))
        //        {
        //            fieldListTemp = await DotnetCoreSvr.GetTRNLoginDetail(ct);
        //            RedisDbWrapper.Add(fieldListTemp, sessionLoginDetail, Zero, Zero, Zero);
        //        }
        //        return fieldListTemp;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public async Task<TRN_LoginDetailDto> GetLoginDetailById(int id, CancellationToken ct = default(CancellationToken))
        //{
        //    try
        //    {
        //        var result = await GetTRNLoginDetail(ct);
        //        return result.FirstOrDefault(s => s.LoginId == id);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        //public async Task<int> InsertTRNLoginDetail(TRN_LoginDetailDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        //{
        //    var result = await DotnetCoreSvr.InsertTRNLoginDetail(customObject, commit, ct);
        //    if (result != 0)
        //        ResetLoginDetail();
        //    return result;
        //}

        //public async Task<bool> UpdateTRNLoginDetail(TRN_LoginDetailDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        //{
        //    var result = await DotnetCoreSvr.UpdateTRNLoginDetail(customObject, commit, ct);
        //    if (result)
        //        ResetLoginDetail();
        //    return result;
        //}

        //public async Task<bool> DeleteTRNLoginDetail(int id, bool commit, CancellationToken ct = default(CancellationToken))
        //{
        //    var resultItem = await GetLoginDetailById(id);
        //    if (resultItem != null)
        //    {
        //        resultItem.IsDeleted = true;
        //        var isUpdated = await UpdateTRNLoginDetail(resultItem, commit, ct);
        //        if (isUpdated)
        //            ResetLoginDetail();
        //        return isUpdated;
        //    }
        //    return false;
        //}


        //private void ResetLoginDetail()
        //{
        //    Task.Run(() =>
        //    {
        //        EntityChangeObserverMaster.DataSetObserver(sessionLoginDetail, Zero, Zero, Zero);
        //    });
        //}



        public async Task<List<TRN_MapOrderToChefDto>> GetTRNMapOrderToChef(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_MapOrderToChefDto>();
                if (!RedisDbWrapper.Get(sessionMapOrderToChef, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNMapOrderToChef(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionMapOrderToChef, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_MapOrderToChefDto> GetMapOrderToChefById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNMapOrderToChef(ct);
                return result.FirstOrDefault(s => s.MapOrderID == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNMapOrderToChef(TRN_MapOrderToChefDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNMapOrderToChef(customObject, commit, ct);
            if (result != 0)
                ResetMapOrderToChef();
            return result;
        }

        public async Task<bool> UpdateTRNMapOrderToChef(TRN_MapOrderToChefDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNMapOrderToChef(customObject, commit, ct);
            if (result)
                ResetMapOrderToChef();
            return result;
        }

        public async Task<bool> DeleteTRNMapOrderToChef(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetMapOrderToChefById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNMapOrderToChef(resultItem, commit, ct);
                if (isUpdated)
                    ResetMapOrderToChef();
                return isUpdated;
            }
            return false;
        }


        private void ResetMapOrderToChef()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionMapOrderToChef, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_MealPackMappingDto>> GetTRNMealPackMapping(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_MealPackMappingDto>();
                if (!RedisDbWrapper.Get(sessionMealPackMapping, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNMealPackMapping(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionMealPackMapping, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_MealPackMappingDto> GetMealPackMappingById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNMealPackMapping(ct);
                return result.FirstOrDefault(s => s.MealPackMappingId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNMealPackMapping(TRN_MealPackMappingDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNMealPackMapping(customObject, commit, ct);
            if (result != 0)
                ResetMealPackMapping();
            return result;
        }

        public async Task<bool> UpdateTRNMealPackMapping(TRN_MealPackMappingDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNMealPackMapping(customObject, commit, ct);
            if (result)
                ResetMealPackMapping();
            return result;
        }

        public async Task<bool> DeleteTRNMealPackMapping(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetMealPackMappingById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNMealPackMapping(resultItem, commit, ct);
                if (isUpdated)
                    ResetMealPackMapping();
                return isUpdated;
            }
            return false;
        }


        private void ResetMealPackMapping()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionMealPackMapping, Zero, Zero, Zero);
            });
        }
        public async Task<List<TRN_MealPackProcessingDto>> GetTRNMealPackProcessing(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_MealPackProcessingDto>();
                if (!RedisDbWrapper.Get(sessionMealPackProcessing, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNMealPackProcessing(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionMealPackProcessing, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_MealPackProcessingDto> GetMealPackProcessingById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNMealPackProcessing(ct);
                return result.FirstOrDefault(s => s.MealPackProcessingId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNMealPackProcessing(TRN_MealPackProcessingDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNMealPackProcessing(customObject, commit, ct);
            if (result != 0)
                ResetMealPackProcessing();
            return result;
        }

        public async Task<bool> UpdateTRNMealPackProcessing(TRN_MealPackProcessingDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNMealPackProcessing(customObject, commit, ct);
            if (result)
                ResetMealPackProcessing();
            return result;
        }

        public async Task<bool> DeleteTRNMealPackProcessing(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetMealPackProcessingById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNMealPackProcessing(resultItem, commit, ct);
                if (isUpdated)
                    ResetMealPackProcessing();
                return isUpdated;
            }
            return false;
        }


        private void ResetMealPackProcessing()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionMealPackProcessing, Zero, Zero, Zero);
            });
        }
        public async Task<List<TRN_OrderDto>> GetTRNOrder(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_OrderDto>();
                if (!RedisDbWrapper.Get(sessionOrder, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNOrder(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionOrder, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_OrderDto> GetOrderById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNOrder(ct);
                return result.FirstOrDefault(s => s.OrderId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNOrder(TRN_OrderDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNOrder(customObject, commit, ct);
            if (result != 0)
                ResetOrder();
            return result;
        }

        public async Task<bool> UpdateTRNOrder(TRN_OrderDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNOrder(customObject, commit, ct);
            if (result)
                ResetOrder();
            return result;
        }

        public async Task<bool> DeleteTRNOrder(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetOrderById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNOrder(resultItem, commit, ct);
                if (isUpdated)
                    ResetOrder();
                return isUpdated;
            }
            return false;
        }


        private void ResetOrder()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionOrder, Zero, Zero, Zero);
            });
        }

        public async Task<List<TRN_OrderAppliedDiscountDto>> GetTRNOrderAppliedDiscount(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_OrderAppliedDiscountDto>();
                if (!RedisDbWrapper.Get(sessionOrderAppliedDiscount, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNOrderAppliedDiscount(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionOrderAppliedDiscount, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_OrderAppliedDiscountDto> GetOrderAppliedDiscountById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNOrderAppliedDiscount(ct);
                return result.FirstOrDefault(s => s.AppliedDiscountId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNOrderAppliedDiscount(TRN_OrderAppliedDiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNOrderAppliedDiscount(customObject, commit, ct);
            if (result != 0)
                ResetOrderAppliedDiscount();
            return result;
        }

        public async Task<bool> UpdateTRNOrderAppliedDiscount(TRN_OrderAppliedDiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNOrderAppliedDiscount(customObject, commit, ct);
            if (result)
                ResetOrderAppliedDiscount();
            return result;
        }

        public async Task<bool> DeleteTRNOrderAppliedDiscount(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetOrderAppliedDiscountById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNOrderAppliedDiscount(resultItem, commit, ct);
                if (isUpdated)
                    ResetOrderAppliedDiscount();
                return isUpdated;
            }
            return false;
        }


        private void ResetOrderAppliedDiscount()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionOrderAppliedDiscount, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_OrderDetailsDto>> GetTRNOrderDetails(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_OrderDetailsDto>();
                if (!RedisDbWrapper.Get(sessionOrderDetails, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNOrderDetails(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionOrderDetails, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_OrderDetailsDto> GetOrderDetailsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNOrderDetails(ct);
                return result.FirstOrDefault(s => s.OrderDetailId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNOrderDetails(TRN_OrderDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNOrderDetails(customObject, commit, ct);
            if (result != 0)
                ResetOrderDetails();
            return result;
        }

        public async Task<bool> UpdateTRNOrderDetails(TRN_OrderDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNOrderDetails(customObject, commit, ct);
            if (result)
                ResetOrderDetails();
            return result;
        }

        public async Task<bool> DeleteTRNOrderDetails(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetOrderDetailsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNOrderDetails(resultItem, commit, ct);
                if (isUpdated)
                    ResetOrderDetails();
                return isUpdated;
            }
            return false;
        }


        private void ResetOrderDetails()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionOrderDetails, Zero, Zero, Zero);
            });
        }


        public async Task<List<TRN_SpecialDiscountDto>> GetTRNSpecialDiscount(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_SpecialDiscountDto>();
                if (!RedisDbWrapper.Get(sessionSpecialDiscount, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNSpecialDiscount(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionSpecialDiscount, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_SpecialDiscountDto> GetSpecialDiscountById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNSpecialDiscount(ct);
                return result.FirstOrDefault(s => s.SpecialDiscountId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNSpecialDiscount(TRN_SpecialDiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNSpecialDiscount(customObject, commit, ct);
            if (result != 0)
                ResetSpecialDiscount();
            return result;
        }

        public async Task<bool> UpdateTRNSpecialDiscount(TRN_SpecialDiscountDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNSpecialDiscount(customObject, commit, ct);
            if (result)
                ResetSpecialDiscount();
            return result;
        }

        public async Task<bool> DeleteTRNSpecialDiscount(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetSpecialDiscountById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNSpecialDiscount(resultItem, commit, ct);
                if (isUpdated)
                    ResetSpecialDiscount();
                return isUpdated;
            }
            return false;
        }


        private void ResetSpecialDiscount()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionSpecialDiscount, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_UserAddressDetailsDto>> GetTRNUserAddressDetails(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_UserAddressDetailsDto>();
                if (!RedisDbWrapper.Get(sessionUserAddressDetails, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNUserAddressDetails(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionUserAddressDetails, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_UserAddressDetailsDto> GetUserAddressDetailsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNUserAddressDetails(ct);
                return result.FirstOrDefault(s => s.AddressDetailId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNUserAddressDetails(TRN_UserAddressDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNUserAddressDetails(customObject, commit, ct);
            if (result != 0)
                ResetUserAddressDetails();
            return result;
        }

        public async Task<bool> UpdateTRNUserAddressDetails(TRN_UserAddressDetailsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNUserAddressDetails(customObject, commit, ct);
            if (result)
                ResetUserAddressDetails();
            return result;
        }

        public async Task<bool> DeleteTRNUserAddressDetails(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetUserAddressDetailsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNUserAddressDetails(resultItem, commit, ct);
                if (isUpdated)
                    ResetUserAddressDetails();
                return isUpdated;
            }
            return false;
        }


        private void ResetUserAddressDetails()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionUserAddressDetails, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_GroupRightsDto>> GetTRNGroupRights(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_GroupRightsDto>();
                if (!RedisDbWrapper.Get(sessionGroupRights, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNGroupRights(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionGroupRights, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_GroupRightsDto> GetGroupRightsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNGroupRights(ct);
                return result.FirstOrDefault(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNGroupRights(TRN_GroupRightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNGroupRights(customObject, commit, ct);
            if (result != 0)
                ResetGroupRights();
            return result;
        }

        public async Task<bool> UpdateTRNGroupRights(TRN_GroupRightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNGroupRights(customObject, commit, ct);
            if (result)
                ResetGroupRights();
            return result;
        }

        public async Task<bool> DeleteTRNGroupRights(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetGroupRightsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNGroupRights(resultItem, commit, ct);
                if (isUpdated)
                    ResetGroupRights();
                return isUpdated;
            }
            return false;
        }


        private void ResetGroupRights()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionGroupRights, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_UserPasswordDto>> GetTRNUserPassword(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_UserPasswordDto>();
                if (!RedisDbWrapper.Get(sessionUserPassword, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNUserPassword(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionUserPassword, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_UserPasswordDto> GetUserPasswordById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNUserPassword(ct);
                return result.FirstOrDefault(s => s.UserId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNUserPassword(TRN_UserPasswordDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNUserPassword(customObject, commit, ct);
            if (result != 0)
                ResetUserPassword();
            return result;
        }

        public async Task<bool> UpdateTRNUserPassword(TRN_UserPasswordDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNUserPassword(customObject, commit, ct);
            if (result)
                ResetUserPassword();
            return result;
        }

        public async Task<bool> DeleteTRNUserPassword(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetUserPasswordById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNUserPassword(resultItem, commit, ct);
                if (isUpdated)
                    ResetUserPassword();
                return isUpdated;
            }
            return false;
        }


        private void ResetUserPassword()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionUserPassword, Zero, Zero, Zero);
            });
        }



        public async Task<List<TRN_UserRightsDto>> GetTRNUserRights(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_UserRightsDto>();
                if (!RedisDbWrapper.Get(sessionUserRights, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNUserRights(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionUserRights, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_UserRightsDto> GetUserRightsById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNUserRights(ct);
                return result.FirstOrDefault(s => s.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNUserRights(TRN_UserRightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNUserRights(customObject, commit, ct);
            if (result != 0)
                ResetUserRights();
            return result;
        }

        public async Task<bool> UpdateTRNUserRights(TRN_UserRightsDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNUserRights(customObject, commit, ct);
            if (result)
                ResetUserRights();
            return result;
        }

        public async Task<bool> DeleteTRNUserRights(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetUserRightsById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNUserRights(resultItem, commit, ct);
                if (isUpdated)
                    ResetUserRights();
                return isUpdated;
            }
            return false;
        }


        private void ResetUserRights()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionUserRights, Zero, Zero, Zero);
            });
        }


        public async Task<List<TRN_UserDetailDto>> GetTRNUserDetail(CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var fieldListTemp = new List<TRN_UserDetailDto>();
                if (!RedisDbWrapper.Get(sessionUserDetail, Zero, Zero, Zero, out fieldListTemp))
                {
                    fieldListTemp = await DotnetCoreSvr.GetTRNUserDetail(ct);
                    RedisDbWrapper.Add(fieldListTemp, sessionUserDetail, Zero, Zero, Zero);
                }
                return fieldListTemp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<TRN_UserDetailDto> GetUserDetailById(int id, CancellationToken ct = default(CancellationToken))
        {
            try
            {
                var result = await GetTRNUserDetail(ct);
                return result.FirstOrDefault(s => s.UserId == id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> InsertTRNUserDetail(TRN_UserDetailDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.InsertTRNUserDetail(customObject, commit, ct);
            if (result != 0)
                ResetUserDetail();
            return result;
        }

        public async Task<bool> UpdateTRNUserDetail(TRN_UserDetailDto customObject, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var result = await DotnetCoreSvr.UpdateTRNUserDetail(customObject, commit, ct);
            if (result)
                ResetUserDetail();
            return result;
        }

        public async Task<bool> DeleteTRNUserDetail(int id, bool commit, CancellationToken ct = default(CancellationToken))
        {
            var resultItem = await GetUserDetailById(id);
            if (resultItem != null)
            {
                resultItem.IsDeleted = true;
                var isUpdated = await UpdateTRNUserDetail(resultItem, commit, ct);
                if (isUpdated)
                    ResetUserDetail();
                return isUpdated;
            }
            return false;
        }


        private void ResetUserDetail()
        {
            Task.Run(() =>
            {
                EntityChangeObserverMaster.DataSetObserver(sessionUserDetail, Zero, Zero, Zero);
            });
        }
    }
}