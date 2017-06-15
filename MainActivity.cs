using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Ads;

namespace AdMob
{
    [Activity(Label = "AdMob", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected AdView adView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            adView = FindViewById<AdView>(Resource.Id.adView);
            var adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);
        }

        protected override void OnResume()
        {
            base.OnResume();
            if (adView != null)
            {
                adView.Resume();
            }
        }
    }
}

