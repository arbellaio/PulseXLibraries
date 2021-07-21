using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.GoogleClient;
using Plugin.GoogleClient.Shared;
using PulseXLibraries.Helpers.Alert;
using PulseXLibraries.Helpers.SafeArea;
using PulseXLibraries.Models.NetworkAuth;
using PulseXLibraries.Views.BaseApp;
using Xamarin.Forms;

namespace PulseXLibraries.Helpers.Social
{
    public class GoogleAuthHelper
    {
        readonly IGoogleClientManager _googleService = CrossGoogleClient.Current;
        
        public async Task LoginGoogleAsync()
        {
            try
            {
                if (!string.IsNullOrEmpty(_googleService.AccessToken))
                {
                    //Always require user authentication
                    _googleService.Logout();
                }

                EventHandler<GoogleClientResultEventArgs<GoogleUser>> userLoginDelegate = null;
                userLoginDelegate = async (object sender, GoogleClientResultEventArgs<GoogleUser> e) =>
                {
                    switch (e.Status)
                    {
                        case GoogleActionStatus.Completed:
                            var googleUserString = JsonConvert.SerializeObject(e.Data);
#if DEBUG
                            Debug.WriteLine($"Google Logged in successfully: {googleUserString}");
#endif
                            var socialLoginData = new NetworkAuthData
                            {
                                Id = e.Data.Id,
                                Picture = e.Data.Picture.AbsoluteUri,
                                Email = e.Data.Email,
                                Name = e.Data.Name,
                            };

                            var namesSplit = socialLoginData.Name.Split(' ');
                            socialLoginData.FirstName = namesSplit[0];
                            string middleName = "";
                            if (namesSplit.Length == 3)
                            {
                                middleName = namesSplit[1];
                                socialLoginData.LastName = namesSplit[2];
                            }
                            else if (namesSplit.Length == 2)
                            {
                                socialLoginData.LastName = namesSplit[1];
                            }
                            else
                            {
                                socialLoginData.LastName = "";
                            }

                            try
                            {
                                ISafeAreaHelper safeAreaService = DependencyService.Get<ISafeAreaHelper>();
                                BaseApp.SafeArea = safeAreaService.GetSafeArea();
                            }
                            catch (Exception ex)
                            {
                                BaseApp.SafeArea = new Thickness(0, 0, 0, 0.5);
                            }

                          
                            break;
                        case GoogleActionStatus.Canceled:
                            await AlertHelper.ShowAlert("Alert", "Cancelled");
                            break;
                        case GoogleActionStatus.Error:
                            await AlertHelper.ShowAlert("Alert", "Error");
                            break;
                        case GoogleActionStatus.Unauthorized:
                            await AlertHelper.ShowAlert("Alert", "UnAuthorized");
                            break;
                    }

                    _googleService.OnLogin -= userLoginDelegate;
                };

                _googleService.OnLogin += userLoginDelegate;

                await _googleService.LoginAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine(ex.Message);
            }
        }
    }
}