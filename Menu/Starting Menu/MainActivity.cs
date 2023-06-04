using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using Group2_IT123P_MP.Menu;
using AndroidX.AppCompat.App;
using System;

namespace Group2_IT123P_MP
{
    [Activity(Label = "Giyomi", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button buttonRegister;
        private Button buttonLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Start_Menu);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Welcome to Giyomi!");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));


            buttonRegister = FindViewById<Button>(Resource.Id.buttonRegister);
            buttonRegister.Click += ButtonRegister_Click;

            buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
            buttonLogin.Click += ButtonLogin_Click;

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Reg_Activity));
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Log_Activity));
        }
    }
}
