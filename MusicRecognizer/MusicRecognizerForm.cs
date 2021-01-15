#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

namespace MusicRecognizer
{
    using Newtonsoft.Json.Linq;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MusicRecognizerForm : Form
    {
        private CSAudioRecorder.AudioRecorder audioRecorder1;
        private string lastFile;
        private dynamic lastSong = null;

        public MusicRecognizerForm()
        {
            InitializeComponent();
            this.audioRecorder1 = new CSAudioRecorder.AudioRecorder();
            this.audioRecorder1.RecordProgress += new CSAudioRecorder.OnRecordProgressEventHandler(this.audioRecorder1_RecordProgress);
            this.audioRecorder1.RecordError += new CSAudioRecorder.OnRecordErrorEventHandler(this.audioRecorder1_RecordError);
            this.audioRecorder1.RecordDone += new System.EventHandler(this.audioRecorder1_RecordDone);
            this.audioRecorder1.RecordStart += new System.EventHandler(this.audioRecorder1_RecordStart);
        }

        private void frmAudioRecorder_Load(object sender, EventArgs e)
        {

            #region LoadAudioProperties

            //Formats:
            cboDestinationFormat.DataSource = audioRecorder1.GetFormats();
            cboDestinationFormat.Text = "MP3";

            //Bitrate
            cboBitrate.DataSource = audioRecorder1.GetBitrates();
            cboBitrate.Text = "192";

            //Samplerate
            cboSamplerate.DataSource = audioRecorder1.GetSamplerates();
            cboSamplerate.Text = "44100";

            //Bit depth
            cboBits.DataSource = audioRecorder1.GetBits();
            cboBits.Text = "16";

            //Channels
            cboChannels.DataSource  = audioRecorder1.GetChannels();
            cboChannels.Text = "2";

            //Recorder mode
            cboRecorderMode.DataSource = audioRecorder1.GetModes();
            cboRecorderMode.SelectedItem = audioRecorder1.GetEnumValue(audioRecorder1.Mode);

            #endregion

        }

        private void cboRecorderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSAudioRecorder.Mode mode = (CSAudioRecorder.Mode)Enum.Parse(typeof(CSAudioRecorder.Mode), cboRecorderMode.Text);
            cboAudioSource.DataSource = audioRecorder1.GetDevices(mode);
            int default_device_index = audioRecorder1.GetDeviceDefaultIndex(mode);
            if (default_device_index != -1)
                cboAudioSource.SelectedIndex = default_device_index;
            else
                cboAudioSource.SelectedIndex = 0;
        }

        private void audioRecorder1_RecordDone(object sender, EventArgs e)
        {
            if ((cboDestinationFormat.Text != "WAV") && (cboDestinationFormat.Text != "ACM") && (cboDestinationFormat.Text != "AAC"))
            {
                if (File.Exists(lblDestinationFile.Text))
                {
                    audioRecorder1.TagTitle = "";
                    audioRecorder1.TagAlbum = "";
                    audioRecorder1.TagTrack = 1;
                    audioRecorder1.TagComment = "";
                    audioRecorder1.TagYear = "";
                    audioRecorder1.TagCopyright = "";
                    audioRecorder1.SetID3Tags(lblDestinationFile.Text);
                }
            }
            EnableDisableControls(true);
            Console.WriteLine("Done.");
        }

        private void audioRecorder1_RecordError(object sender, CSAudioRecorder.MessageArgs e)
        {
            Console.WriteLine(e.Number);
            Console.WriteLine(e.String);
        }

        private void audioRecorder1_RecordStart(object sender, EventArgs e)
        {
            Console.WriteLine("Start recording...");
        }

        private void audioRecorder1_RecordProgress(object sender, CSAudioRecorder.ProgressArgs e)
        {
            lblSizeIn.Text = audioRecorder1.TotalSizeIn;
            lblTimeIn.Text = audioRecorder1.TotalTimeIn;
        }

        private void SetDestinationFileName()
        {
            string sDestinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\out." + cboDestinationFormat.Text.ToLower();
            if (cboDestinationFormat.Text == "ACM")
                sDestinationFile = sDestinationFile + ".wav";
            lblDestinationFile.Text = sDestinationFile;
            lblDestinationFile.Text = sDestinationFile;
        }

