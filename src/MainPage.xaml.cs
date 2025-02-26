using src.ViewModels;
using src.Pages;
using System.Threading.Tasks;
using src.Models;
using System.ComponentModel;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core.Platform;

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
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
                CarouselView.CurrentItem = items[currentIndex + 1];
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            var items = CarouselView.ItemsSource.Cast<object>().ToList();

            if (e.CurrentPosition == items.Count - 1)
            {
                //blue screen

                OnBoardingBtn.Text = "Cadastre-se";

                OnBoardingBtn.BackgroundColor = Color.FromRgb(24, 106, 185);

                statusBar.StatusBarColor = Color.FromRgb(21, 106, 185);

                indicatorView.SelectedIndicatorColor = Color.FromRgb(21, 106, 185);

                BackgroundColor = Color.FromArgb("#C8E2FB");
            }
            else if(e.CurrentPosition == items.Count - 2)
            {
                //orange screen

                OnBoardingBtn.Text = "Veja mais";

                BackgroundColor = Color.FromArgb("#fbe1c8");
                OnBoardingBtn.BackgroundColor = Color.FromArgb("#feb200");
                statusBar.StatusBarColor = Color.FromArgb("#feb200");
                indicatorView.SelectedIndicatorColor = Color.FromArgb("#feb200");

                //OnBoardingBtn.BackgroundColor = Color.FromRgb(24, 106, 185);

                //statusBar.StatusBarColor = Color.FromRgb(21, 106, 185);

                //indicatorView.SelectedIndicatorColor = Color.FromArgb("fc8663");

                //BackgroundColor = Color.FromRgb(177, 201, 236);
            }
            else
            {
                //green screen

                OnBoardingBtn.Text = "Avança";

                OnBoardingBtn.BackgroundColor = Color.FromArgb("#007261");

                statusBar.StatusBarColor = Color.FromArgb("#007261");

                indicatorView.SelectedIndicatorColor = Color.FromArgb("#007261");

                BackgroundColor = Color.FromArgb("#03a58d");
            }
        }
    }
}
