namespace MAUI_ColorMaker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;
            var green = sldGren.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }

        private void SetColor(Color color)
        {
            Container.BackgroundColor = color;
            btnRandom.BackgroundColor = color;
            lblHexCode.Text = color.ToHex();
        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {

        }
    }

}
