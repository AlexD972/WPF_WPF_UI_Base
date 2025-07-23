using WFP_WPF_UI_Base.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WFP_WPF_UI_Base.Views.Pages
{
    public partial class View_Settings_Page : INavigableView<ViewModel_Settings_Page>
    {
        public ViewModel_Settings_Page ViewModel { get; }

        public View_Settings_Page(ViewModel_Settings_Page viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
