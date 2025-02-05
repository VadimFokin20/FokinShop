using FokinShop.ApplicationCore.Config;
using FokinShop.ApplicationCore.Interfaces;

namespace FokinShop.ApplicationCore.Services
{
    public class UriComposer : IUriComposer
    {
        private readonly ImageSourceConfig _imageSourceConfig;

        public UriComposer(ImageSourceConfig imageSourceConfig)
        {
            _imageSourceConfig = imageSourceConfig;
        }

        public string ComposeImageUri(string uri)
        {
            return uri.Replace("{imagesourceurl}", _imageSourceConfig.ImageSourceUrl);
        }
    }
}
