using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

namespace BWSetup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // do this because for some reason it's not getting focus automatically.
            this.playButton.Focus();

            List<Util.Resolution> videoModes = Util.GetScreenResolutions();
            videoModes.Sort((x, y) => x.Width.CompareTo(y.Width));
            videoModes.ForEach(mode => resolutionsComboBox.Items.Add(mode));

            Configuration.LoadFromRegistry();

            int index = resolutionsComboBox.FindString(String.Format("{0} x {1}", Configuration.ScreenWidth, Configuration.ScreenHeight));
            resolutionsComboBox.SelectedIndex = index;
            graphicsQualityComboBox.SelectedIndex = Configuration.DetailIndex;
            disableSoundCheckBox.Checked = Configuration.AudioDisabled;
            windowedModeCheckBox.Checked = Configuration.WindowedMode;
        }

        #region Button Handlers

        private void playButton_Click(object sender, EventArgs e)
        {
            Util.Resolution selectedResolution = (Util.Resolution)resolutionsComboBox.Items[resolutionsComboBox.SelectedIndex];

            Configuration.ScreenWidth = selectedResolution.Width;
            Configuration.ScreenHeight = selectedResolution.Height;
            Configuration.DetailIndex = graphicsQualityComboBox.SelectedIndex;
            Configuration.AudioDisabled = disableSoundCheckBox.Checked;
            Configuration.WindowedMode = windowedModeCheckBox.Checked;

            Configuration.SaveToRegistry();

            this.Close();

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
