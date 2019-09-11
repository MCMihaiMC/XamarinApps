using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpandablePanelTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpandableLayoutPage : ContentPage
    {
        public bool IsExpanded { get; set; }

        public ExpandableLayoutPage()
        {
            InitializeComponent();

            //SetVisibility();
        }

        /*
        private void SetVisibility()
        {
            if (detailsStack.IsVisible)
                image.Source = "down.png";
            else
                image.Source = "up.png"; 
        }

        void OnTapped(object sender, EventArgs e)
        {
            if (detailsStack.IsVisible)
            {
                detailsStack.IsVisible = false;
                image.Source = "up.png";
            }
            else
            {
                detailsStack.IsVisible = true;
                image.Source = "down.png";
            }
        }
        */
    }
}