using WFP_WPF_UI_Base.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WFP_WPF_UI_Base.Views.Pages
{
    public partial class View_Accueil_Page : INavigableView<ViewModel_Accueil_Page>
    {
        public ViewModel_Accueil_Page ViewModel { get; }

        public View_Accueil_Page(ViewModel_Accueil_Page viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
