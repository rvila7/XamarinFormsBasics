using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App_Module1.Views
{
   
    public partial class LayoutPage1 : ContentPage
    {

        public bool spaced = true;

        public LayoutPage1(string currentTime)
        {
            InitializeComponent();

            timeLabel.Text = currentTime;

            changeButton.Clicked += changeButtonClicked;
            nextButton.Clicked += nextButtonClicked;


            //Deactivates Navigation Bar
            //this -> desired page
            //false -> boolean determines if it shows navigation bar or not 
            NavigationPage.SetHasNavigationBar(this, false);

            //Sets the top padding of the page only on IOS
            //The reason I do this is because the Iphone includes the status bar inside the page, so this translates the page down out of the status bar's way 

            Device.OnPlatform(iOS: () =>
            {
                Padding = new Thickness(0, 20, 0, 0);
            });
        }

        private void nextButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutPage2());
        }

        private void changeButtonClicked(object sender, EventArgs e)
        {
            if (spaced)
            {
                stackLayout.Spacing = 0;
            } else
            {
                stackLayout.Spacing = 10;
                spaced = false;
            }
            
        }
    }
}
