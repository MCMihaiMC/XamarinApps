using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpandablePanelTest.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormEntry : Grid
    {
        public FormEntry()
        {
            InitializeComponent();
            entry.TextChanged += OnTextChanged;
        }

        public static readonly BindableProperty 
            TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), 
                typeof(FormEntry), default(string), Xamarin.Forms.BindingMode.OneWay);
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                title.Text = Title;
            }

            if (propertyName == TextProperty.PropertyName)
            {
                entry.Text = Text;
            }
        }

        public static readonly BindableProperty TextProperty = 
            BindableProperty.Create(nameof(Text), typeof(string), typeof(FormEntry), 
                default(string), BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }

            set
            {
                SetValue(TextProperty, value);
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }
    }
}