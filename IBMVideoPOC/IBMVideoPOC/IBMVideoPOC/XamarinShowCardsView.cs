using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace IBMVideoPOC
{
    public class XamarinShowCardsView : View
    {
        private const string ImageUrlPropertyName = "ImageUrl";

        public static readonly BindableProperty ImageUrlProperty =
        BindableProperty.Create(ImageUrlPropertyName,
                                typeof(string),
                                typeof(XamarinShowCardsView),
                                String.Empty);

        public string ImageUrl
        {
            get => (string)GetValue(ImageUrlProperty);
            set => SetValue(ImageUrlProperty, value);
        }
    }
}