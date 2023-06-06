using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using Group2_IT123P_MP.Menu;
using System;
using AndroidX.AppCompat.App;

namespace Group2_IT123P_MP.Book
{
    [Activity(Label = "Isekai Uncle")]
    public class book4_view : AppCompatActivity
    {
        private Button book4_checkout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.book4_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Isekai Uncle");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            book4_checkout = FindViewById<Button>(Resource.Id.book4_checkout);
            book4_checkout.Click += Books4_function_Click;
        }
        private void Books4_function_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(paymentactivity));

            // Pass the book image and title using intent extras
            intent.PutExtra("selectedImageId", Resource.Drawable.books4); // Replace with the actual resource ID of the book image
            intent.PutExtra("selectedBookName", "Isekai Uncle"); // Replace with the actual book title

            StartActivity(intent);
        }
    }
}