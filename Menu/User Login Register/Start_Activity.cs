using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Content;
using System;


namespace Group2_IT123P_MP
{
    [Activity(Label = "Giyomi", Theme = "@style/AppTheme")]
    public class Start_Activity : AppCompatActivity
    {
        private Button ViewButton;
        private Button BuyButton;
        private Button SuggestButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main_Menu);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Menu");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));


            ViewButton = FindViewById<Button>(Resource.Id.ViewButton);
            ViewButton.Click += viewbutton_Click;

            BuyButton = FindViewById<Button>(Resource.Id.BuyButton);
            BuyButton.Click += buybutton_Click;

            SuggestButton = FindViewById<Button>(Resource.Id.SuggestButton);
            SuggestButton.Click += suggestbutton_Click;
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(viewactivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(buyactivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }

        private void suggestbutton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(suggestactivity));
        }
        public override void OnBackPressed()
        {
            FinishAffinity();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
