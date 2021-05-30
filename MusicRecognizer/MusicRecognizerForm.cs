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
    using Microsoft.Win32;

    public partial class MusicRecognizerForm : Form
    {
        private CSAudioRecorder.AudioRecorder audioRecorder1;
        private Audd audd = null;
        private bool running = false;

        public MusicRecognizerForm()
        {
            InitializeComponent();
            
            this.audioRecorder1 = new CSAudioRecorder.AudioRecorder();
            cboAudioSource.DataSource = audioRecorder1.GetDevices(CSAudioRecorder.Mode.WasapiLoopbackCapture);
            CSAudioRecorder.Mode mode = CSAudioRecorder.Mode.WasapiLoopbackCapture;
            cboAudioSource.DataSource = audioRecorder1.GetDevices(mode);
            int default_device_index = audioRecorder1.GetDeviceDefaultIndex(mode);
            if (default_device_index != -1)
                cboAudioSource.SelectedIndex = default_device_index;
            else
                cboAudioSource.SelectedIndex = 0;

            this.sourceSpotifyCheckbox.Checked = (bool)Properties.Settings.Default["sourceSpotify"];
            this.sourceAppleMusicCheckbox.Checked = (bool)Properties.Settings.Default["sourceAppleMusic"];
            this.startWithWindowsCheckbox.Checked = (bool)Properties.Settings.Default["startWithWindows"];
            this.startInTrayCheckbox.Checked = (bool)Properties.Settings.Default["startInTray"];
            if ((int)Properties.Settings.Default["audioSource"] >= 0)
            {
                this.cboAudioSource.SelectedIndex = (int)Properties.Settings.Default["audioSource"];
            }
            SetStartup(startWithWindowsCheckbox.Checked);

            if(this.startInTrayCheckbox.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void frmAudioRecorder_Load(object sender, EventArgs e)
        {

            #region LoadAudioProperties

            #endregion

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
            if (!running)
            {
                this.recognizeMusic();
            }
        }
        public void recognizeMusic()
        {
            this.running = true;
            showBalloon("Music Recognizer", "Recording...");
            string return_type = "";
            if((bool)Properties.Settings.Default["sourceAppleMusic"])
            {
                return_type += "apple_music";
            } else if((bool)Properties.Settings.Default["sourceSpotify"])
            {
                return_type += ",spotify";
            }
            this.audd = new Audd(".\\", "out.", "WasapiLoopbackCapture", cboAudioSource.SelectedIndex, "MP3", "44100", return_type);
            this.audd.startRecording();
            WaitNSeconds(3);
            this.audd.stopRecording();
            WaitNSeconds(1);
            string result = this.audd.recognize();
            this.songTitleOutput.Enabled = false;
            this.songAlbumOutput.Enabled = false;
            this.songTimestampOutput.Enabled = false;
            this.songLinkOutput.Enabled = false;
            this.songArtistOutput.Enabled = false;
            this.songSpotifyUriOutput.Enabled = false;
            this.songTitleOutput.Text = "";
            this.songAlbumOutput.Text = "";
            this.songTimestampOutput.Text = "";
            this.songLinkOutput.Text = "";
            this.songArtistOutput.Text = "";
            this.songSpotifyUriOutput.Text = "";
            if (result == "success")
            {
                dynamic data = this.audd.latestSong;
                this.songTitleOutput.Enabled = true;
                this.songAlbumOutput.Enabled = true;
                this.songTimestampOutput.Enabled = true;
                this.songLinkOutput.Enabled = true;
                this.songArtistOutput.Enabled = true;
                this.songSpotifyUriOutput.Enabled = true;
                this.songTitleOutput.Text = data.result.title;
                this.songAlbumOutput.Text = data.result.album;
                this.songTimestampOutput.Text = data.result.timecode;
                this.songLinkOutput.Text = data.result.song_link;
                this.songArtistOutput.Text = data.result.artist;
                if (data.result.spotify != null)
                {
                    this.songSpotifyUriOutput.Text = data.result.spotify.uri ?? "";
                }
                string music = this.songTitleOutput.Text + " - " + this.songArtistOutput.Text;
                showBalloon("Music Recognizer", music + "\nClick to open in browser.");
            } else if (result == "failed") {
                showBalloon("Music Recognizer", "Couldn't recognize song.");
            } else {

                showBalloon("Music Recognizer", "Something went wrong, please check your audio settings.");
            }
            running = false;
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
                if(this.audd != null)
                {
                    if (this.audd.latestSong != null)
                    {
                        System.Diagnostics.Process.Start(this.audd.latestSong.result.song_link.ToString());
                    }
                } else
                {
                    showBalloon("Music Recognizer", "You havent recognized a song yet this session.");
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


        public void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(1);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void cboAudioSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["audioSource"] = cboAudioSource.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void startWithWindowsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["startWithWindows"] = startWithWindowsCheckbox.Checked;
            Properties.Settings.Default.Save();
            SetStartup(startWithWindowsCheckbox.Checked);
        }

        private void startInTrayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["startInTray"] = startInTrayCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void sourceSpotify_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["sourceSpotify"] = sourceSpotifyCheckbox.Checked;
            if (!sourceSpotifyCheckbox.Checked && !sourceAppleMusicCheckbox.Checked)
            {
                sourceAppleMusicCheckbox.Checked = true;
                Properties.Settings.Default["sourceAppleMusic"] = sourceAppleMusicCheckbox.Checked;
            }
            Properties.Settings.Default.Save();
        }

        private void sourceAppleMusicCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["sourceAppleMusic"] = sourceAppleMusicCheckbox.Checked;
            if (!sourceAppleMusicCheckbox.Checked && !sourceSpotifyCheckbox.Checked)
            {
                sourceSpotifyCheckbox.Checked = true;
                Properties.Settings.Default["sourceSpotify"] = sourceSpotifyCheckbox.Checked;
            }
            Properties.Settings.Default.Save();
        }

        private void SetStartup(bool toggle)
        {
            if(toggle)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("Music Recognizer", Application.ExecutablePath);
            } else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue("Music Recognizer", false);
            }

        }

        private void recognizeCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLastInBrowser();
        }
    }
}
