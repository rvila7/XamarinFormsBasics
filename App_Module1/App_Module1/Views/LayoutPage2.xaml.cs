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

        }

        protected override async void OnAppearing()
        {
            await redBox.FadeTo(1, 3000);
        }
    }
}
