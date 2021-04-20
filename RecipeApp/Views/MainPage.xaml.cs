using System;

using RecipeApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace RecipeApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
