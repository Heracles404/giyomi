using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using Group2_IT123P_MP.Menu.User_Login_Register;
using System;
using System.IO;
using System.Linq;
using AndroidX.AppCompat.App;
using System.Net;

namespace Group2_IT123P_MP.Menu
{
    [Activity(Label = "Login")]
    public class Log_Activity : AppCompatActivity
    {
        private EditText login_username;
        private EditText login_password;
        private HttpWebRequest request;
        private HttpWebResponse response;
        private Button buttonLogIn;
        private TextView forgotPassword;
        private String res = "", str = "", uname = "", pword = "";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_layout);

            buttonLogIn = FindViewById<Button>(Resource.Id.buttonLogIn);
            buttonLogIn.Click += ButtonLogIn_Click;
            login_username = FindViewById<EditText>(Resource.Id.login_username);
            login_password = FindViewById<EditText>(Resource.Id.login_password);
            login_password.InputType = Android.Text.InputTypes.TextVariationPassword | Android.Text.InputTypes.ClassText;

            // Forgot Password Layout
            forgotPassword = FindViewById<TextView>(Resource.Id.textForgotPassword);
            forgotPassword.Click += forgotPassword_Click;

            SpannableString content = new SpannableString("Forgot Password?");
            // Apply relative text size (smaller)
            content.SetSpan(new RelativeSizeSpan(0.8f), 0, content.Length(), 0);
            // Apply underline
            content.SetSpan(new UnderlineSpan(), 0, content.Length(), 0);
            forgotPassword.TextFormatted = content;
            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Login");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ForgotPass_Activity));
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_username.Text))
            {
                Toast.MakeText(this, "Username cannot be blank.", ToastLength.Short).Show();
            }
            else if (string.IsNullOrEmpty(login_password.Text))
            {
                Toast.MakeText(this, "Password cannot be blank.", ToastLength.Short).Show();
            }
            else
            {
                pword = login_password.Text;
                uname = login_username.Text;
                request = (HttpWebRequest)WebRequest.Create("http://192.168.5.94/IT123P/REST/user_login.php?uname=" + uname + "&pword=" + pword);
                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                res = reader.ReadToEnd();
                Toast.MakeText(this, res, ToastLength.Long).Show();

                if (res.Contains("OK!"))
                {
                    Intent intent = new Intent(this, typeof(Start_Activity));
                    intent.PutExtra("username", login_username.Text);
                    StartActivity(intent);
                }
                else
                {
                    // Login failed
                    Toast.MakeText(this, "Invalid credentials.", ToastLength.Short).Show();
                }
            }
        }
    }
}