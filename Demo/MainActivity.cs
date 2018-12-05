using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Demo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btnContinue;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnContinue = FindViewById<Button>(Resource.Id.button1);
            btnContinue.Click += ContinueBtnClicked;
        }


        void ContinueBtnClicked(object sender, EventArgs args)
        {
            var intent = new Intent(this, typeof(TestActivity));
            this.StartActivity(intent);
        }


    }
}