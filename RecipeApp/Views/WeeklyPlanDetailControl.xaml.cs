using System;

using RecipeApp.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RecipeApp.Views
{
    public sealed partial class WeeklyPlanDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(WeeklyPlanDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public WeeklyPlanDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as WeeklyPlanDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
