using System.Collections.ObjectModel;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace WFP_WPF_UI_Base.ViewModels.Windows
{
    public partial class ViewModel_View_MainWindow : ObservableObject
    {
		private bool _isInitialized = false;

		[ObservableProperty]
		private string _applicationTitle = string.Empty;

		[ObservableProperty]
		private ObservableCollection<object> _navigationItems = [];

		[ObservableProperty]
		private ObservableCollection<object> _navigationFooter = [];

		public ViewModel_View_MainWindow(INavigationService navigationService)
		{
			if (!_isInitialized)
			{
				InitializeViewModel();
			}
		}


		private void InitializeViewModel()
		{
			ApplicationTitle = "WPF UI - Base";

			NavigationItems =
			[
				new NavigationViewItem()
			{
				Content = "Accueil",
				Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
				TargetPageType = typeof(Views.Pages.View_Accueil_Page),
			}
		];

			NavigationFooter =
			[
				new NavigationViewItem()
			{
				Content = "Paramètres",
				Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
				TargetPageType = typeof(Views.Pages.View_Settings_Page),
			},
		];


			_isInitialized = true;
		}
	}
}
