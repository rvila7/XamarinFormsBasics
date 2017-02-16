using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;
using App_Module1;
using App_Module1.UWP;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(BlurredImage), typeof(BlurredImageRenderer))]
namespace App_Module1.UWP
{
    public class BlurredImageRenderer : ImageRenderer
    {

        //Here is the main customization done 
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
        }
    }
}
