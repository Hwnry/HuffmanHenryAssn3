using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace HuffmanHenryAssn3
{
    [Activity(Label = "HuffmanHenryAssn3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            this.Title = "Main Activity";
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button btnScreen = (Button)FindViewById(Resource.Id.btnScreen);
            btnScreen.Click += BtnScreen_Click;

            Button btnNetwork = (Button)FindViewById(Resource.Id.btnNetwork);
            btnNetwork.Click += BtnNetwork_Click;

            Button btnOS = (Button)FindViewById(Resource.Id.btnOS);
            btnOS.Click += BtnOS_Click;

            Button btnName = (Button)FindViewById(Resource.Id.btnName);
            btnName.Click += BtnName_Click;
        }

        private void BtnName_Click(object sender, System.EventArgs e)
        {
            Intent toName = new Intent(this, typeof(Name));
            StartActivity(toName);
        }

        private void BtnOS_Click(object sender, System.EventArgs e)
        {
            Intent toOSInfo = new Intent(this, typeof(OSInfo));
            StartActivity(toOSInfo);
        }

        private void BtnNetwork_Click(object sender, System.EventArgs e)
        {
            Intent toNetworkInfo = new Intent(this, typeof(NetworkInform));
            StartActivity(toNetworkInfo);
        }

        private void BtnScreen_Click(object sender, System.EventArgs e)
        {
            Intent toScreenInfo = new Intent(this, typeof(ScreenInfo));
            StartActivity(toScreenInfo);
        }
    }
}

