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

namespace Group2_IT123P_MP
{
    [Activity(Label = "Pre Order")]
    public class buyactivity : AppCompatActivity
    {
        private Button buy_proceed;
        private RadioGroup radioGroup;
        private string selectedBookName; // Variable to store the selected book name
        private ImageView imageView1, imageView2, imageView3, imageView4; // Declare ImageView variables

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.buy_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Select Book to Pre-Order");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            buy_proceed = FindViewById<Button>(Resource.Id.buy_proceed);
            buy_proceed.Click += Buy_proceed_Click;

            radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup);
            radioGroup.CheckedChange += RadioGroup_CheckedChange;

            // Initialize ImageView variables
            imageView1 = FindViewById<ImageView>(Resource.Id.imageView1);
            imageView2 = FindViewById<ImageView>(Resource.Id.imageView2);
            imageView3 = FindViewById<ImageView>(Resource.Id.imageView3);
            imageView4 = FindViewById<ImageView>(Resource.Id.imageView4);

            // Set onClickListener for each ImageView
            imageView1.Click += (sender, e) => RadioButton_Click(sender, e, Resource.Id.buy_book1);
            imageView2.Click += (sender, e) => RadioButton_Click(sender, e, Resource.Id.buy_book2);
            imageView3.Click += (sender, e) => RadioButton_Click(sender, e, Resource.Id.buy_book3);
            imageView4.Click += (sender, e) => RadioButton_Click(sender, e, Resource.Id.buy_book4);
        }

        private void Buy_proceed_Click(object sender, EventArgs e)
        {
            int selectedRadioButtonId = radioGroup.CheckedRadioButtonId;
            if (selectedRadioButtonId == -1)
            {
                Toast.MakeText(this, "Please choose a book.", ToastLength.Short).Show();
            }
            else
            {
                int selectedImageId = 0;
                string selectedBookName = "";

                if (selectedRadioButtonId == Resource.Id.buy_book1)
                {
                    selectedImageId = Resource.Drawable.books1;
                    selectedBookName = "The Reborn Witch Foretells Destruction";
                }
                else if (selectedRadioButtonId == Resource.Id.buy_book2)
                {
                    selectedImageId = Resource.Drawable.books2;
                    selectedBookName = "[Oshi no ko]";
                }
                else if (selectedRadioButtonId == Resource.Id.buy_book3)
                {
                    selectedImageId = Resource.Drawable.books3;
                    selectedBookName = "Bocchi the Rock!";
                }
                else if (selectedRadioButtonId == Resource.Id.buy_book4)
                {
                    selectedImageId = Resource.Drawable.books4;
                    selectedBookName = "Isekai Uncle";
                }

                Intent paymentIntent = new Intent(this, typeof(paymentactivity));
                paymentIntent.PutExtra("selectedImageId", selectedImageId);
                paymentIntent.PutExtra("selectedBookName", selectedBookName);

                // Pass the username intent to the next activity
                string username = Intent.GetStringExtra("username");
                paymentIntent.PutExtra("username", username);

                StartActivity(paymentIntent);
            }
        }


        private void RadioGroup_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            RadioButton radioButton = FindViewById<RadioButton>(e.CheckedId);
            selectedBookName = radioButton.Text.ToString();
        }

        private void RadioButton_Click(object sender, EventArgs e, int radioButtonId)
        {
            RadioButton radioButton = FindViewById<RadioButton>(radioButtonId);
            radioButton.Checked = true;
        }
    }
}
