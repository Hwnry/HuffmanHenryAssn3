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
    [Activity(Label = "Name")]
    public class Name : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.Title = "Name"; 
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Name);
        }
    }
}