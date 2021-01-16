namespace MusicRecognizer
{
    partial class MusicRecognizerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicRecognizerForm));
            this.lblMeterIn = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.tmrMeterIn = new System.Windows.Forms.Timer(this.components);
            this.grpID3Tags = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.songArtworkOutput = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songSpotifyUriOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.songLabelOutput = new System.Windows.Forms.TextBox();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.lblTagComment = new System.Windows.Forms.Label();
            this.songTitleOutput = new System.Windows.Forms.TextBox();
            this.lblTagTrackNum = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.songAlbumOutput = new System.Windows.Forms.TextBox();
            this.songLinkOutput = new System.Windows.Forms.TextBox();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.songTimestampOutput = new System.Windows.Forms.TextBox();
            this.lblTagAlbum = new System.Windows.Forms.Label();
            this.songArtistOutput = new System.Windows.Forms.TextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recognizeCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.sourceAppleMusicCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceSpotifyCheckbox = new System.Windows.Forms.CheckBox();
            this.startInTrayCheckbox = new System.Windows.Forms.CheckBox();
            this.startWithWindowsCheckbox = new System.Windows.Forms.CheckBox();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.grpID3Tags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songArtworkOutput)).BeginInit();
            this.trayMenuStrip.SuspendLayout();
            this.grpDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMeterIn
            // 
            this.lblMeterIn.Location = new System.Drawing.Point(0, 0);
            this.lblMeterIn.Name = "lblMeterIn";
            this.lblMeterIn.Size = new System.Drawing.Size(100, 23);
            this.lblMeterIn.TabIndex = 89;
            // 
            // lblMeter
            // 
            this.lblMeter.Location = new System.Drawing.Point(0, 0);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(100, 23);
            this.lblMeter.TabIndex = 88;
            // 
            // grpID3Tags
            // 
            this.grpID3Tags.BackColor = System.Drawing.SystemColors.Control;
            this.grpID3Tags.Controls.Add(this.label5);
            this.grpID3Tags.Controls.Add(this.songArtworkOutput);
            this.grpID3Tags.Controls.Add(this.label3);
            this.grpID3Tags.Controls.Add(this.songSpotifyUriOutput);
            this.grpID3Tags.Controls.Add(this.label2);
            this.grpID3Tags.Controls.Add(this.songLabelOutput);
            this.grpID3Tags.Controls.Add(this.recognizeButton);
            this.grpID3Tags.Controls.Add(this.lblTagComment);
            this.grpID3Tags.Controls.Add(this.songTitleOutput);
            this.grpID3Tags.Controls.Add(this.lblTagTrackNum);
            this.grpID3Tags.Controls.Add(this.lblTagTitle);
            this.grpID3Tags.Controls.Add(this.songAlbumOutput);
            this.grpID3Tags.Controls.Add(this.songLinkOutput);
            this.grpID3Tags.Controls.Add(this.lblTagYear);
            this.grpID3Tags.Controls.Add(this.songTimestampOutput);
            this.grpID3Tags.Controls.Add(this.lblTagAlbum);
            this.grpID3Tags.Controls.Add(this.songArtistOutput);
            this.grpID3Tags.Location = new System.Drawing.Point(12, 12);
            this.grpID3Tags.Name = "grpID3Tags";
            this.grpID3Tags.Size = new System.Drawing.Size(418, 309);
            this.grpID3Tags.TabIndex = 78;
            this.grpID3Tags.TabStop = false;
            this.grpID3Tags.Text = "Recognized Song";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(105, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Alternate: When minimized double click the icon in tray.";
            // 
            // songArtworkOutput
            // 
            this.songArtworkOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.songArtworkOutput.Location = new System.Drawing.Point(25, 19);
            this.songArtworkOutput.Name = "songArtworkOutput";
            this.songArtworkOutput.Size = new System.Drawing.Size(368, 85);
            this.songArtworkOutput.TabIndex = 84;
            this.songArtworkOutput.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Spotify URI";
            // 
            // songSpotifyUriOutput
            // 
            this.songSpotifyUriOutput.Enabled = false;
            this.songSpotifyUriOutput.Location = new System.Drawing.Point(127, 239);
            this.songSpotifyUriOutput.Name = "songSpotifyUriOutput";
            this.songSpotifyUriOutput.Size = new System.Drawing.Size(266, 20);
            this.songSpotifyUriOutput.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Label";
            // 
            // songLabelOutput
            // 
            this.songLabelOutput.Enabled = false;
            this.songLabelOutput.Location = new System.Drawing.Point(25, 239);
            this.songLabelOutput.Name = "songLabelOutput";
            this.songLabelOutput.Size = new System.Drawing.Size(96, 20);
            this.songLabelOutput.TabIndex = 80;
            // 
            // recognizeButton
            // 
            this.recognizeButton.Location = new System.Drawing.Point(25, 271);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(74, 23);
            this.recognizeButton.TabIndex = 79;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.recognizeButton_Click);
            // 
            // lblTagComment
            // 
            this.lblTagComment.AutoSize = true;
            this.lblTagComment.Location = new System.Drawing.Point(20, 170);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(58, 13);
            this.lblTagComment.TabIndex = 76;
            this.lblTagComment.Text = "Timestamp";
            // 
            // songTitleOutput
            // 
            this.songTitleOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.songTitleOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.songTitleOutput.Enabled = false;
            this.songTitleOutput.Location = new System.Drawing.Point(25, 132);
            this.songTitleOutput.Name = "songTitleOutput";
            this.songTitleOutput.Size = new System.Drawing.Size(171, 20);
            this.songTitleOutput.TabIndex = 14;
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(303, 116);
            this.lblTagTrackNum.Name = "lblTagTrackNum";
            this.lblTagTrackNum.Size = new System.Drawing.Size(36, 13);
            this.lblTagTrackNum.TabIndex = 75;
            this.lblTagTrackNum.Text = "Album";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(20, 116);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTagTitle.TabIndex = 66;
            this.lblTagTitle.Text = "Title";
            // 
            // songAlbumOutput
            // 
            this.songAlbumOutput.Enabled = false;
            this.songAlbumOutput.Location = new System.Drawing.Point(306, 132);
            this.songAlbumOutput.Name = "songAlbumOutput";
            this.songAlbumOutput.Size = new System.Drawing.Size(87, 20);
            this.songAlbumOutput.TabIndex = 16;
            // 
            // songLinkOutput
            // 
            this.songLinkOutput.Enabled = false;
            this.songLinkOutput.Location = new System.Drawing.Point(127, 186);
            this.songLinkOutput.Name = "songLinkOutput";
            this.songLinkOutput.Size = new System.Drawing.Size(266, 20);
            this.songLinkOutput.TabIndex = 18;
            // 
            // lblTagYear
            // 
            this.lblTagYear.AutoSize = true;
            this.lblTagYear.Location = new System.Drawing.Point(124, 170);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(55, 13);
            this.lblTagYear.TabIndex = 68;
            this.lblTagYear.Text = "Lis.tn Link";
            // 
            // songTimestampOutput
            // 
            this.songTimestampOutput.Enabled = false;
            this.songTimestampOutput.Location = new System.Drawing.Point(25, 186);
            this.songTimestampOutput.Name = "songTimestampOutput";
            this.songTimestampOutput.Size = new System.Drawing.Size(96, 20);
            this.songTimestampOutput.TabIndex = 17;
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(199, 116);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(30, 13);
            this.lblTagAlbum.TabIndex = 71;
            this.lblTagAlbum.Text = "Artist";
            // 
            // songArtistOutput
            // 
            this.songArtistOutput.Enabled = false;
            this.songArtistOutput.Location = new System.Drawing.Point(202, 132);
            this.songArtistOutput.Name = "songArtistOutput";
            this.songArtistOutput.Size = new System.Drawing.Size(98, 20);
            this.songArtistOutput.TabIndex = 15;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Music Recognizer";
            this.trayIcon.Visible = true;
            this.trayIcon.BalloonTipClicked += new System.EventHandler(this.trayIcon_BalloonTipClicked);
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_Click);
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.recognizeCurrentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(181, 126);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Open Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // recognizeCurrentToolStripMenuItem
            // 
            this.recognizeCurrentToolStripMenuItem.Name = "recognizeCurrentToolStripMenuItem";
            this.recognizeCurrentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recognizeCurrentToolStripMenuItem.Text = "Recognize Current";
            this.recognizeCurrentToolStripMenuItem.Click += new System.EventHandler(this.recognizeCurrentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Open last song";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Quit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // grpDestination
            // 
            this.grpDestination.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestination.Controls.Add(this.sourceAppleMusicCheckbox);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.sourceSpotifyCheckbox);
            this.grpDestination.Controls.Add(this.startInTrayCheckbox);
            this.grpDestination.Controls.Add(this.startWithWindowsCheckbox);
            this.grpDestination.Controls.Add(this.lblAudioSource);
            this.grpDestination.Controls.Add(this.cboAudioSource);
            this.grpDestination.Location = new System.Drawing.Point(436, 12);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(372, 309);
            this.grpDestination.TabIndex = 79;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Settings";
            // 
            // sourceAppleMusicCheckbox
            // 
            this.sourceAppleMusicCheckbox.AutoSize = true;
            this.sourceAppleMusicCheckbox.Location = new System.Drawing.Point(34, 180);
            this.sourceAppleMusicCheckbox.Name = "sourceAppleMusicCheckbox";
            this.sourceAppleMusicCheckbox.Size = new System.Drawing.Size(84, 17);
            this.sourceAppleMusicCheckbox.TabIndex = 37;
            this.sourceAppleMusicCheckbox.Text = "Apple Music";
            this.sourceAppleMusicCheckbox.UseVisualStyleBackColor = true;
            this.sourceAppleMusicCheckbox.CheckedChanged += new System.EventHandler(this.sourceAppleMusicCheckbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sources (Recommended only 1 at a time)";
            // 
            // sourceSpotifyCheckbox
            // 
            this.sourceSpotifyCheckbox.AutoSize = true;
            this.sourceSpotifyCheckbox.Location = new System.Drawing.Point(34, 157);
            this.sourceSpotifyCheckbox.Name = "sourceSpotifyCheckbox";
            this.sourceSpotifyCheckbox.Size = new System.Drawing.Size(58, 17);
            this.sourceSpotifyCheckbox.TabIndex = 35;
            this.sourceSpotifyCheckbox.Text = "Spotify";
            this.sourceSpotifyCheckbox.UseVisualStyleBackColor = true;
            this.sourceSpotifyCheckbox.CheckedChanged += new System.EventHandler(this.sourceSpotify_CheckedChanged);
            // 
            // startInTrayCheckbox
            // 
            this.startInTrayCheckbox.AutoSize = true;
            this.startInTrayCheckbox.Location = new System.Drawing.Point(23, 98);
            this.startInTrayCheckbox.Name = "startInTrayCheckbox";
            this.startInTrayCheckbox.Size = new System.Drawing.Size(79, 17);
            this.startInTrayCheckbox.TabIndex = 34;
            this.startInTrayCheckbox.Text = "Start in tray";
            this.startInTrayCheckbox.UseVisualStyleBackColor = true;
            this.startInTrayCheckbox.CheckedChanged += new System.EventHandler(this.startInTrayCheckbox_CheckedChanged);
            // 
            // startWithWindowsCheckbox
            // 
            this.startWithWindowsCheckbox.AutoSize = true;
            this.startWithWindowsCheckbox.Location = new System.Drawing.Point(23, 75);
            this.startWithWindowsCheckbox.Name = "startWithWindowsCheckbox";
            this.startWithWindowsCheckbox.Size = new System.Drawing.Size(117, 17);
            this.startWithWindowsCheckbox.TabIndex = 33;
            this.startWithWindowsCheckbox.Text = "Start with Windows";
            this.startWithWindowsCheckbox.UseVisualStyleBackColor = true;
            this.startWithWindowsCheckbox.CheckedChanged += new System.EventHandler(this.startWithWindowsCheckbox_CheckedChanged);
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Location = new System.Drawing.Point(20, 20);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(71, 13);
            this.lblAudioSource.TabIndex = 32;
            this.lblAudioSource.Text = "Audio Source";
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(23, 36);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(331, 21);
            this.cboAudioSource.TabIndex = 30;
            this.cboAudioSource.SelectedIndexChanged += new System.EventHandler(this.cboAudioSource_SelectedIndexChanged);
            // 
            // MusicRecognizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 332);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpID3Tags);
            this.Controls.Add(this.lblMeter);
            this.Controls.Add(this.lblMeterIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusicRecognizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Recognizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioRecorder_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioRecorder_Load);
            this.Resize += new System.EventHandler(this.MusicRecognizer_Resize);
            this.grpID3Tags.ResumeLayout(false);
            this.grpID3Tags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songArtworkOutput)).EndInit();
            this.trayMenuStrip.ResumeLayout(false);
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMeterIn;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Timer tmrMeterIn;
        private System.Windows.Forms.GroupBox grpID3Tags;
        private System.Windows.Forms.Label lblTagComment;
        private System.Windows.Forms.TextBox songTitleOutput;
        private System.Windows.Forms.Label lblTagTrackNum;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.TextBox songAlbumOutput;
        private System.Windows.Forms.TextBox songLinkOutput;
        private System.Windows.Forms.Label lblTagYear;
        private System.Windows.Forms.TextBox songTimestampOutput;
        private System.Windows.Forms.Label lblTagAlbum;
        private System.Windows.Forms.TextBox songArtistOutput;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recognizeCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox songLabelOutput;
        private System.Windows.Forms.PictureBox songArtworkOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox songSpotifyUriOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.CheckBox startWithWindowsCheckbox;
        private System.Windows.Forms.CheckBox startInTrayCheckbox;
        private System.Windows.Forms.CheckBox sourceAppleMusicCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sourceSpotifyCheckbox;
        private System.Windows.Forms.Label label5;
    }
}