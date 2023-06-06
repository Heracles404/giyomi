using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static Android.Provider.UserDictionary;

namespace Group2_IT123P_MP.Menu.User_Login_Register
{
    [Activity(Label = "Forgot Password")]
    public class ForgotPass_Activity : Activity
    {
        private EditText email;
        private Button btnOTP;

        private EditText otp_input, password, rePassword;
        private Button btnReset;

        string OTP, Temporary_Char;
        System.Random randomOTP;
        string giyomi = "Giyomi OTP";

        private HttpWebRequest request;
        private HttpWebResponse response;
        private string res;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.forgotPassword_layout);
            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            email = FindViewById<EditText>(Resource.Id.reset_email);
            btnOTP = FindViewById<Button>(Resource.Id.buttonOTP);
            btnOTP.Click += userCheck;


            otp_input = FindViewById<EditText>(Resource.Id.reset_OTP);
            password = FindViewById<EditText>(Resource.Id.reset_password);
            password.InputType = Android.Text.InputTypes.TextVariationPassword | Android.Text.InputTypes.ClassText;
            rePassword = FindViewById<EditText>(Resource.Id.reset_rePassword);
            rePassword.InputType = Android.Text.InputTypes.TextVariationPassword | Android.Text.InputTypes.ClassText;
            btnReset = FindViewById<Button>(Resource.Id.buttonReset);
            btnReset.Click += ChangePassword;

            otp_input.Enabled = false;
            password.Enabled = false;
            rePassword.Enabled = false;
            btnReset.Enabled = false;
        }


        private void userCheck (object sender, EventArgs e)
        {
            try
            {
                // Check user email existence
                // Create a request
                var request = (HttpWebRequest)WebRequest.Create("http://192.168.5.94/IT123P/REST/user_forgot.php?usermail=" + email.Text);

                // Get the response
                var response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var res = reader.ReadToEnd();

                if (res.Contains("1"))
                {
                    sendOTP();
                }
                else
                {
                    Toast.MakeText(this, "User not found.", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Something went wrong. Try again.", ToastLength.Short).Show();
            }
        }

        private void sendOTP()
        {

            // Generates Random OTP
            string[] OTPAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            OTP = String.Empty;
            Temporary_Char = String.Empty;
            randomOTP = new System.Random();

            for (int i = 0; i < 6; i++)
            {
                int p = randomOTP.Next(0, OTPAllowedCharacters.Length);

                Temporary_Char = OTPAllowedCharacters[randomOTP.Next(0, OTPAllowedCharacters.Length)];

                OTP += Temporary_Char;
            }

            try
            {
                // Compose OTP E-mail
                MailMessage mailOTP = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mailOTP.From = new MailAddress("GiyomiServer@gmail.com");
                mailOTP.To.Add(email.Text);
                mailOTP.Subject = giyomi.ToString();
                mailOTP.Body = "Hi! Your requested for your password to be changed. Your OTP is " + OTP.ToString() + ". Please keep it private for your security.";

                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("GiyomiServer@gmail.com", "tomfehlfsqpwobim");
                ServicePointManager.ServerCertificateValidationCallback = delegate (object senders, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };

                SmtpServer.Send(mailOTP);

                // To Avoid Multiple Sending of OTPs
                email.Enabled = false;
                btnOTP.Enabled = false;

                otp_input.Enabled = true;
                password.Enabled = true;
                rePassword.Enabled = true;
                btnReset.Enabled = true;

                // Checks if e-mail is valid
                if (!IsValidEmail(email.Text))
                {
                    throw new FormatException("Please enter a valid e-mail address.");
                }
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

        private void ChangePassword(object sender, EventArgs e)
        {
            if (password.Text != rePassword.Text)
            {
                Toast.MakeText(this, "Passwords do not match. Try again.", ToastLength.Short).Show();
            }
            else if (otp_input.Text != OTP)
            {
                Toast.MakeText(this, "Invalid OTP. Try again.", ToastLength.Short).Show();
            }
            else
            {
                try
                {
                    // Change the IPV4 address based on your "OWN" ip
                    string url = "http://192.168.5.94/IT123P/REST/update_password.php?usermail=" + email.Text + "&newpass=" + password.Text;
                    request = (HttpWebRequest)WebRequest.Create(url);
                    response = (HttpWebResponse)request.GetResponse();
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    res = reader.ReadToEnd();
                    reader.Close();
                    response.Close();

                    Toast.MakeText(this, res, ToastLength.Long).Show();


                    // Login successful
                    StartActivity(typeof(Start_Activity));

                    Toast.MakeText(this, "Password sucessfully changed.", ToastLength.Short).Show();
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, "Something went wrong. Try again.", ToastLength.Short).Show();
                }
            }
        }


    }
}