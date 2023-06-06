using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "Receipt")]
    public class receiptsactivity : AppCompatActivity
    {
        private Button buttonThankYou;
        private TextView ref_number;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.receipts_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Receipt for Pre-Ordered Book");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            // Retrieve intent extras
            string bookName = Intent.GetStringExtra("bookName");
            int selectedImageId = Intent.GetIntExtra("selectedImageId", 0);

            // Update image and book title
            ImageView receiptImageView = FindViewById<ImageView>(Resource.Id.receipt_imageview);
            receiptImageView.SetImageResource(selectedImageId);

            TextView receiptBookNameTextView = FindViewById<TextView>(Resource.Id.receipt_bookname);
            receiptBookNameTextView.Text = bookName;

            // Generate reference number
            string referenceNumber = String.Empty;
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                referenceNumber += random.Next(0, 10).ToString();
            }

            // Update reference number TextView
            TextView refNumberTextView = FindViewById<TextView>(Resource.Id.ref_number);
            refNumberTextView.Text = "Ref. Number: " + referenceNumber;

            buttonThankYou = FindViewById<Button>(Resource.Id.buttonThankYou);
            buttonThankYou.Click += buttonThankYou_function_Click;
        }
        private void buttonThankYou_function_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Start_Activity));
        }
    }
}