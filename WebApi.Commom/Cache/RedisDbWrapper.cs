using Common.Utils;
using DotnetCore.Business.Entities;
using DotnetCore.Business.Interfaces;
using DotnetCore.Web;
using DotnetCore.Web.Helpers;
using StackExchange.Redis;
using System;
using System.Linq;

namespace Neeyamo.Web.Helpers
{
    public static class RedisDbWrapper
    {
        private static IBusiness _dotnetcoreSvr;
        public static IBusiness DotnetCoreSvr
        {
            get
            {
                if (_dotnetcoreSvr == null)
                    return null;
                return _dotnetcoreSvr;
            }
            set { _dotnetcoreSvr = value; }
        }

        /// <summary>
        /// Insert value into the cache using
        /// appropriate name/value pairs
        /// </summary>
        /// <typeparam name="T">Type of cached item</typeparam>
        /// <param name="o">Item to be cached</param>
        /// <param name="key">Name of item</param>
        public static void Add<T>(T o, string key, int clientId, int countryId, int buId)
        {
            string consolidatedKey = clientId.ToString() + countryId.ToString() + buId.ToString() + key;
            Redishelper.SetItem(consolidatedKey, 
                DateTime.Now.AddMinutes(1440).TimeOfDay, 
                o);
        }


        /// <summary>
        /// Remove item from cache
        /// </summary>
        /// <param name="key">Name of cached item</param>
        public static void Clear(string key, ObserveDto observe)
        {
            observe.Changed = false;
            DotnetCoreSvr.UpdateObserve(observe,true);
            Redishelper.DeleteItem(key);
        }

        /// <summary>
        /// Check for item in cache
        /// </summary>
        /// <param name="key">Name of cached item</param>
        /// <returns></returns>
        public static bool Exists(string key)
        {
            return Redishelper.KeyExists(key);
        }

        /// <summary>
        /// Retrieve cached item
        /// </summary>
        /// <typeparam name="T">Type of cached item</typeparam>
        /// <param name="key">Name of cached item</param>
        /// <param name="value">Cached value. Default(T) if item doesn't exist.</param>
        /// <returns>Cached item as type</returns>
        public static bool Get<T>(string key, int clientId, int countryId, int buId, out T value)
        {
            try
            {
                var result = DotnetCoreSvr.GetObserve();
                var individualItem = result.FirstOrDefault(s => s.TableName ==key && s.Changed==true);
                if (individualItem!=null)
                {
                    Clear(key, individualItem);
                }

                if (!Exists(key))
                {
                    value = default(T);
                    return false;
                }
                value = Redishelper.GetItem<T>(key);        
            }
            catch (Exception ex)
            {
                value = default(T);
                return false;
            }
            return true;
        }
    }
}