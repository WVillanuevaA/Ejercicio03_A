using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
    [Preserve(AllMembers =  true)]
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public String Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null) 
                return null;
            var imageSource = ImageSource.FromResource(Source,
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}