        private void cmdRecord_Click(object sender, EventArgs e)
        {
            if(audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Recording)
            {
                audioRecorder1.Stop();

                while (audioRecorder1.RecordingState != CSAudioRecorder.RecordingState.Ready)
                {
                    Application.DoEvents();

                    Thread.Sleep(100);
                }
            }
            SetDestinationFileName();
            audioRecorder1.FileName = lblDestinationFile.Text;

            this.lastFile = lblDestinationFile.Text;
            audioRecorder1.AudioSource = cboAudioSource.Text;
            audioRecorder1.DeviceIndex = cboAudioSource.SelectedIndex;
            audioRecorder1.Format = (CSAudioRecorder.Format)Enum.Parse(typeof(CSAudioRecorder.Format), cboDestinationFormat.Text);
            #region MoreOptionalProperties
            audioRecorder1.Bitrate = (CSAudioRecorder.Bitrate)Enum.Parse(typeof(CSAudioRecorder.Bitrate), cboBitrate.Text);
            audioRecorder1.Samplerate = (CSAudioRecorder.Samplerate)Enum.Parse(typeof(CSAudioRecorder.Samplerate), cboSamplerate.Text);
            audioRecorder1.Bits = (CSAudioRecorder.Bits)Enum.Parse(typeof(CSAudioRecorder.Bits), cboBits.Text);
            audioRecorder1.Channels = (CSAudioRecorder.Channels)Enum.Parse(typeof(CSAudioRecorder.Channels), cboChannels.Text);
            audioRecorder1.Mode = (CSAudioRecorder.Mode)Enum.Parse(typeof(CSAudioRecorder.Mode), cboRecorderMode.Text);
            audioRecorder1.Latency = 100;
            audioRecorder1.StartOnNoiseVal = 1.0f;
            audioRecorder1.StopOnSilenceVal = 1.0f;
            audioRecorder1.StopOnSilenceSeconds = 3;
            #endregion
            audioRecorder1.Start();
            tmrMeterIn.Interval = 40;
            tmrMeterIn.Enabled = true;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Ready)
                return;
            EnableDisableControls(false);
            tmrMeterIn.Enabled = false;
            audioRecorder1.Stop();
            recognizeButton.Enabled = true;
        }

        private void cmdUnPause_Click(object sender, EventArgs e)
        {
            audioRecorder1.UnPause();
        }

        private void cboDestinationFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationFileName();
            lblBits.Visible = false;
            cboBits.Visible = false;

            if (cboDestinationFormat.Text == "WAV")
            {
                lblBits.Visible = true;
                cboBits.Visible = true;
            }

        }

        private void cmdPlayWithDefaultPlayer_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            Process.Start(lblDestinationFile.Text);
        }

        void EnableDisableControls(bool state)
        {
            cmdRecord.Enabled = state;
        }

        private void frmAudioRecorder_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit

            //Safe exit
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Recording)
            {
                audioRecorder1.Stop();

                while (audioRecorder1.RecordingState != CSAudioRecorder.RecordingState.Ready)
                {
                    Application.DoEvents();

                    Thread.Sleep(100);
                }
            }

            #endregion
        }
        private void recognizeButton_Click(object sender, EventArgs e)
        {
            showBalloon("Music Recognizer", "Recording...");
            cmdRecord_Click(cmdRecord, EventArgs.Empty);
            WaitNSeconds(3);
            cmdStop_Click(cmdStop, EventArgs.Empty);
            WaitNSeconds(1);
            try
            {
                dynamic data = this.recognizeMusic(this.lastFile);
                if (data.status == "success")
                {
                    lastSong = data.result;
                    this.songTitleOutput.Text = data.result.title;
                    this.songAlbumOutput.Text = data.result.album;
                    this.songTimestampOutput.Text = data.result.timecode;
                    this.songLinkOutput.Text = data.result.song_link;
                    this.songArtistOutput.Text = data.result.artist;
                    string music = this.songTitleOutput.Text + " - " + this.songArtistOutput.Text;
                    showBalloon("Music Recognizer", music + "\nClick to open in browser. ");
                }
                else
                {
                    this.songTitleOutput.Text = "";
                    this.songAlbumOutput.Text = "";
                    this.songTimestampOutput.Text = "";
                    this.songLinkOutput.Text = "";
                    this.songArtistOutput.Text = "";
                    showBalloon("Music Recognizer", "Couldn't recognize song.");
                }
            } catch
            {
                showBalloon("Music Recognizer", "Couldn't recognize song.");
            }
            
        }
        public dynamic recognizeMusic(string filePath)
        {
            Console.WriteLine(filePath);
            string audd_api_key = Constants.audd_api_key;
            string audd_api_url = Constants.audd_api_url;
            string audd_api_return = Constants.audd_api_return;
            Console.WriteLine("ENV: ", audd_api_url);
            var client = new RestClient(audd_api_url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddFile("file", filePath);
            request.AddParameter("return", audd_api_return);
            request.AddParameter("api_token", audd_api_key);
            IRestResponse response = client.Execute(request);
            dynamic data = JObject.Parse(response.Content);
            return data;
        }
        private void MusicRecognizer_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void trayIcon_Click(object sender, EventArgs e)
        {
            recognizeButton_Click(recognizeButton, EventArgs.Empty);
        }

        private void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void showBalloon(string title, string body)
        {

            if (title != null)
            {
                trayIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                trayIcon.BalloonTipText = body;
            }

            trayIcon.ShowBalloonTip(500);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void trayIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.openLastInBrowser();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.openLastInBrowser();
        }

        private void openLastInBrowser()
        {
            try
            {
                if (lastSong != null)
                {
                    System.Diagnostics.Process.Start(lastSong.song_link.ToString());
                }
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
