using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using AndroidX.AppCompat.App;
using System.Text;
using Android.Graphics.Drawables;
using Android.Text.Style;
using Android.Text;
using Android.Graphics;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Group2_IT123P_MP.Menu;
using static Group2_IT123P_MP.Menu.Log_Activity;

namespace Group2_IT123P_MP.Menu.Transaction_Menu
{
    [Activity(Label = "Payment History")]
    public class historyactivity : AppCompatActivity
    {
        private Spinner spinneritems;
        private ArrayAdapter<string> spinnerAdapter;

        string username = SingletonClass.GetInstance().Username;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.history_layout);
            Toast.MakeText(this, "Received uname: " + username, ToastLength.Short).Show();

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new Android.Graphics.Drawables.ColorDrawable(Android.Graphics.Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Payment History");
            spannableString.SetSpan(new Android.Text.Style.ForegroundColorSpan(Android.Graphics.Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Android.Graphics.Color.ParseColor("#394359"));

            spinneritems = FindViewById<Spinner>(Resource.Id.spinneritems);

            // Create a list to hold the items
            List<string> items = new List<string>();

            // Add the starting item
            items.Add("Select from your payment history");

            // Call the PHP file and populate the spinner
            RetrieveItems(items);

            // Create an ArrayAdapter with the items
            ArrayAdapter<string> spinnerAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, items);
            spinneritems.Adapter = spinnerAdapter;

            // Set the item selection listener
            spinneritems.ItemSelected += SpinnerItemSelected;

        }

        private void RetrieveItems(List<string> items)
        {
            try
            {
                // Create a request
                var request = (HttpWebRequest)WebRequest.Create("http://192.168.5.94/IT123P/REST/retrieve_items.php?username=" + username);

                // Get the response
                var response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var res = reader.ReadToEnd();

                // Parse the JSON response
                List<Dictionary<string, string>> itemDataList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(res);

                // Get the book names from the itemDataList
                List<string> bookNames = itemDataList.Select(itemData => itemData["bookName"]).ToList();

                // Add the retrieved items to the list
                items.AddRange(bookNames);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Failed to retrieve items", ToastLength.Short).Show();
            }
        }


        private void SpinnerItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            // Get the selected item position
            int selectedItemPosition = e.Position;

            // If the starting item is selected, clear the TextViews
            if (selectedItemPosition == 0)
            {
                ClearTextViews();
            }
            else
            {
                // Get the selected book name from the spinner
                string selectedBookName = spinneritems.SelectedItem.ToString();

                // Find the TextViews
                TextView refNumberTextView = FindViewById<TextView>(Resource.Id.refnumber);
                TextView paymentTextView = FindViewById<TextView>(Resource.Id.paymenttext);
                TextView priceTextView = FindViewById<TextView>(Resource.Id.pricetext);
                TextView mobileNumberTextView = FindViewById<TextView>(Resource.Id.mobilenumbertext);

                // Call the PHP file and retrieve the item data
                List<Dictionary<string, string>> itemDataList = RetrieveItemData();

                // Find the itemData for the selected book name
                Dictionary<string, string> selectedItemData = itemDataList.FirstOrDefault(itemData => itemData["bookName"] == selectedBookName);

                if (selectedItemData != null)
                {
                    // Set the text of the TextViews based on the selected itemData
                    refNumberTextView.Text = selectedItemData["refnum"];
                    paymentTextView.Text = selectedItemData["paymentmode"];
                    priceTextView.Text = selectedItemData["price"];
                    mobileNumberTextView.Text = selectedItemData["phoneNumber"];
                }
                else
                {
                    // Clear the TextViews if no item data is found
                    ClearTextViews();
                }
            }
        }


        private List<Dictionary<string, string>> RetrieveItemData()
        {
            try
            {
                // Create a request
                var request = (HttpWebRequest)WebRequest.Create("http://192.168.5.94/IT123P/REST/retrieve_items.php");

                // Get the response
                var response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var res = reader.ReadToEnd();

                // Parse the JSON response
                List<Dictionary<string, string>> itemDataList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(res);

                return itemDataList;
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Failed to retrieve item data", ToastLength.Short).Show();
                return new List<Dictionary<string, string>>();
            }
        }

        private void ClearTextViews()
        {
            TextView refNumberTextView = FindViewById<TextView>(Resource.Id.refnumber);
            TextView paymentTextView = FindViewById<TextView>(Resource.Id.paymenttext);
            TextView priceTextView = FindViewById<TextView>(Resource.Id.pricetext);
            TextView mobileNumberTextView = FindViewById<TextView>(Resource.Id.mobilenumbertext);

            refNumberTextView.Text = "";
            paymentTextView.Text = "";
            priceTextView.Text = "";
            mobileNumberTextView.Text = "";
        }
    }
}
