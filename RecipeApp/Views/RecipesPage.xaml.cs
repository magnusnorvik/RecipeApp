using System;

using RecipeApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace RecipeApp.Views
{
    public sealed partial class RecipesPage : Page
    {
        public RecipesViewModel ViewModel { get; } = new RecipesViewModel();

        public RecipesPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
