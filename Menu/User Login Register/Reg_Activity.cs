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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using AndroidX.AppCompat.App;
using static Java.Util.Jar.Attributes;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Xamarin.Essentials;
using static Android.Provider.UserDictionary;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "Register")]
    public class Reg_Activity : AppCompatActivity
    {
        private EditText register_email;
        private EditText register_username;
        private EditText register_password;
        private EditText register_repassword;
        private Button buttonRegister;

        private HttpWebRequest request;
        private HttpWebResponse response;

        private string OTP, Temporary_Char, res;
        Random randomOTP;
        string giyomi = "Giyomi OTP";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.register_layout);

            buttonRegister = FindViewById<Button>(Resource.Id.buttonRegister);
            buttonRegister.Click += ButtonRegister_Click;

            register_email = FindViewById<EditText>(Resource.Id.register_email);
            register_username = FindViewById<EditText>(Resource.Id.register_username);
            register_password = FindViewById<EditText>(Resource.Id.register_password);
            register_password.InputType = Android.Text.InputTypes.TextVariationPassword | Android.Text.InputTypes.ClassText;
            register_repassword = FindViewById<EditText>(Resource.Id.register_repassword);
            register_repassword.InputType = Android.Text.InputTypes.TextVariationPassword | Android.Text.InputTypes.ClassText;

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Register");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(register_email.Text))
            {
                Toast.MakeText(this, "Email cannot be blank.", ToastLength.Short).Show();
            }
            else if (string.IsNullOrEmpty(register_username.Text))
            {
                Toast.MakeText(this, "Username cannot be blank.", ToastLength.Short).Show();
            }
            else if (string.IsNullOrEmpty(register_password.Text))
            {
                Toast.MakeText(this, "Password cannot be blank.", ToastLength.Short).Show();
            }
            else if (register_password.Text != register_repassword.Text)
            {
                Toast.MakeText(this, "Passwords do not match.", ToastLength.Short).Show();
            }
            else if (register_password.Text == register_username.Text | register_password.Text == register_email.Text)
            {
                Toast.MakeText(this, "Password should not be the same with username or email.", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    // Create a request
                    var request = (HttpWebRequest)WebRequest.Create("http://192.168.68.105/IT123P/REST/check_user.php?uname=" + register_username.Text + "&usermail=" + register_email.Text);

                    // Get the response
                    var response = (HttpWebResponse)request.GetResponse();
                    var reader = new StreamReader(response.GetResponseStream());
                    var res = reader.ReadToEnd();

                    if (res.Contains("0"))
                    {
                        sendOTP();
                    }
                    else
                    {
                        // User exists
                        Toast.MakeText(this, "E-mail or Username is already registered.", ToastLength.Short).Show();
                    }
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, "Something went wrong. Try again.", ToastLength.Short).Show();
                }

            }
        }

        public void sendOTP()
        {
            buttonRegister.Enabled = false;

            // Generates Random OTP
            string[] OTPAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string OTP = String.Empty;
            var randomOTP = new Random();

            for (int i = 0; i < 6; i++)
            {
                OTP += OTPAllowedCharacters[randomOTP.Next(0, OTPAllowedCharacters.Length)];
            }

            try
            {
                // Compose OTP E-mail
                var mailOTP = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com");

                mailOTP.From = new MailAddress("GiyomiServer@gmail.com");
                mailOTP.To.Add(register_email.Text);
                mailOTP.Subject = giyomi;
                mailOTP.Body = "Welcome to Giyomi! Your OTP is " + OTP + ". Please keep it private for your security.";

                smtpServer.Port = 587;
                smtpServer.Host = "smtp.gmail.com";
                smtpServer.EnableSsl = true;
                smtpServer.UseDefaultCredentials = false;
                smtpServer.Credentials = new System.Net.NetworkCredential("GiyomiServer@gmail.com", "tomfehlfsqpwobim");
                ServicePointManager.ServerCertificateValidationCallback = delegate (object senders, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };

                smtpServer.Send(mailOTP);

                // Goes to OTP_layout
                Intent OTP_layout = new Intent(this, typeof(OTP_Activity));
                OTP_layout.PutExtra("OTP", OTP);
                OTP_layout.PutExtra("email", register_email.Text);
                OTP_layout.PutExtra("username", register_username.Text);
                OTP_layout.PutExtra("password", register_password.Text);
                StartActivity(OTP_layout);
            }
            catch (FormatException ex)
            {
                Toast.MakeText(this, "Please enter a valid e-mail address.", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Something went wrong. Try again.", ToastLength.Short).Show();
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Check if the email matches the pattern
            return regex.IsMatch(email);
        }
    }
}

