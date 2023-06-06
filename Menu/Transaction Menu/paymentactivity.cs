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
            payment_pay.Click += PaymentPayButton_Click;

            payment_radiogroup = FindViewById<RadioGroup>(Resource.Id.payment_radiogroup);
            payment_MobileNumber = FindViewById<EditText>(Resource.Id.payment_mobilenumber);

            int selectedImageId = Intent.GetIntExtra("selectedImageId", 0);
            string selectedBookName = Intent.GetStringExtra("selectedBookName");

            if (selectedImageId != 0)
            {
                ImageView paymentImageView = FindViewById<ImageView>(Resource.Id.payment_imageview);
                paymentImageView.SetImageResource(selectedImageId);
            }

            TextView paymentBookNameTextView = FindViewById<TextView>(Resource.Id.payment_bookname);
            paymentBookNameTextView.Text = selectedBookName;
        }

        private void PaymentPayButton_Click(object sender, EventArgs e)
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
                    // Show Payment Confirmation Dialog
                    ShowPaymentConfirmationDialog();
                }
            }
        }

        private void ShowPaymentConfirmationDialog()
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
            builder.SetTitle("Payment Confirmation");

            // Set a custom view for the dialog title
            LayoutInflater inflater = LayoutInflater.From(this);
            View titleView = inflater.Inflate(Resource.Layout.dialog_title_layout, null);
            builder.SetCustomTitle(titleView);

            builder.SetMessage("Are you sure you want to proceed with the payment?");
            builder.SetCancelable(true);
            builder.SetPositiveButton("Proceed", (sender, args) =>
            {
                // Retrieve book name and image ID
                string bookName = paymentBookName.Text;
                int selectedImageId = Intent.GetIntExtra("selectedImageId", 0);

                // Pass intent to ReceiptsActivity
                Intent intent = new Intent(this, typeof(receiptsactivity));
                intent.PutExtra("bookName", bookName);
                intent.PutExtra("selectedImageId", selectedImageId);
                StartActivity(intent);
            });
            builder.SetNegativeButton("Cancel", (sender, args) =>
            {
                // Handle cancel action, if needed
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
            dialog.Show();

            // Customize the dialog colors
            int messageId = Resources.GetIdentifier("message", "id", "android");
            TextView dialogMessage = dialog.FindViewById<TextView>(messageId);
            dialogMessage.SetTextColor(Color.ParseColor("#f2be8d"));

            // Set the dialog window background color
            Window window = dialog.Window;
            window.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#394359")));

            Button positiveButton = dialog.GetButton((int)DialogButtonType.Positive);
            positiveButton.SetTextColor(Color.ParseColor("#ba6d65"));

            Button negativeButton = dialog.GetButton((int)DialogButtonType.Negative);
            negativeButton.SetTextColor(Color.ParseColor("#ba6d65"));
        }
    }
}
