using System;
using System.IO;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Essentials;

namespace PulseXLibraries.Helpers.Media
{
    public  class MediaPickerHelper
    {
        private MediaFile _mediaFile;
        public async Task<MediaFile> MediaSelection()
        {
            try
            {
                await CrossMedia.Current.Initialize();
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    return null;
                }
                else
                {
                    var mediaOption = new PickMediaOptions()
                    {
                        PhotoSize = PhotoSize.Medium,
                        CompressionQuality = 60,
                        
                    };
                    _mediaFile = await CrossMedia.Current.PickPhotoAsync(mediaOption);
                    if (_mediaFile == null)
                        return null;
                    else
                        return _mediaFile;
                }
            }
            catch (Exception e)
            {
              
            }
            return null;
        }

       
        public async Task<MediaFile> CaptureMediaSelection()
        {
            try
            {
                await CrossMedia.Current.Initialize();
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    return null;
                }
                else
                {
                    _mediaFile = await CrossMedia.Current.TakePhotoAsync((new StoreCameraMediaOptions
                    {
                        SaveToAlbum = true,
                        Directory = "Pictures",
                        PhotoSize = PhotoSize.Medium,
                        CompressionQuality = 60
                    }));
                    if (_mediaFile == null)
                        return null;
                    else
                        return _mediaFile;
                }
            }
            catch (Exception e)
            {
            }
            return null;
        }
    }
}