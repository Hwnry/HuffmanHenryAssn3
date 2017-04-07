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
using Android.Net;

namespace HuffmanHenryAssn3
{
    [Activity(Label = "NetworkInfo")]
    public class NetworkInform : Activity
    {
        RadioButton rbWifi;
        RadioButton rbMobile;
        RadioButton rbEthernet;
        RadioButton rbWiMax;
        CheckBox cbConnect;
        ConnectivityManager connectivityManager;
        NetworkInfo activeNetworkInfo;
        bool isOnline;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.Title = "Network Information";
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NetworkInform);

            rbWifi = (RadioButton)FindViewById(Resource.Id.rbWifi);
            rbMobile = (RadioButton)FindViewById(Resource.Id.rbMobile);
            rbEthernet = (RadioButton)FindViewById(Resource.Id.rbEthernet);
            rbWiMax = (RadioButton)FindViewById(Resource.Id.rbWiMax);

            cbConnect = (CheckBox)FindViewById(Resource.Id.cbConnect);

            connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            activeNetworkInfo = connectivityManager.ActiveNetworkInfo;

            if(activeNetworkInfo != null)
            {
                isOnline = activeNetworkInfo.IsConnected;
            }
            

            if (isOnline && cbConnect.Checked == false)
            {
                cbConnect.Toggle();

                if (activeNetworkInfo.Type == ConnectivityType.Wifi)
                {
                    rbWifi.Toggle();
                }

                else if (activeNetworkInfo.Type == ConnectivityType.Mobile)
                {
                    rbMobile.Toggle();
                }

                else if(activeNetworkInfo.Type == ConnectivityType.Ethernet)
                {
                    rbEthernet.Toggle();
                }

                else if(activeNetworkInfo.Type == ConnectivityType.Wimax)
                {
                    rbWiMax.Toggle();
                }
            }

        }

        protected override void OnStart()
        {
            base.OnStart();
        }

    }
}