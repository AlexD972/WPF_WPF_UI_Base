namespace WFP_WPF_UI_Base.ViewModels.Pages
{
    public partial class ViewModel_Accueil_Page : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            Counter++;
        }
    }
}
