using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App_Module1.Views
{
    public partial class LayoutPage2 : ContentPage
    {
        public LayoutPage2()
        {
            InitializeComponent();

            nextButton.Clicked += nextPageclick;

        }

        private async void nextPageclick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollViewPage());
        }

        protected override async void OnAppearing()
        {
            redBox.Opacity = 0;
            blueBox.Opacity = 0;
            await Task.WhenAll(
                redBox.FadeTo(1, 2000, Easing.CubicIn),
                blueBox.FadeTo(1, 3000)
            );
           
        }
    }
}
