namespace MauiDemo
{
    public partial class MainPage : ContentPage
    {
        private int _value = 100;

        public MainPage()
        {
            InitializeComponent();
            lblCounter.Text = _value.ToString();
        }

        private void Num_Clicked(object sender, EventArgs e)
        {
            _value += Convert.ToInt32((sender as Button).Text);
            lblCounter.Text = _value.ToString();
        }

    }
}