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
    [Activity(Label = "Bocchi the Rock!")]
    public class book3_view : AppCompatActivity
    {
        private Button book3_checkout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.book3_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Bocchi the Rock!");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            book3_checkout = FindViewById<Button>(Resource.Id.book3_checkout);
            book3_checkout.Click += Books3_function_Click;
        }
        private void Books3_function_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(paymentactivity));

            // Pass the book image and title using intent extras
            intent.PutExtra("selectedImageId", Resource.Drawable.books3); // Replace with the actual resource ID of the book image
            intent.PutExtra("selectedBookName", "Bocchi the Rock!"); // Replace with the actual book title

            StartActivity(intent);
        }
    }
}