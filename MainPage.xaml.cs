namespace MAUI_ColorMaker
{
    public partial class MainPage : ContentPage
    {
        private bool IsRandom;
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
            lblHexCode.Text = color.ToHex();
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
    }

}
