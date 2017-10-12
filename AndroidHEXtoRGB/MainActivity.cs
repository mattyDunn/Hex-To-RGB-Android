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

            //Finds the Button, Text Views, View and Edit Text
            hexValueEditText = FindViewById<EditText>(Resource.Id.hexValueText);
            redTextView = FindViewById<TextView>(Resource.Id.redText);
            greenTextView = FindViewById<TextView>(Resource.Id.greenText);
            blueTextView = FindViewById<TextView>(Resource.Id.blueText);
            convertHexButton = FindViewById<Button>(Resource.Id.convertButton);
            colorView = FindViewById<View>(Resource.Id.colorView);

            //Call Function when clicked
            convertHexButton.Click += ConvertHexButton_Click;

        }


        void ConvertHexButton_Click(object sender, System.EventArgs e)
        {
            //Find HEX value
            string hexValue = hexValueEditText.Text;
            string redHexValue = hexValue.Substring(0, 2);
            string greenHexValue = hexValue.Substring(2, 2);
            string blueHexValue = hexValue.Substring(4, 2);

            //Converts HEX to RGB
            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

            redTextView.Text = redValue.ToString();
            blueTextView
        }
    }
}

