using Microsoft.Win32;
using System;

namespace BWSetup
{
    public static class Configuration
    {
        public static bool AudioDisabled;
        public static int ScreenWidth;
        public static int ScreenHeight;
        public static int DetailIndex;
        public static bool WindowedMode;

        private static string BWSetup = @"HKEY_CURRENT_USER\SOFTWARE\Lionhead Studios Ltd\Black & White\BWSetup";
        private static string AudioOveride = @"HKEY_CURRENT_USER\SOFTWARE\Lionhead Studios Ltd\Black & White\Audio\Override";


        static public void LoadFromRegistry()
        {
            ScreenWidth = (int)Registry.GetValue(BWSetup, "ScreenW", 800);
            ScreenHeight = (int)Registry.GetValue(BWSetup, "ScreenH", 600);
            WindowedMode = (bool)((int)Registry.GetValue(BWSetup, "FullScreen", 1) == 0);
            DetailIndex = (int)Registry.GetValue(BWSetup, "detailidx", 4);

            // Clamp between 0 and 4, old users might be using CUSTOM (5) EW
            DetailIndex = (DetailIndex < 0) ? 0 : (DetailIndex > 4) ? 4 : DetailIndex;

            // fucking special flower.
            AudioDisabled = (bool)((string)Registry.GetValue(AudioOveride, "NoAudio", "FALSE") == "TRUE");
        }

        static public void SaveToRegistry()
        {
            // Save our configurable stuff.
            Registry.SetValue(BWSetup, "ScreenW", ScreenWidth, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "ScreenH", ScreenHeight, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "detailidx", DetailIndex, RegistryValueKind.DWord);

            // stop stupid custom detail setting showing ingame c:
            // since y'know, IT DOESN'T WORK.
            Registry.SetValue(BWSetup, "maxdetailidx", 5, RegistryValueKind.DWord);

            // Audio Disabled
            Registry.SetValue(AudioOveride, "NoAudio", AudioDisabled ? "TRUE" : "FALSE", RegistryValueKind.String);

            // Windowed Mode
            Registry.SetValue(BWSetup, "FullScreen", WindowedMode ? 0 : 1, RegistryValueKind.DWord);

            // Best values for this stuff
            Registry.SetValue(BWSetup, "AudioMusicMasterVolume",  127, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "AudioSampleMasterVolume", 127, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CitadelGlows", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CitadelLightmaps", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CitadelPeople", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CitadelReflections", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CitadelVolumeLight", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "Clouds", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "CloudShadows", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "FixeLand", 4496864, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "Fog", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "HardwareTnL", 0, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "LandRef", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "Light", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "MaxObjectDistanceF", BitConverter.GetBytes(1.0d), RegistryValueKind.Binary);
            Registry.SetValue(BWSetup, "PingServer", "bwping.bwgame.com", RegistryValueKind.String);
            Registry.SetValue(BWSetup, "RainSplash", 8, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "Reflections", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "ScreenD", 32, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "ServerPort", 9280, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "ShadowsOnLandscape", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "ShadowsOnObjects", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "UseHighTexture", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "UseInternetWeatherSystem", 0, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "UseSmallBump", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "WaterTiling", BitConverter.GetBytes(1.0d), RegistryValueKind.Binary);
            Registry.SetValue(BWSetup, "Weather", 1, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "WeatherSystemServerName", "weather.bwgame.com", RegistryValueKind.String);
            Registry.SetValue(BWSetup, "WeatherSystemServerPort", 80, RegistryValueKind.DWord);
            Registry.SetValue(BWSetup, "WeatherSystemServerURL", "/query/", RegistryValueKind.String);
        }
    }
}
