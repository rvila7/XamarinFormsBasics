using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App_Module1.Views
{
    public partial class ScrollViewPage : ContentPage
    {
        public ScrollViewPage()
        {
            InitializeComponent();

            addBoxButton.Clicked += addBoxClicked;
            fadeButton.Clicked += fadeButtonClicked;
            nextButton.Clicked += nextButtonClicked;
        }

        private async void nextButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StylesPage());
        }

        private void fadeButtonClicked(object sender, EventArgs e)
        {
            foreach (View ve in boxesLayout.Children)
            {
                ve.Style = (Style)Resources["boxStyle"];
            }

        }

        private void addBoxClicked(object sender, EventArgs e)
        {
            var box = new BoxView
            {
                Color = Color.Black,
                HeightRequest = 20
            };

            boxesLayout.Children.Add(box);
        }

        protected override void OnAppearing()
        {
            //var image = new Image
            //{
            //    Source = ImageSource.FromResource("App_Module1.images.DarkPolugon.jpg"),
            //    Aspect = Aspect.AspectFit
            //};
            BackgroundImage = "darkpolygon.jpg";
        }
    }
}
