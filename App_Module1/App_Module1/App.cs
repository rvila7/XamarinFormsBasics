using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using App_Module1.Views;

using Xamarin.Forms;

namespace App_Module1
{
    public class App : Application
    {
        public App()
        {

            Button button = new Button
            {
                Text = "Next Page",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand

            };

            // The root page of your application
            var content = new ContentPage
            {
                Title = "App_Module1",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!",
                            VerticalOptions = LayoutOptions.CenterAndExpand

                        },
                        
                        button
                    }
                }
            };

            MainPage = new NavigationPage(content);

            //Initializes 'Clicked' event for button and points to the desired method
            button.Clicked +=  delegate 
           {
               //PASSING DATA
               //Pass through new page objects constructor
               content.Navigation.PushAsync(new LayoutPage1(DateTime.Now.ToString()));
           };

            //Tambien podria ser 
            //button.Clicked += OnButtonClicked;
        }

        

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        //private void OnButtonClicked(object sender, EventArgs e)
        //{
          
        //    // In the PCL Project this is the way to print lines or objects to the application output
        //    System.Diagnostics.Debug.WriteLine("Button Clicked Method");
            

        //}


    }
}
