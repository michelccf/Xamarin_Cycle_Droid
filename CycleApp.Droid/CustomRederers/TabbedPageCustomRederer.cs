using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CycleApp.Common;
using CycleApp.Droid.CustomRederers;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(CustomTabbedPage), typeof(TabbedPageCustomRederer))]
namespace CycleApp.Droid.CustomRederers
{
    public class TabbedPageCustomRederer : TabbedRenderer
    {

        //private Activity activity;
        //private TabbedPage _tabbedPage;
        //private const string COLOR = "#00796B";

        //protected override void OnDraw(Canvas canvas)
        //{
            
        //}

        //protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        //{
        //    base.OnElementChanged(e);
            

        //    this.SetBackgroundColor(Android.Graphics.Color.Honeydew);

            
        //}

    }
}