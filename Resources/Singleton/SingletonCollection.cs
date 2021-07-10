using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace PulseXLibraries.Resources.Singleton
{
    public class SingletonCollection<T>
    {
        
        private static SingletonCollection<T> singletonCollection;
        public ObservableCollection<T> CollectionItems = new ObservableCollection<T>();

        public static SingletonCollection<T> GetBasketSingletonInstance()
        {
            if (singletonCollection == null)
            {
                singletonCollection = new SingletonCollection<T>();
            }
            return singletonCollection;
        }
            

        private SingletonCollection() {}

        public void AddItemsToBasket(T obj)
        {
            if (obj != null)
            {
                CollectionItems.Add(obj);
                MessagingCenter.Send<SingletonCollection<T>, string>(this, "CollectionCount", CollectionItems.Count.ToString());
            }
        }

        public  void RemoveItemsFromBasket(T obj)
        {
            if (obj != null)
            {
                CollectionItems.Remove(obj);
                MessagingCenter.Send<SingletonCollection<T>, string>(this, "CollectionCount", CollectionItems.Count.ToString()); 
            }
        }

      

        public void RemoveAll()
        {
            CollectionItems.Clear();
        }
        
    }
}