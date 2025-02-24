using src.ViewModels;
using src.Pages;
using System.Threading.Tasks;
using src.Models;
using System.ComponentModel;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Behaviors;

namespace src
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage(BookViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            OnBoardingBtn.Text = "Veja mais";
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
            {

                CarouselView.CurrentItem = items[currentIndex + 1];
            }
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if (e.CurrentPosition == (int)CarouselView.ItemsSource.Cast<object>().Count() - 1)
            {
                OnBoardingBtn.BackgroundColor = Color.FromRgb(24, 106, 185);
                OnBoardingBtn.Text = "Cadastre - se";
                
                
                BackgroundColor = Color.FromRgb(177, 201, 236);
            }
            else
            {
                OnBoardingBtn.BackgroundColor = Color.FromRgb(252, 134, 99);
                OnBoardingBtn.Text = "Veja mais";

                BackgroundColor = Color.FromRgb(251, 225, 200);
            }
        }
    }
}
