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

namespace MusicRecognizer
{
    class Audd
    {
        private string directory;
        private string fileName;
        private string audioSource;
        private int audioSourceIndex;
        private string fileFormat;
        private string sampleRate;
        private string bitrate;
        private string bits;
        private string channels;
        private string sDestinationFile;
        private CSAudioRecorder.Mode recorderMode;
        private string[] songHistory;
        private string return_type;

        public string apiResult;
        public dynamic latestSong;

        private CSAudioRecorder.AudioRecorder audioRecorder1;

        public Audd(string directory, string fileName, string audioSource, int audioSourceIndex, string fileFormat, 
            string sampleRate, string return_type, string bitrate = "192", string bits = "16", string channels = "2", CSAudioRecorder.Mode recorderMode = CSAudioRecorder.Mode.WasapiLoopbackCapture)
        {
            this.directory = directory;
            this.fileName = fileName;
            this.audioSource = audioSource;
            this.audioSourceIndex = audioSourceIndex;
            this.fileFormat = fileFormat;
            this.sampleRate = sampleRate;
            this.bitrate = bitrate;
            this.bits = bits;
            this.channels = channels;
            this.recorderMode = recorderMode;

            this.return_type = return_type;

            this.audioRecorder1 = new CSAudioRecorder.AudioRecorder();
        }
        public void startRecording()
        {
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Recording)
            {
                audioRecorder1.Stop();

                while (audioRecorder1.RecordingState != CSAudioRecorder.RecordingState.Ready)
                {
                    Application.DoEvents();

                    Thread.Sleep(100);
                }
            }
            string folder = ".\\Temp";
            string sDestinationFile = folder + "\\out.mp3";
            bool exists = System.IO.Directory.Exists(folder);
            if (!exists)
                System.IO.Directory.CreateDirectory(folder);
            audioRecorder1.FileName = sDestinationFile;
            audioRecorder1.AudioSource = this.audioSource;
            audioRecorder1.DeviceIndex = this.audioSourceIndex;
            audioRecorder1.Format = (CSAudioRecorder.Format)Enum.Parse(typeof(CSAudioRecorder.Format), this.fileFormat);
            #region MoreOptionalProperties
            audioRecorder1.Bitrate = (CSAudioRecorder.Bitrate)Enum.Parse(typeof(CSAudioRecorder.Bitrate), this.bitrate);
            audioRecorder1.Samplerate = (CSAudioRecorder.Samplerate)Enum.Parse(typeof(CSAudioRecorder.Samplerate), this.sampleRate);
            audioRecorder1.Bits = (CSAudioRecorder.Bits)Enum.Parse(typeof(CSAudioRecorder.Bits), this.bits);
            audioRecorder1.Channels = (CSAudioRecorder.Channels)Enum.Parse(typeof(CSAudioRecorder.Channels), this.channels);
            audioRecorder1.Mode = this.recorderMode;
            audioRecorder1.Latency = 100;
            audioRecorder1.StartOnNoiseVal = 1.0f;
            audioRecorder1.StopOnSilenceVal = 1.0f;
            audioRecorder1.StopOnSilenceSeconds = 3;
            #endregion
            audioRecorder1.Start();
        }
        public void stopRecording()
        {
            if (audioRecorder1.RecordingState == CSAudioRecorder.RecordingState.Ready)
                return;
            audioRecorder1.Stop();
        }

        public string recognize()
        {
            string folder = ".\\Temp";
            string sDestinationFile = folder + "\\out.mp3";
            try
            {
                string audd_api_key = Constants.audd_api_key;
                string audd_api_url = Constants.audd_api_url;
                //string audd_api_return = Constants.audd_api_return;
                var client = new RestClient(audd_api_url);
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddFile("file", sDestinationFile);
                request.AddParameter("return", this.return_type);
                request.AddParameter("api_token", audd_api_key);
                IRestResponse response = client.Execute(request);
                dynamic data = JObject.Parse(response.Content);
                
                if (data.status == "success" && data.result != null)
                {
                    this.latestSong = data;
                    Log.Write("Successfully detected song. " + data.ToString(Newtonsoft.Json.Formatting.None));
                    return "success";
                }
                else if (data.status == "success" && data.result == null)
                {
                    Log.Write("Song Detection failed. " + data.ToString(Newtonsoft.Json.Formatting.None));
                    return "failed";
                }
                else
                {
                    Log.Write("Song Detection errored. " + data.ToString(Newtonsoft.Json.Formatting.None));
                    return "error";
                }

            }
            catch (Exception e)
            {
                Log.Write("Recognize fatal error. " + e.ToString());
                return "error";
            }
        }

    }
}
