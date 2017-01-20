namespace BWSetup
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.optionsTabPage = new System.Windows.Forms.TabPage();
            this.disableSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.windowedModeCheckBox = new System.Windows.Forms.CheckBox();
            this.graphicsQualityLabel = new System.Windows.Forms.Label();
            this.graphicsQualityComboBox = new System.Windows.Forms.ComboBox();
            this.resolutionsComboBox = new System.Windows.Forms.ComboBox();
            this.screenResLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionsTabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Location = new System.Drawing.Point(376, 354);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // playButton
            // 
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.playButton.Location = new System.Drawing.Point(278, 354);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(92, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Save and Quit";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.Controls.Add(this.disableSoundCheckBox);
            this.optionsTabPage.Controls.Add(this.windowedModeCheckBox);
            this.optionsTabPage.Controls.Add(this.graphicsQualityLabel);
            this.optionsTabPage.Controls.Add(this.graphicsQualityComboBox);
            this.optionsTabPage.Controls.Add(this.resolutionsComboBox);
            this.optionsTabPage.Controls.Add(this.screenResLabel);
            this.optionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Padding = new System.Windows.Forms.Padding(24, 24, 24, 32);
            this.optionsTabPage.Size = new System.Drawing.Size(431, 141);
            this.optionsTabPage.TabIndex = 0;
            this.optionsTabPage.Text = "Options";
            this.optionsTabPage.UseVisualStyleBackColor = true;
            // 
            // disableSoundCheckBox
            // 
            this.disableSoundCheckBox.AutoSize = true;
            this.disableSoundCheckBox.Location = new System.Drawing.Point(197, 110);
            this.disableSoundCheckBox.Name = "disableSoundCheckBox";
            this.disableSoundCheckBox.Size = new System.Drawing.Size(157, 17);
            this.disableSoundCheckBox.TabIndex = 7;
            this.disableSoundCheckBox.Text = "Disable all sound and music";
            this.disableSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // windowedModeCheckBox
            // 
            this.windowedModeCheckBox.AutoSize = true;
            this.windowedModeCheckBox.Location = new System.Drawing.Point(30, 110);
            this.windowedModeCheckBox.Name = "windowedModeCheckBox";
            this.windowedModeCheckBox.Size = new System.Drawing.Size(106, 17);
            this.windowedModeCheckBox.TabIndex = 6;
            this.windowedModeCheckBox.Text = "Windowed mode";
            this.windowedModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // graphicsQualityLabel
            // 
            this.graphicsQualityLabel.AutoSize = true;
            this.graphicsQualityLabel.Location = new System.Drawing.Point(27, 70);
            this.graphicsQualityLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.graphicsQualityLabel.Name = "graphicsQualityLabel";
            this.graphicsQualityLabel.Size = new System.Drawing.Size(84, 13);
            this.graphicsQualityLabel.TabIndex = 4;
            this.graphicsQualityLabel.Text = "Graphics Quality";
            // 
            // graphicsQualityComboBox
            // 
            this.graphicsQualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphicsQualityComboBox.FormattingEnabled = true;
            this.graphicsQualityComboBox.Items.AddRange(new object[] {
            "Lowest Detail",
            "Low Detail",
            "Medium Detail",
            "High Detail",
            "Maximum Detail"});
            this.graphicsQualityComboBox.Location = new System.Drawing.Point(144, 67);
            this.graphicsQualityComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 19);
            this.graphicsQualityComboBox.Name = "graphicsQualityComboBox";
            this.graphicsQualityComboBox.Size = new System.Drawing.Size(260, 21);
            this.graphicsQualityComboBox.TabIndex = 3;
            // 
            // resolutionsComboBox
            // 
            this.resolutionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionsComboBox.FormattingEnabled = true;
            this.resolutionsComboBox.Location = new System.Drawing.Point(144, 27);
            this.resolutionsComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 19);
            this.resolutionsComboBox.Name = "resolutionsComboBox";
            this.resolutionsComboBox.Size = new System.Drawing.Size(260, 21);
            this.resolutionsComboBox.TabIndex = 1;
            // 
            // screenResLabel
            // 
            this.screenResLabel.AutoSize = true;
            this.screenResLabel.Location = new System.Drawing.Point(27, 30);
            this.screenResLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.screenResLabel.Name = "screenResLabel";
            this.screenResLabel.Size = new System.Drawing.Size(94, 13);
            this.screenResLabel.TabIndex = 0;
            this.screenResLabel.Text = "Screen Resolution";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.optionsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 181);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(439, 167);
            this.tabControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AcceptButton = this.playButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(463, 386);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black & White Configuration";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionsTabPage.ResumeLayout(false);
            this.optionsTabPage.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TabPage optionsTabPage;
        private System.Windows.Forms.CheckBox windowedModeCheckBox;
        private System.Windows.Forms.Label graphicsQualityLabel;
        private System.Windows.Forms.ComboBox graphicsQualityComboBox;
        private System.Windows.Forms.ComboBox resolutionsComboBox;
        private System.Windows.Forms.Label screenResLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckBox disableSoundCheckBox;
    }
}

