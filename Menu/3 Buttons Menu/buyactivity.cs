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
        }

        private void Buy_proceed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBookName))
            {
                Toast.MakeText(this, "Please select at least one book", ToastLength.Short).Show();
            }
            else
            {
                Intent intent = new Intent(this, typeof(paymentactivity));
                intent.PutExtra("bookName", selectedBookName);
                StartActivity(intent);
            }
        }

        private void RadioGroup_CheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            RadioButton radioButton = FindViewById<RadioButton>(e.CheckedId);
            selectedBookName = radioButton.Text.ToString();
        }
    }
}
