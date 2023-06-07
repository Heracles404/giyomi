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
using System;
using static Android.Icu.Text.AlphabeticIndex;
using static Android.Provider.UserDictionary;
using System.IO;
using System.Net;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "OTP")]
    public class OTP_Activity : AppCompatActivity
    {
        private HttpWebRequest request;
        private HttpWebResponse response;

        private EditText OTPInput;
        private Button buttonOTP;
        private string OTPRef, usermail, uname, pword, res;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.otp_layout);

            buttonOTP = FindViewById<Button>(Resource.Id.buttonOTP);
            buttonOTP.Click += ButtonRegister_Click;
            OTPInput = FindViewById<EditText>(Resource.Id.OTP);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("OTP");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            Toast.MakeText(this, "Please check your e-mail.", ToastLength.Short).Show();

            OTPRef = Intent.GetStringExtra("OTP");
            usermail = Intent.GetStringExtra("email");
            uname = Intent.GetStringExtra("username");
            pword = Intent.GetStringExtra("password");

        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OTPInput.Text))
            {
                Toast.MakeText(this, "OTP is Required. Please check your e-mail, including the spam folder.", ToastLength.Short).Show();
            }
            else if (OTPRef != OTPInput.Text)
            {
                Toast.MakeText(this, "Invalid OTP. Try again.", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    // Change the IPV4 address based on your "OWN" ip
                    string url = "http://192.168.68.105/IT123P/REST/register_table.php?uname=" + Uri.EscapeDataString(uname) + "&pword=" + Uri.EscapeDataString(pword) + "&usermail=" + Uri.EscapeDataString(usermail);
                    request = (HttpWebRequest)WebRequest.Create(url);
                    response = (HttpWebResponse)request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    res = reader.ReadToEnd();
                    reader.Close();
                    response.Close();

                    Toast.MakeText(this, res, ToastLength.Long).Show();

                    // Login successful
                    StartActivity(typeof(Start_Activity));
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, "Something went wrong. Try again.", ToastLength.Short).Show();
                }
            }
        }
    }
}