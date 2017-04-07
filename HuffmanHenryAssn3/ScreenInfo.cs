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
using Android.Graphics;

namespace HuffmanHenryAssn3
{
    [Activity(Label = "ScreenInfo")]
    public class ScreenInfo : Activity
    {
        TextView tvOrientation;
        TextView tvHeight;
        TextView tvWidth;
    
        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.Title = "Screen Information";
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ScreenInfo);
            tvOrientation = (TextView)FindViewById(Resource.Id.tvOrientation);
            tvHeight = (TextView)FindViewById(Resource.Id.tvHeight);
            tvWidth = (TextView)FindViewById(Resource.Id.tvWidth);

            Display displayCurrent = WindowManager.DefaultDisplay;
            Point p = new Point();
            displayCurrent.GetRealSize(p);
            tvWidth.Text = p.X.ToString();
            tvHeight.Text = p.Y.ToString();
            tvOrientation.Text = GetOrientation();
        }

        public string GetOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
            return isLandscape ? "Landscape" : "Portrait";
        }
    }
}