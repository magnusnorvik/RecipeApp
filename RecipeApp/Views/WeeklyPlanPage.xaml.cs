using System;

using RecipeApp.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RecipeApp.Views
{
    public sealed partial class WeeklyPlanPage : Page
    {
        public WeeklyPlanViewModel ViewModel { get; } = new WeeklyPlanViewModel();

        public WeeklyPlanPage()
        {
            InitializeComponent();
            Loaded += WeeklyPlanPage_Loaded;
        }

        private async void WeeklyPlanPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
