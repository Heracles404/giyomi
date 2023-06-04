using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Group2_IT123P_MP.Menu;
using System;
namespace Group2_IT123P_MP.Book

{
    [Activity(Label = "The Reborn Witch Foretells Destruction")]
    public class book1_view : AppCompatActivity
    {
        private Button book1_checkout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.book1_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("The Reborn Witch Foretells Destruction");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            book1_checkout = FindViewById<Button>(Resource.Id.book1_checkout);
            book1_checkout.Click += Books1_function_Click;


        }
        private void Books1_function_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(paymentactivity));
            intent.PutExtra("bookName", "The Reborn Witch Foretells Destruction");
            StartActivity(intent);
        }

    }
}