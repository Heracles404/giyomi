using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Group2_IT123P_MP.Menu;
using Group2_IT123P_MP.Menu.Transaction_Menu;
using System;

namespace Group2_IT123P_MP
{
    [Activity(Label = "Giyomi", Theme = "@style/AppTheme")]
    public class Start_Activity : AppCompatActivity
    {
        private Button ViewButton;
        private Button BuyButton;
        private Button SuggestButton;
        private Button LogoutButton;
        private Button Paymenthistorybutton;

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
            ViewButton.Click += ViewButton_Click;

            BuyButton = FindViewById<Button>(Resource.Id.BuyButton);
            BuyButton.Click += BuyButton_Click;

            SuggestButton = FindViewById<Button>(Resource.Id.SuggestButton);
            SuggestButton.Click += SuggestButton_Click;

            LogoutButton = FindViewById<Button>(Resource.Id.LogoutButton);
            LogoutButton.Click += LogoutButton_Click;

            Paymenthistorybutton = FindViewById<Button>(Resource.Id.Paymenthistorybutton);
            Paymenthistorybutton.Click += Paymenthistorybutton_Click;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(viewactivity));
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(buyactivity));
        }

        private void SuggestButton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(suggestactivity));
        }

        private void Paymenthistorybutton_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(historyactivity));
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            SetUserLoggedIn(false); // Set the user login status to false
            StartActivity(typeof(Log_Activity)); // Go back to the login screen
            Finish(); // Finish the current activity to prevent the user from going back
        }

        private void SetUserLoggedIn(bool isLoggedIn)
        {
            // Set the login session status using SharedPreferences or any other method of your choice
            // For demonstration purposes, I'm using SharedPreferences
            ISharedPreferences sharedPreferences = GetSharedPreferences("MyAppPrefs", FileCreationMode.Private);
            ISharedPreferencesEditor editor = sharedPreferences.Edit();
            editor.PutBoolean("IsLoggedIn", isLoggedIn);
            editor.Apply();
        }
    }
}
