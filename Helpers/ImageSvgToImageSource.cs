//using Microsoft.UI.Xaml.Media.Imaging;
//using Microsoft.UI.Xaml.Media.Imaging;
//using Microsoft.UI.Xaml.Media.Imaging;

using ShimSkiaSharp;
using Svg.Skia;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2._1.Helpers
{
    public class ImageSvgToImageSource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var uriString = (string)value;
            Uri uri = new Uri(uriString);

            

            //var svgImageSource = new SvgImageSource(new Uri(uriString));
            //ImageSource ImageData = ImageSource.FromStream(() => new MemoryStream(item.ImageData));


            if (uri.AbsolutePath.ToLowerInvariant().EndsWith(".svg"))
            {
                ///svgDocument.Load(uriString);
                //(svgImage as SKImageSource).Image = svgImage;

                return null;//new MauiSvgImageSource;//SvgImageSource.FromAbi(uriString, 50, 30, default(Color));
            }
            else
            {
                return ImageSource.FromUri(uri);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
