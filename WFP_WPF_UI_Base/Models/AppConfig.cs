namespace WFP_WPF_UI_Base.Models
{
    public class AppConfig
    {
        public string ConfigurationsFolder { get; set; } = string.Empty;

        public string AppPropertiesFileName { get; set; } = string.Empty;



        public string LastDirectory { get; set; } = string.Empty;
        public WindowSettings WindowSettings { get; set; } = new WindowSettings();



    }
}

