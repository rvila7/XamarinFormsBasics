#Xamarin.Forms Basics
**This Repository aims to cover most of Xamarin.Forms basic features and some tips that will help you avoid some common problems**


###Navigation 

1. Hierarchal Navigation

Pushing the Next Page
```
Navigation.PushAsync(**YOURPAGECLASS**);
```
    
Popping back to previous page 

```
Navigation.PopAsync(**YourPAGeClass**);
```

### Custom Renderers

######Basic Custom Renderer Layout (Ex. Creating a Custom Entry for the iOS platform) 
```
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(MyEntry), typeof(MyEntryRenderer))]
namespace CustomRenderer.iOS
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged (e);

            if (Control != null) {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB (204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}
```
This Custom Renderer renders an entry with a custom background color in iOS.

######Important Properties of a Custom renderer 

1. Control - references native control (this is what you customize)
2. Element - references Xamarin.Forms control 
  1. Here you can access almost any native library from every platform 
3. [assembly: ExportRenderer (typeof(MyEntry), typeof(MyEntryRenderer))] - this line is important for the assembly to pick up this renderer at runtime





