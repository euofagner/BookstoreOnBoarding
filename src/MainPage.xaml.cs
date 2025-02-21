using src.ViewModels;

namespace src
{
    public partial class MainPage : ContentPage
    {
        public MainPage(BookViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
