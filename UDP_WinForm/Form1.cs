using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace UDP_WinForm
{
    public partial class MainForm : Form
    {
        private VideoCaptureDevice _webcam;
        private CancellationTokenSource _source = new CancellationTokenSource();
        private IWaveIn _waveIn;
        private BufferedWaveProvider _provider;
        private DirectSoundOut _waveOut;

        public MainForm()
        {
            InitializeComponent();
            var _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (_videoDevices.Count == 0)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "No devices found";
                return;
            }
            else
            {
                foreach (FilterInfo device in _videoDevices)
                {
                    ComboBoxDevices.Items.Add(device.Name);
                }
            }
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void ComboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            var selectedDevice = ComboBoxDevices.SelectedItem.ToString();
            foreach (FilterInfo device in _videoDevices)
            {
                if (device.Name == selectedDevice)
                {
                    _webcam = new VideoCaptureDevice(device.MonikerString);                    
                }
                
            }
        }
        private void button_StartCam_Click(object sender, EventArgs e)
        {
            try
            {
                if (_webcam.IsRunning)
                {
                    ((Button)sender).Text = "Start";
                    _webcam.SignalToStop();
                   
                    
                }
                else
                {
                    _webcam.Start();
                    VideoSource_Pbox.VideoSource = _webcam;
                    ((Button)sender).Text = "Stop";
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_webcam != null)
            {
                if (_webcam.IsRunning)
                {
                    _webcam.SignalToStop();
                    _webcam.WaitForStop();
                }
                
            }
            if (Button_Microphone.Text=="Stop")
            {
                _waveIn.StopRecording();
                _waveOut.Stop();
                _provider.ClearBuffer();
                _waveIn.Dispose();
                _waveOut.Dispose();
            }
        }

        private void Button_Stream_Click(object sender, EventArgs e)
        {
            if (Button_Stream.Text == "Start")
            {
                _webcam.NewFrame += SendVideo;
                _waveIn.DataAvailable += SendSound;



                Button_Stream.Text = "Stop";
            }else if (Button_Stream.Text == "Stop")
            {
                _webcam.NewFrame -= SendVideo;
                _waveIn.DataAvailable-=SendSound;


                Button_Stream.Text = "Start";
            }
            

        }
        private void SendVideo(object sender, NewFrameEventArgs eventArgs)
        {
            UdpClient client = null;

            try
            {
                client = new UdpClient();
                MemoryStream ms = new MemoryStream();
                //eventArgs.Frame.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                var param = new EncoderParameters();
                param.Param =new EncoderParameter[]{new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L - 50L)};

                eventArgs.Frame.Save(ms, ImageCodecInfo.GetImageEncoders()[1], param);
                byte[] bmpBytes = ms.ToArray();
                client.Send(bmpBytes, bmpBytes.Length, new System.Net.IPEndPoint(System.Net.IPAddress.Parse(TextBox_Ip.Text), int.Parse(TextBox_Port.Text)));

                client.Close();
                Debug.WriteLine(bmpBytes.Length);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Button_Microphone_Click(object sender, EventArgs e)
        {
            if (Button_Microphone.Text == "Start")
            {
                _waveIn = new WaveIn();
                _waveIn.WaveFormat = new WaveFormat(44100, 1);
                _waveIn.DataAvailable += OnDataAvailable;

                _waveOut = new DirectSoundOut();
                _provider = new BufferedWaveProvider(_waveIn.WaveFormat);
                _waveOut.Init(_provider);
                _waveOut.Play();

                _waveIn.StartRecording();
                Button_Microphone.Text = "Stop";

                //waveFile = new WaveFileWriter("Test00.wav", waveIn.WaveFormat);
            }
            else
            {
                _waveIn.StopRecording();
                _waveOut.Stop();
                _provider.ClearBuffer();

                _waveIn.Dispose();
                _waveOut.Dispose();
                _provider = null;
                Button_Microphone.Text = "Start";
            }


        }

        private void OnDataAvailable(object? sender, WaveInEventArgs e)
        {
            _provider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }
        private void SendSound(object sender, WaveInEventArgs e)
        {
            UdpClient client = null;

            try
            {
                client = new UdpClient();
                MemoryStream ms = new MemoryStream();
                //eventArgs.Frame.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                
                ms.Write(e.Buffer,0, e.BytesRecorded);
                byte[] bmpBytes = ms.ToArray();
                client.Send(bmpBytes, bmpBytes.Length, new System.Net.IPEndPoint(System.Net.IPAddress.Parse(TextBox_Ip.Text), int.Parse(TextBox_SoundPort.Text)));

                client.Close();
                Debug.WriteLine(bmpBytes.Length);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
    