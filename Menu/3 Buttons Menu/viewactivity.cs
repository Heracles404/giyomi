using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using Group2_IT123P_MP.Book;
using AndroidX.AppCompat.App;
using Android.Content;
using System;


namespace Group2_IT123P_MP
{
    [Activity(Label = "Menu")]
    public class viewactivity : AppCompatActivity
    {
        private ImageButton books1;
        private ImageButton books2;
        private ImageButton books3;
        private ImageButton books4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.view_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Menu");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));


            books1 = FindViewById<ImageButton>(Resource.Id.books1);
            books1.Click += Books1_Click;

            books2 = FindViewById<ImageButton>(Resource.Id.books2);
            books2.Click += Books2_Click;

            books3 = FindViewById<ImageButton>(Resource.Id.books3);
            books3.Click += Books3_Click;

            books4 = FindViewById<ImageButton>(Resource.Id.books4);
            books4.Click += Books4_Click;
        }
        private void Books1_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(book1_view));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        private void Books2_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(book2_view));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        private void Books3_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(book3_view));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        private void Books4_Click(object sender, EventArgs e)
        {
            string username = Intent.GetStringExtra("username");
            Intent intent = new Intent(this, typeof(book4_view));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
}