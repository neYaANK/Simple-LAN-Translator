using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using System.Diagnostics;

namespace UDP_Receiver
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _source = new CancellationTokenSource();
        private DirectSoundOut _waveOut;
        private BufferedWaveProvider _prov;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonReceive.Text == "Receive")
            {
                _source.Dispose();
                _source = new CancellationTokenSource();
                _waveOut = new DirectSoundOut();
                _prov = new BufferedWaveProvider(new WaveFormat(44100, 1));
                _waveOut.Init(_prov);




                ReceiveVideoAsync();
                ReceiveSoundAsync();
                _waveOut.Play();

                buttonReceive.Text = "Stop";

            }
            else if (buttonReceive.Text == "Stop")
            {
                _source.Cancel();

                _waveOut.Stop();
                _prov.ClearBuffer();
                _waveOut.Dispose();

                buttonReceive.Text = "Receive";
            }

        }

        private async void ReceiveVideoAsync()
        {
            var token = _source.Token;
            await new TaskFactory().StartNew(() =>
            {
                UdpClient client = null;
                try
                {
                    while (true)
                    {

                        IPEndPoint ep = null;
                        client = new UdpClient(int.Parse(TextBox_Port.Text));
                        byte[] buff = client.Receive(ref ep);
                        Bitmap bmp;
                        using (var ms = new MemoryStream(buff))
                        {
                            bmp = new Bitmap(ms);
                        }
                        pictureBox1.Image = new Bitmap(bmp, pictureBox1.Width, pictureBox1.Height);
                        client.Close();

                        token.ThrowIfCancellationRequested();
                    }

                }
                catch (OperationCanceledException ex) { pictureBox1.Image.Dispose(); pictureBox1.Image = null; }
                catch (Exception ex) { }
            });
        }


        private async void ReceiveSoundAsync()
        {
            var token = _source.Token;
            await new TaskFactory().StartNew(() =>
            {


                //BufferedWaveProvider provider = new BufferedWaveProvider(new WaveFormat(44100, 1));
                UdpClient client = null;

                try
                {
                    while (true)
                    {

                        IPEndPoint ep = null;
                        client = new UdpClient(int.Parse(TextBox_SoundPort.Text));
                        byte[] buff = client.Receive(ref ep);

                        //Debug.WriteLine(buff.Length);

                        _prov.AddSamples(buff, 0, buff.Length);

                        client.Close();

                        token.ThrowIfCancellationRequested();
                    }

                }
                catch (OperationCanceledException ex) { }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_waveOut!=null)
            _source.Cancel();
            _waveOut.Stop();
            _prov.ClearBuffer();
            _waveOut.Dispose();
        }
    }
}
