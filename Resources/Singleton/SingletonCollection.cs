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
                MessagingCenter.Send<SingletonCollection<T>, string>(this, "BasketCount", CollectionItems.Count.ToString());
            }
        }

        public  void RemoveItemsFromBasket(T obj)
        {
            if (obj != null)
            {
                // var item = CollectionItems.FirstOrDefault(x => x == obj.ProductId && x.Quantity == obj.Quantity);
                // if (item != null)
                // {
                //     item.Quantity--;
                //     if (item.Quantity <= 0)
                //     {
                //         CollectionItems.Remove(item);
                //     }
                // }
                MessagingCenter.Send<SingletonCollection<T>, string>(this, "BasketCount", CollectionItems.Count.ToString()); 
            }
        }

        public void Remove(T obj)
        {
            // var product = CollectionItems.FirstOrDefault(x => x.ProductId == obj.ProductId && x.Quantity == obj.Quantity);
            // if (product != null)
            // {
            //     CollectionItems.Remove(product);
            // }
        }

        public void RemoveAll()
        {
            CollectionItems.Clear();
        }
        
    }
}