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
            this.lblDestinationFile = new System.Windows.Forms.Label();
            this.grpID3Tags = new System.Windows.Forms.GroupBox();
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
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.lblRecorderMode = new System.Windows.Forms.Label();
            this.lblDestinationFormat = new System.Windows.Forms.Label();
            this.cboDestinationFormat = new System.Windows.Forms.ComboBox();
            this.cboRecorderMode = new System.Windows.Forms.ComboBox();
            this.cboChannels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.cboBits = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.cboSamplerate = new System.Windows.Forms.ComboBox();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboBitrate = new System.Windows.Forms.ComboBox();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songArtworkOutput = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grpID3Tags.SuspendLayout();
            this.grpDestination.SuspendLayout();
            this.trayMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songArtworkOutput)).BeginInit();
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
            // lblDestinationFile
            // 
            this.lblDestinationFile.BackColor = System.Drawing.Color.White;
            this.lblDestinationFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestinationFile.Location = new System.Drawing.Point(16, 241);
            this.lblDestinationFile.Name = "lblDestinationFile";
            this.lblDestinationFile.Size = new System.Drawing.Size(382, 16);
            this.lblDestinationFile.TabIndex = 74;
            this.lblDestinationFile.Text = "C:\\";
            // 
            // grpID3Tags
            // 
            this.grpID3Tags.BackColor = System.Drawing.SystemColors.Control;
            this.grpID3Tags.Controls.Add(this.songArtworkOutput);
            this.grpID3Tags.Controls.Add(this.label3);
            this.grpID3Tags.Controls.Add(this.textBox2);
            this.grpID3Tags.Controls.Add(this.label2);
            this.grpID3Tags.Controls.Add(this.textBox1);
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
            this.grpID3Tags.Location = new System.Drawing.Point(462, 12);
            this.grpID3Tags.Name = "grpID3Tags";
            this.grpID3Tags.Size = new System.Drawing.Size(346, 309);
            this.grpID3Tags.TabIndex = 78;
            this.grpID3Tags.TabStop = false;
            this.grpID3Tags.Text = "Recognized Song";
            this.grpID3Tags.Enter += new System.EventHandler(this.grpID3Tags_Enter);
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
            this.songTitleOutput.Location = new System.Drawing.Point(23, 132);
            this.songTitleOutput.Name = "songTitleOutput";
            this.songTitleOutput.Size = new System.Drawing.Size(98, 20);
            this.songTitleOutput.TabIndex = 14;
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(228, 116);
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
            this.songAlbumOutput.Location = new System.Drawing.Point(231, 132);
            this.songAlbumOutput.Name = "songAlbumOutput";
            this.songAlbumOutput.Size = new System.Drawing.Size(98, 20);
            this.songAlbumOutput.TabIndex = 16;
            // 
            // songLinkOutput
            // 
            this.songLinkOutput.Location = new System.Drawing.Point(127, 186);
            this.songLinkOutput.Name = "songLinkOutput";
            this.songLinkOutput.Size = new System.Drawing.Size(202, 20);
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
            this.songTimestampOutput.Location = new System.Drawing.Point(25, 186);
            this.songTimestampOutput.Name = "songTimestampOutput";
            this.songTimestampOutput.Size = new System.Drawing.Size(96, 20);
            this.songTimestampOutput.TabIndex = 17;
            this.songTimestampOutput.TextChanged += new System.EventHandler(this.songTimestampOutput_TextChanged);
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(124, 116);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(30, 13);
            this.lblTagAlbum.TabIndex = 71;
            this.lblTagAlbum.Text = "Artist";
            // 
            // songArtistOutput
            // 
            this.songArtistOutput.Location = new System.Drawing.Point(127, 132);
            this.songArtistOutput.Name = "songArtistOutput";
            this.songArtistOutput.Size = new System.Drawing.Size(98, 20);
            this.songArtistOutput.TabIndex = 15;
            // 
            // grpDestination
            // 
            this.grpDestination.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestination.Controls.Add(this.lblRecorderMode);
            this.grpDestination.Controls.Add(this.lblDestinationFormat);
            this.grpDestination.Controls.Add(this.lblDestinationFile);
            this.grpDestination.Controls.Add(this.cboDestinationFormat);
            this.grpDestination.Controls.Add(this.cboRecorderMode);
            this.grpDestination.Controls.Add(this.cboChannels);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.lblBits);
            this.grpDestination.Controls.Add(this.cboBits);
            this.grpDestination.Controls.Add(this.lblSamplerate);
            this.grpDestination.Controls.Add(this.cboSamplerate);
            this.grpDestination.Controls.Add(this.lblBitrate);
            this.grpDestination.Controls.Add(this.lblAudioSource);
            this.grpDestination.Controls.Add(this.cboBitrate);
            this.grpDestination.Controls.Add(this.cboAudioSource);
            this.grpDestination.Location = new System.Drawing.Point(12, 12);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(410, 309);
            this.grpDestination.TabIndex = 79;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Audio Settings";
            // 
            // lblRecorderMode
            // 
            this.lblRecorderMode.AutoSize = true;
            this.lblRecorderMode.Location = new System.Drawing.Point(13, 28);
            this.lblRecorderMode.Name = "lblRecorderMode";
            this.lblRecorderMode.Size = new System.Drawing.Size(81, 13);
            this.lblRecorderMode.TabIndex = 43;
            this.lblRecorderMode.Text = "Recorder Mode";
            // 
            // lblDestinationFormat
            // 
            this.lblDestinationFormat.AutoSize = true;
            this.lblDestinationFormat.Location = new System.Drawing.Point(12, 135);
            this.lblDestinationFormat.Name = "lblDestinationFormat";
            this.lblDestinationFormat.Size = new System.Drawing.Size(95, 13);
            this.lblDestinationFormat.TabIndex = 41;
            this.lblDestinationFormat.Text = "Destination Format";
            // 
            // cboDestinationFormat
            // 
            this.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationFormat.FormattingEnabled = true;
            this.cboDestinationFormat.Location = new System.Drawing.Point(16, 151);
            this.cboDestinationFormat.Name = "cboDestinationFormat";
            this.cboDestinationFormat.Size = new System.Drawing.Size(188, 21);
            this.cboDestinationFormat.TabIndex = 40;
            this.cboDestinationFormat.SelectedIndexChanged += new System.EventHandler(this.cboDestinationFormat_SelectedIndexChanged);
            // 
            // cboRecorderMode
            // 
            this.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecorderMode.FormattingEnabled = true;
            this.cboRecorderMode.Location = new System.Drawing.Point(16, 44);
            this.cboRecorderMode.Name = "cboRecorderMode";
            this.cboRecorderMode.Size = new System.Drawing.Size(286, 21);
            this.cboRecorderMode.TabIndex = 42;
            this.cboRecorderMode.SelectedIndexChanged += new System.EventHandler(this.cboRecorderMode_SelectedIndexChanged);
            // 
            // cboChannels
            // 
            this.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChannels.FormattingEnabled = true;
            this.cboChannels.Location = new System.Drawing.Point(210, 204);
            this.cboChannels.Name = "cboChannels";
            this.cboChannels.Size = new System.Drawing.Size(91, 21);
            this.cboChannels.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Channels";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(304, 188);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 37;
            this.lblBits.Text = "Bit depth";
            // 
            // cboBits
            // 
            this.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBits.FormattingEnabled = true;
            this.cboBits.Location = new System.Drawing.Point(307, 204);
            this.cboBits.Name = "cboBits";
            this.cboBits.Size = new System.Drawing.Size(91, 21);
            this.cboBits.TabIndex = 36;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(110, 188);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 35;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // cboSamplerate
            // 
            this.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamplerate.FormattingEnabled = true;
            this.cboSamplerate.Location = new System.Drawing.Point(113, 204);
            this.cboSamplerate.Name = "cboSamplerate";
            this.cboSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboSamplerate.TabIndex = 34;
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(13, 188);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(37, 13);
            this.lblBitrate.TabIndex = 33;
            this.lblBitrate.Text = "Bitrate";
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Location = new System.Drawing.Point(13, 81);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(71, 13);
            this.lblAudioSource.TabIndex = 32;
            this.lblAudioSource.Text = "Audio Source";
            // 
            // cboBitrate
            // 
            this.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitrate.FormattingEnabled = true;
            this.cboBitrate.Location = new System.Drawing.Point(16, 204);
            this.cboBitrate.Name = "cboBitrate";
            this.cboBitrate.Size = new System.Drawing.Size(91, 21);
            this.cboBitrate.TabIndex = 31;
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(16, 97);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(286, 21);
            this.cboAudioSource.TabIndex = 30;
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
            // recognizeCurrentToolStripMenuItem
            // 
            this.recognizeCurrentToolStripMenuItem.Name = "recognizeCurrentToolStripMenuItem";
            this.recognizeCurrentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recognizeCurrentToolStripMenuItem.Text = "Recognize Current";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 80;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Label";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 82;
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
            // songArtworkOutput
            // 
            this.songArtworkOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.songArtworkOutput.Location = new System.Drawing.Point(25, 19);
            this.songArtworkOutput.Name = "songArtworkOutput";
            this.songArtworkOutput.Size = new System.Drawing.Size(304, 85);
            this.songArtworkOutput.TabIndex = 84;
            this.songArtworkOutput.TabStop = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MusicRecognizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 333);
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
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.trayMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songArtworkOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMeterIn;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Timer tmrMeterIn;
        private System.Windows.Forms.Label lblDestinationFile;
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
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Label lblRecorderMode;
        private System.Windows.Forms.ComboBox cboRecorderMode;
        private System.Windows.Forms.Label lblDestinationFormat;
        private System.Windows.Forms.ComboBox cboDestinationFormat;
        private System.Windows.Forms.ComboBox cboChannels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cboBits;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.ComboBox cboSamplerate;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboBitrate;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recognizeCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox songArtworkOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}