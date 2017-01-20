using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.Win32;

namespace BWSetup
{
    public class Util
    {
        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(
              string deviceName, int modeNum, ref VideoMode devMode);

        public struct Resolution
        {
            public int Width;
            public int Height;

            public Resolution(int w, int h)
            {
                Width = w;
                Height = h;
            }

            public override string ToString()
            {
                return String.Format("{0} x {1}", Width, Height);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VideoMode
        {
            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        public static List<Resolution> GetScreenResolutions()
        {
            var videoModes = new List<Resolution>();

            VideoMode videoMode = new VideoMode();
            int i = 0;

            while (EnumDisplaySettings(null, i, ref videoMode))
            {
                Resolution res = new Resolution(videoMode.dmPelsWidth, videoMode.dmPelsHeight);

                if(!videoModes.Contains(res))
                    videoModes.Add(res);

                i++;
            }

            return videoModes;
        }

        public static string GetBWPath()
        {
            string key = @"HKEY_CURRENT_USER\SOFTWARE\Lionhead Studios Ltd\Black & White";
            return (string)Registry.GetValue(key, "GameDir", null);
        }
    }
}
