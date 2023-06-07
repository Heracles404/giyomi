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
using static Android.Provider.UserDictionary;
using System.IO;
using System.Net;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "Receipt")]
    public class receiptsactivity : AppCompatActivity
    {
        private Button buttonThankYou;
        private TextView ref_number;
        private TextView receipt_mop;
        private TextView receipt_phonenumber;
        private HttpWebRequest request;
        private HttpWebResponse response;
        private string res, username, bookName, referenceNumber, paymentmode, phoneNumber;

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
            bookName = Intent.GetStringExtra("bookName");
            int selectedImageId = Intent.GetIntExtra("selectedImageId", 0);
            paymentmode = Intent.GetStringExtra("selectedPaymentMethod");
            phoneNumber = Intent.GetStringExtra("phoneNumber");
            username = Intent.GetStringExtra("username");

            Toast.MakeText(this, bookName, ToastLength.Short).Show();


            // Update image and book title
            ImageView receiptImageView = FindViewById<ImageView>(Resource.Id.receipt_imageview);
            receiptImageView.SetImageResource(selectedImageId);

            TextView receiptBookNameTextView = FindViewById<TextView>(Resource.Id.receipt_bookname);
            receiptBookNameTextView.Text = bookName;

            // Generate reference number
            referenceNumber = String.Empty;
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                referenceNumber += random.Next(0, 10).ToString();
            }

            Toast.MakeText(this, "Please keep a copy of this receipt.", ToastLength.Short).Show();


            // Update reference number TextView
            TextView refNumberTextView = FindViewById<TextView>(Resource.Id.ref_number);
            refNumberTextView.Text = "Ref. Number: " + referenceNumber;

            // Update receipt_mop TextView
            TextView receiptMopTextView = FindViewById<TextView>(Resource.Id.receipt_mop);
            receiptMopTextView.Text = paymentmode;

            // Update receipt_phonenumber TextView
            TextView receiptPhoneNumberTextView = FindViewById<TextView>(Resource.Id.receipt_phonenumber);
            receiptPhoneNumberTextView.Text = phoneNumber;

            // Find and update the receipt_username TextView
            TextView receiptUsernameTextView = FindViewById<TextView>(Resource.Id.receipt_username);
            receiptUsernameTextView.Text = username;

            buttonThankYou = FindViewById<Button>(Resource.Id.buttonThankYou);
            buttonThankYou.Click += buttonThankYou_function_Click;

            insertTransactionRecord();
        }

        private void insertTransactionRecord()
        {
            request = (HttpWebRequest)WebRequest.Create("http://192.168.1.7/IT123P/REST/purchase.php?username=" + username.ToString() + "&bookName=" + bookName + "&referenceNumber=" + referenceNumber + "&paymentmode=" + paymentmode + "&phoneNumber=" + phoneNumber);
            response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            res = reader.ReadToEnd();
        }

        private void buttonThankYou_function_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Start_Activity));
        }

    }
}