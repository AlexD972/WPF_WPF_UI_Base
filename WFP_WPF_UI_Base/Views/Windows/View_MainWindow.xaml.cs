using WFP_WPF_UI_Base.ViewModels.Windows;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace WFP_WPF_UI_Base.Views.Windows
{
    public partial class View_MainWindow : INavigationWindow
    {
        public ViewModel_View_MainWindow ViewModel { get; }

        public View_MainWindow(
            ViewModel_View_MainWindow viewModel,
            INavigationViewPageProvider navigationViewPageProvider,
            INavigationService navigationService
        )
        {
            ConfigHelper.LoadAndApplyAppConfig(this);

            ViewModel = viewModel;
            DataContext = this;

            SystemThemeWatcher.Watch(this);

            InitializeComponent();
            
            SetPageService(navigationViewPageProvider);

            navigationService.SetNavigationControl(RootNavigation);


            
        }

        #region INavigationWindow methods

        public INavigationView GetNavigation() => RootNavigation;

        public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

        public void SetPageService(INavigationViewPageProvider navigationViewPageProvider) => RootNavigation.SetPageProviderService(navigationViewPageProvider);

        public void ShowWindow() => Show();

        public void CloseWindow() => Close();

        #endregion INavigationWindow methods

        /// <summary>
        /// Raises the closed event.
        /// </summary>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
			System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show(
				"Voulez-vous vraiment quitter ?", "Avertissement : WPF-UI Base",
				System.Windows.MessageBoxButton.OKCancel);
			if (result == System.Windows.MessageBoxResult.Cancel)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0); //pour quitter proprement et ne pas garder le processus en arrière plan
			}
			base.OnClosing(e);
        }

        INavigationView INavigationWindow.GetNavigation()
        {
            throw new NotImplementedException();
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}
