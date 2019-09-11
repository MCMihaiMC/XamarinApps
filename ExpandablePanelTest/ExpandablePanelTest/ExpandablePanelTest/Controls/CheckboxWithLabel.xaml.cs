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
    public partial class CheckboxWithLabel : Grid
    {
        public CheckboxWithLabel()
        {
            InitializeComponent();
            checkBox.CheckedChanged += OnSelectionChanged;
        }

        public static readonly BindableProperty
            CheckBoxLabelProperty = BindableProperty.Create(nameof(CheckBoxLabel), typeof(string),
                typeof(CheckboxWithLabel), default(string), BindingMode.OneWay);
        public string CheckBoxLabel
        {
            get{ return (string)GetValue(CheckBoxLabelProperty);}
            set{ SetValue(CheckBoxLabelProperty, value);}
        }

        public static readonly BindableProperty
            CheckBoxCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool),
                typeof(CheckboxWithLabel), default(bool), BindingMode.TwoWay);

        public bool IsChecked
        {
            get { return (bool)GetValue(CheckBoxCheckedProperty); }
            set { SetValue(CheckBoxCheckedProperty, value); }
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == CheckBoxLabelProperty.PropertyName)
            {
                checkBoxLabel.Text = CheckBoxLabel;
            }

            if (propertyName == CheckBoxCheckedProperty.PropertyName)
            {
                checkBox.IsChecked = IsChecked;
            }
        }

        private void OnSelectionChanged(object sender, CheckedChangedEventArgs e)
        {
            IsChecked = e.Value;
        }
    }
}