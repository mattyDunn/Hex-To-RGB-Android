using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace AndroidHEXtoRGB
{
    [Activity(Label = "AndroidHEXtoRGB", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        Button convertHexButton;
        TextView redTextView, greenTextView, blueTextView;
        EditText hexValueEditText;
        View colorView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            hexValueEditText = FindViewById<EditText>(Resource.Id.

        }
    }
}

