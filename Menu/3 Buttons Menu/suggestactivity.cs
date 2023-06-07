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
using System.Net;
using System.IO;
using System.Threading;

namespace Group2_IT123P_MP
{
    [Activity(Label = "Suggestions and Feedback")]
    public class suggestactivity : AppCompatActivity
    {
        private Button buttonSuggestSubmit;
        private EditText editTextBookName;
        private RadioGroup radioGroupGenre;
        private EditText editTextSuggestLeading;
        private Timer timer;
        private const int RefreshInterval = 1000; // Update every 5 seconds (adjust as needed)

        private HttpWebRequest request;
        private HttpWebResponse response;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.suggest_layout);

            // Customize the ActionBar
            var actionBar = SupportActionBar;
            actionBar.SetBackgroundDrawable(new ColorDrawable(Color.ParseColor("#f2be8d")));

            SpannableString spannableString = new SpannableString("Suggestions and Feedback");
            spannableString.SetSpan(new ForegroundColorSpan(Color.ParseColor("#ba6d65")), 0, spannableString.Length(), SpanTypes.ExclusiveExclusive);
            actionBar.TitleFormatted = spannableString;

            // Background Color
            Window.DecorView.SetBackgroundColor(Color.ParseColor("#394359"));

            editTextSuggestLeading = FindViewById<EditText>(Resource.Id.editTextSuggestLeading);
            editTextBookName = FindViewById<EditText>(Resource.Id.editTextBookName);
            radioGroupGenre = FindViewById<RadioGroup>(Resource.Id.radioGroupGenre);
            buttonSuggestSubmit = FindViewById<Button>(Resource.Id.buttonSuggestSubmit);
            buttonSuggestSubmit.Click += ButtonSuggestSubmit_Click;

            // Disable the editTextSuggestLeading
            editTextSuggestLeading.Enabled = false;

            // Start the timer to update the EditText periodically
            timer = new Timer(RefreshGenres, null, RefreshInterval, RefreshInterval);
        }

        private void ButtonSuggestSubmit_Click(object sender, EventArgs e)
        {
            int selectedGenreId = radioGroupGenre.CheckedRadioButtonId;
            RadioButton selectedGenreRadioButton = FindViewById<RadioButton>(selectedGenreId);
            string genre = selectedGenreRadioButton?.Text;
            string bookName = editTextBookName.Text.Trim();

            bool isGenreSelected = !string.IsNullOrEmpty(genre);
            bool isBookNameEntered = !string.IsNullOrEmpty(bookName);

            if (!isGenreSelected && !isBookNameEntered)
            {
                Toast.MakeText(this, "Please select a genre and enter a book name.", ToastLength.Short).Show();
                return;
            }

            if (!isGenreSelected)
            {
                Toast.MakeText(this, "Please select a genre.", ToastLength.Short).Show();
                return;
            }

            if (!isBookNameEntered)
            {
                Toast.MakeText(this, "Please enter a book name.", ToastLength.Short).Show();
                return;
            }

            // Create the request URL with the genre and book name as parameters
            string requestUrl = $"http://192.168.68.105/IT123P/REST/suggestions.php?genre={Uri.EscapeDataString(genre)}&suggestBName={Uri.EscapeDataString(bookName)}";

            // Create a request
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);

            // Get the response
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var res = reader.ReadToEnd();

                    // Display a toast message based on the response
                    if (res == "Suggestion sent")
                    {
                        Toast.MakeText(this, "Suggestion sent successfully!", ToastLength.Short).Show();
                    }
                    else
                    {
                        Toast.MakeText(this, "Failed to send suggestion. Please try again.", ToastLength.Short).Show();
                    }
                }
            }
        }



        private void RefreshGenres(object state)
        {
            // Retrieve the genres from the database
            string genres = RetrieveGenresFromDatabase();

            // Update the EditText on the main UI thread
            RunOnUiThread(() =>
            {
                if (genres != null)
                {
                    editTextSuggestLeading.Text = genres;
                }
                else
                {
                    editTextSuggestLeading.Text = "No genres found";
                }
                editTextSuggestLeading.Enabled = false; // Disable the EditText
            });
        }


        private string RetrieveGenresFromDatabase()
        {
            // Create a request to retrieve the genres from the database
            var request = (HttpWebRequest)WebRequest.Create("http://192.168.68.105/IT123P/REST/retrieve_genres.php");

            // Get the response
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var genres = reader.ReadToEnd();
                    return genres;
                }
            }
        }


        private string GetSelectedGenre()
        {
            int selectedGenreId = radioGroupGenre.CheckedRadioButtonId;
            RadioButton selectedGenreRadioButton = FindViewById<RadioButton>(selectedGenreId);
            return selectedGenreRadioButton.Text;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Stop the timer when the activity is destroyed
            timer?.Dispose();
            timer = null;
        }
    }
}
