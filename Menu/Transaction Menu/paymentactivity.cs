using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using System;
using System.Linq;
using AndroidX.AppCompat.App;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "Payment")]
    public class paymentactivity : AppCompatActivity
    {
        private RadioGroup payment_radiogroup;
        private EditText payment_MobileNumber;
        private TextView paymentBookName;
        private Button payment_pay;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.payment_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Payment for Pre-Order");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            paymentBookName = FindViewById<TextView>(Resource.Id.payment_bookname);
            string bookName = Intent.GetStringExtra("bookName");
            paymentBookName.Text = bookName;

            payment_pay = FindViewById<Button>(Resource.Id.payment_pay);
            payment_pay.Click += payment_pay_function_Click;

            payment_radiogroup = FindViewById<RadioGroup>(Resource.Id.payment_radiogroup);
            payment_MobileNumber = FindViewById<EditText>(Resource.Id.payment_mobilenumber);
        }
        private void payment_pay_function_Click(object sender, EventArgs e)
        {
            int selectedRadioButtonId = payment_radiogroup.CheckedRadioButtonId;
            if (selectedRadioButtonId == -1)
            {
                Toast.MakeText(this, "Please choose at least one payment option.", ToastLength.Short).Show();
            }
            else
            {
                string mobileNumber = payment_MobileNumber.Text.Trim();

                if (mobileNumber.Length != 11 || !mobileNumber.All(char.IsDigit))
                {
                    Toast.MakeText(this, "Mobile Number is not valid. Please enter a valid 11-digit number.", ToastLength.Short).Show();
                }
                else
                {
                    // Proceed with the payment
                    StartActivity(typeof(receiptsactivity));
                }
            }
        }

    }
}