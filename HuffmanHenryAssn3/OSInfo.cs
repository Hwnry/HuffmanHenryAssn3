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

namespace HuffmanHenryAssn3
{
    [Activity(Label = "OSInfo")]
    public class OSInfo : Activity
    {
        TextView tvManufacturer;
        TextView tvModel;
        TextView tvProduct;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.Title = "OS Information";
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.OSInfo);

            tvManufacturer = (TextView)FindViewById(Resource.Id.tvManufacturer);
            tvModel = (TextView)FindViewById(Resource.Id.tvModel);
            tvProduct = (TextView)FindViewById(Resource.Id.tvProduct);

            tvManufacturer.Text = Android.OS.Build.Manufacturer;
            tvModel.Text = Android.OS.Build.Model;
            tvProduct.Text = Android.OS.Build.Product;
        }
    }
}