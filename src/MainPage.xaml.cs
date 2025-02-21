using src.ViewModels;
using src.Pages;
using System.Threading.Tasks;

namespace src
{
    public partial class MainPage : ContentPage
    {
        private string? lblTitleColor = string.Empty;

        public MainPage(BookViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            OnBoardingBtn.Text = "Veja mais";
        }

        private async void OnBoardingBtn_Clicked(object sender, EventArgs e)
        {
            if (CarouselView.CurrentItem == CarouselView.ItemsSource.Cast<object>().Last())
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                CarouselView.CurrentItem = CarouselView.ItemsSource.Cast<object>()
                    .SkipWhile(item => item != CarouselView.CurrentItem)
                    .Skip(1)
                    .First();
            }
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if (e.CurrentPosition == (int)CarouselView.ItemsSource.Cast<object>().Count() - 1 )
            {
                OnBoardingBtn.BackgroundColor = Color.FromRgb(24, 106, 185);
                BackgroundColor = Color.FromRgb(177, 201, 236);
                lblTitleColor = "#ffffff";
                OnBoardingBtn.Text = "Cadastre - se";
            }
            else
            {
                OnBoardingBtn.BackgroundColor = Color.FromRgb(252, 134, 99);
                BackgroundColor = Color.FromRgb(251, 225, 200);
                lblTitleColor = "#fc8663";
                OnBoardingBtn.Text = "Veja mais";
            }
        }
    }
}
