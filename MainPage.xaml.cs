using CommunityToolkit.Maui.Alerts;

namespace MAUI_ColorMaker
{
    public partial class MainPage : ContentPage
    {
        private bool IsRandom;
        private string hexCode;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!IsRandom)
            {
                var red = sldRed.Value;
                var green = sldGreen.Value;
                var blue = sldBlue.Value;

                Color color = Color.FromRgb(red, green, blue);
                SetColor(color);
            }
        }

        private void SetColor(Color color)
        {
            Container.BackgroundColor = color;
            btnRandom.BackgroundColor = color;
            hexCode = color.ToHex();
            lblHexCode.Text = hexCode;
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            IsRandom = true;
            Random random = new Random();
            Color color = new Color(
                random.Next(0,256),
                random.Next(0,256),
                random.Next(0,256));

            SetColor(color);

            sldRed.Value = color.Red;
            sldBlue.Value = color.Blue;
            sldGreen.Value = color.Green;

            IsRandom = false;
        }

        private async void CopyImageButton_Clicked(object sender, EventArgs e)
        {
            await Clipboard.SetTextAsync(hexCode);
            var toast = Toast.Make("Codice copiato", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
            await toast.Show();
        }
    }

}
