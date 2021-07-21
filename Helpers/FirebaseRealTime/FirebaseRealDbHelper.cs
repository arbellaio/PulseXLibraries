using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Firebase.Database;
using Newtonsoft.Json;
using PulseXLibraries.Models.Firebase;

namespace PulseXLibraries.Helpers.FirebaseRealTime
{
    public class FirebaseRealDbHelper
    {
        private static FirebaseClient _firebaseClient;
        public static bool ConnectFirebase(string firebaseConnectionString)
        {
            try
            {
                if (_firebaseClient == null)
                    _firebaseClient = new FirebaseClient(firebaseConnectionString);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static async Task AddToFirebase<T>(FirebaseItem<T> firebaseItem, string resourceName, bool generateKey = true, TimeSpan? timeOut = null)
        {
            try
            {
                await _firebaseClient.Child(resourceName).PostAsync(JsonConvert.SerializeObject(firebaseItem),generateKey ,timeOut);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public static async Task<FirebaseItem<T>> GetItemById<T>(FirebaseItem<T> firebaseItem, string resourceName,  TimeSpan? timeOut = null)
        {
            try
            {
                var itemInDb =  (await _firebaseClient.Child(resourceName).OnceAsync<FirebaseItem<T>>(timeOut)).FirstOrDefault(x => x.Object.Id.Equals(firebaseItem.Id));
                return itemInDb?.Object;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
          
        }
        
        
        public static async Task UpdateItemById<T>(FirebaseItem<T> firebaseItem, string resourceName,  TimeSpan? timeOut = null)
        {
            var itemInDb =  (await _firebaseClient.Child(resourceName).OnceAsync<FirebaseItem<T>>()).FirstOrDefault(x => x.Object.Id.Equals(firebaseItem.Id));
            if (itemInDb != null)
            {
                await _firebaseClient.Child(resourceName + "/" + itemInDb.Key).PatchAsync(JsonConvert.SerializeObject(firebaseItem), timeOut);
            }
        }

        public static async Task DeleteItemById<T>(FirebaseItem<T> firebaseItem, string resourceName, TimeSpan? timeOut = null)
        {
            var itemInDb =  (await _firebaseClient.Child(resourceName).OnceAsync<FirebaseItem<T>>()).FirstOrDefault(x => x.Object.Id.Equals(firebaseItem.Id));
            if (itemInDb != null)
            {
                await _firebaseClient.Child(resourceName + "/" + itemInDb.Key).DeleteAsync(timeOut);
            }
        }

        public static async Task<List<FirebaseObject<FirebaseItem<T>>>> GetAllItems<T>(string resourceName, TimeSpan? timeOut = null)
        {
            var itemInDb = (await _firebaseClient.Child(resourceName).OnceAsync<FirebaseItem<T>>(timeOut)).ToList();
            return itemInDb;
        }
    }
}