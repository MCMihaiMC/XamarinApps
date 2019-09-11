using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpandablePanelTest.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpandableStack : Grid
    {
        private string[] controlName = new string[4];

        public ExpandableStack()
        {
            InitializeComponent();
            SetImage();
            //ControlName.CollectionChanged += ControlName_CollectionChanged;
        }

        private void SetImage()
        {
            if (detailsStack.IsVisible)
                image.Source = "down.png";
            else
                image.Source = "up.png";
        }

        public static readonly BindableProperty
            HeaderTitleLabelProperty = BindableProperty.Create(nameof(HeaderTitle), typeof(string),
                typeof(ExpandableStack), default(string), BindingMode.OneWay);
        public string HeaderTitle
        {
            get { return (string)GetValue(HeaderTitleLabelProperty); }
            set { SetValue(HeaderTitleLabelProperty, value); }
        }


        public static readonly BindableProperty
            ImageDisplayedProperty = BindableProperty.Create(nameof(ImageDisplayed), typeof(Image),
                typeof(ExpandableStack), default(Image), BindingMode.TwoWay);
        public Image ImageDisplayed
        {
            get { return (Image)GetValue(ImageDisplayedProperty); }
            set { SetValue(ImageDisplayedProperty, value); }
        }


        public static readonly BindableProperty
            StackCollapsedProperty = BindableProperty.Create(nameof(StackCollapsed), typeof(bool),
                typeof(ExpandableStack), default(bool), BindingMode.TwoWay);
        public bool StackCollapsed
        {
            get { return (bool)GetValue(StackCollapsedProperty); }
            set { SetValue(StackCollapsedProperty, value); }
        }

        public static readonly BindableProperty
            NumberOfControlsProperty = BindableProperty.Create(nameof(NumberOfControls), typeof(int),
                typeof(ExpandableStack), default(int), BindingMode.OneWay);
        public int NumberOfControls
        {
            get { return (int)GetValue(NumberOfControlsProperty); }
            set { SetValue(NumberOfControlsProperty, value); }
        }

        public static readonly BindableProperty
            ControlName0Property = BindableProperty.Create(nameof(ControlName0), typeof(string),
        typeof(ExpandableStack), default(string), BindingMode.OneWay);
        public string ControlName0
        {
            get { return (string)GetValue(ControlName0Property); }
            set { SetValue(ControlName0Property, value); }
        }

        public static readonly BindableProperty
            ControlName1Property = BindableProperty.Create(nameof(ControlName1), typeof(string),
                typeof(ExpandableStack), default(string), BindingMode.OneWay);
        public string ControlName1
        {
            get { return (string)GetValue(ControlName1Property); }
            set { SetValue(ControlName1Property, value); }
        }

        public static readonly BindableProperty
            ControlName2Property = BindableProperty.Create(nameof(ControlName2), typeof(string),
                typeof(ExpandableStack), default(string), BindingMode.OneWay);
        public string ControlName2
        {
            get { return (string)GetValue(ControlName2Property); }
            set { SetValue(ControlName2Property, value); }
        }

        public static readonly BindableProperty
            ControlName3Property = BindableProperty.Create(nameof(ControlName3), typeof(string),
                typeof(ExpandableStack), default(string), BindingMode.OneWay);
        public string ControlName3
        {
            get { return (string)GetValue(ControlName3Property); }
            set { SetValue(ControlName3Property, value); }
        }

        //public ObservableCollection<string> ControlName { get; } = 
        //    new ObservableCollection<string>();

        //public static readonly BindableProperty
        //    ControlNameProperty = BindableProperty.Create(nameof(ControlName), 
        //        typeof(ObservableCollection<string>),  
        //        typeof(ExpandableStack), default(ObservableCollection<string>), 
        //        BindingMode.OneWay);

        private void ControlName_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            BuildControls();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == HeaderTitleLabelProperty.PropertyName)
            {
                headerTitle.Text = HeaderTitle;
            }

            if (propertyName == ImageDisplayedProperty.PropertyName)
            {
                image = ImageDisplayed;
            }

            if (propertyName == StackCollapsedProperty.PropertyName)
            {
                detailsStack.IsVisible = StackCollapsed;
            }

            if (propertyName == ControlName0Property.PropertyName)
            {
                controlName[0] = ControlName0;
            }

            if (propertyName == ControlName1Property.PropertyName)
            {
                controlName[1] = ControlName1;
            }

            if (propertyName == ControlName2Property.PropertyName)
            {
                controlName[2] = ControlName2;
            }

            if (propertyName == ControlName3Property.PropertyName)
            {
                controlName[3] = ControlName3;
            }

            if (propertyName == NumberOfControlsProperty.PropertyName)
            {
                BuildControls();
            }
        }


        private void BuildControls()
        {
            for (int i = 0; i < NumberOfControls; i++)
            {
                var checkBoxWithLabelControl = new CheckboxWithLabel
                {
                    CheckBoxLabel = controlName[i],
                    IsChecked = false
                };
                detailsStack.Children.Add(checkBoxWithLabelControl);
            }
        }

        private void OnTapped(object sender, EventArgs e)
        {
            detailsStack.IsVisible = !detailsStack.IsVisible;
            SetImage();
        }
    }
}