using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using WFP_WPF_UI_Base.Models;

namespace WFP_WPF_UI_Base
{

    public static class ConfigHelper
    {
        private static readonly string ConfigFilePath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WFP_WPF_UI_Base", "appconfig.json");

        public static void SaveAppConfig(Window window)
        {
            try
            {
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                
                var settings = new WindowSettings
                {
                    Top = window.Top,
                    Left = window.Left,
                    Width = window.Width,
                    Height = window.Height,
                    State = (window.WindowState == WindowState.Minimized) ? WindowState.Normal : window.WindowState
                };
                var appConfig = new AppConfig() { WindowSettings=settings};

                var dir = Path.GetDirectoryName(ConfigFilePath);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var json = JsonSerializer.Serialize(appConfig);
                File.WriteAllText(ConfigFilePath, json);
            }
            catch
            {
                // Handle/log error if needed
            }
        }

        public static void LoadAndApplyAppConfig(Window window)
        {
            try
            {
                if (!File.Exists(ConfigFilePath))
                    return;

                var json = File.ReadAllText(ConfigFilePath);
                var appCondig = JsonSerializer.Deserialize<AppConfig>(json);

                if (appCondig != null && appCondig.WindowSettings != null)
                {
                    window.Top = appCondig.WindowSettings.Top;
                    window.Left = appCondig.WindowSettings.Left;
                    window.Width = appCondig.WindowSettings.Width;
                    window.Height = appCondig.WindowSettings.Height;
                    window.WindowState = appCondig.WindowSettings.State;
                }
            }
            catch
            {
                // Handle/log error if needed
            }

        }
    }
}
