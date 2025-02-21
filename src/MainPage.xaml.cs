using src.ViewModels;
using src.Pages;
using System.Threading.Tasks;

namespace src
{
    public partial class MainPage : ContentPage
    {
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
    }
}
