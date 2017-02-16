using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App_Module1.Views
{
    public partial class StylesPage : ContentPage
    {
        public StylesPage()
        {
            InitializeComponent();
            nextButton.Clicked += nextButtonClicked;
            changeStyleButton.Clicked += changeStyleClicked;
            addbuttonButton.Clicked += addButtonClicked;
            Resources["buttonStyle"] = Resources["buttonStyle1"];

        }

        private void addButtonClicked(object sender, EventArgs e)
        {
            var button = new Button
            {
                Text = "New Button",
                BorderColor = Color.Green,
                BorderRadius = 4
            };


            button.SetDynamicResource(VisualElement.StyleProperty, "buttonStyle");

            buttonLayout.Children.Add(button);
        }

        private void changeStyleClicked(object sender, EventArgs e)
        {
            if (Resources["buttonStyle"] == Resources["buttonStyle1"])
            {
                Resources["buttonStyle"] = Resources["buttonStyle2"];
            } else
            {
                Resources["buttonStyle"] = Resources["buttonStyle1"];
            }
        }

        private void nextButtonClicked(object sender, EventArgs e)
        {
            
        }
    }
}
