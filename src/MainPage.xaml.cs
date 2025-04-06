using src.ViewModels;
using System.ComponentModel;
using src.Views;

namespace src
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        

        public MainPage(BookViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            OnBoardingBtn.Text = "Avançar";
        }

        private async void OnBoardingBtn_Clicked(object sender, EventArgs e)
        {
            var items = CarouselView.ItemsSource.Cast<object>().ToList();
            var currentIndex = items.IndexOf(CarouselView.CurrentItem);

            if (currentIndex == items.Count -1)
            {
                await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
            }
            else
                CarouselView.CurrentItem = items[currentIndex + 1];
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            var items = CarouselView.ItemsSource.Cast<object>().ToList();

            if (e.CurrentPosition == items.Count - 1)
            {
                //Third Screen

                OnBoardingBtn.Text = "Cadastre-se";

                OnBoardingBtn.BackgroundColor = Color.FromRgb(24, 106, 185);
                statusBar.StatusBarColor = Color.FromRgb(21, 106, 185);
                indicatorView.SelectedIndicatorColor = Color.FromRgb(21, 106, 185);
                BackgroundColor = Color.FromArgb("#C8E2FB");
            }
            else if(e.CurrentPosition == items.Count - 2)
            {
                //Secund Screen

                OnBoardingBtn.Text = "Veja mais";

                BackgroundColor = Color.FromArgb("#fbe1c8");
                OnBoardingBtn.BackgroundColor = Color.FromArgb("#fea500");
                statusBar.StatusBarColor = Color.FromArgb("#feb200");
                indicatorView.SelectedIndicatorColor = Color.FromArgb("#feb200");
            }
            else
            {
                //First Screen

                OnBoardingBtn.Text = "Avançar";

                OnBoardingBtn.BackgroundColor = Color.FromArgb("#007261");
                statusBar.StatusBarColor = Color.FromArgb("#007261");
                indicatorView.SelectedIndicatorColor = Color.FromArgb("#007261");
                BackgroundColor = Color.FromArgb("#03a58d");
            }
        }
    }
}
