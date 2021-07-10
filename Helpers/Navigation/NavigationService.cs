using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PulseXLibraries.Helpers.Navigation
{
       public class NavigationService : INavigationService
    {
        public async Task<Page> PopAsync(bool animated = false)
        {
            return await Application.Current.MainPage.Navigation.PopAsync(animated);
        }

        public async Task<Page> PopModalAsync()
        {
            return await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public async Task PushAsync(Page page)
        {
            try
            {
                if (Application.Current.MainPage is MasterDetailPage masterDetail)
                {
                    await masterDetail.Detail.Navigation.PushAsync(page);
                }
                else
                {
                    await Application.Current.MainPage.Navigation.PushAsync(page);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public async Task PushModalAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
           
        }

        public void SetMainPage(Page page)
        {
            Application.Current.MainPage = page;
        }

        private Page MainPage
        {
            get { return Application.Current.MainPage; }
        }


        public void  Remove() {
            Application.Current.MainPage.Navigation.PopToRootAsync(false);
            //var stackCount = Application.Current.MainPage.Navigation.NavigationStack.Count;
            //while (stackCount > 1)
            //{
            //    Application.Current.MainPage.Navigation.RemovePage(Application.Current.MainPage.Navigation.NavigationStack[stackCount - 1]);
            //    stackCount = stackCount - 1;
            //}
        }
    }

    public interface INavigationService
    {
        Task<Page> PopAsync(bool animated = false);
        Task PushAsync(Page page);
        Task PushModalAsync(Page page);
        void SetMainPage(Page page);
        Task<Page> PopModalAsync();
        void Remove();
    }
}