namespace UDP_WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_StartCam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Stream = new System.Windows.Forms.Button();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.TextBox_Ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Microphone = new System.Windows.Forms.Button();
            this.VideoSource_Pbox = new AForge.Controls.VideoSourcePlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_SoundPort = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(978, 26);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(188, 20);
            this.toolStripStatusLabel1.Text = "Initialization of application";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ComboBoxDevices
            // 
            this.ComboBoxDevices.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxDevices.FormattingEnabled = true;
            this.ComboBoxDevices.Location = new System.Drawing.Point(198, 28);
            this.ComboBoxDevices.Name = "ComboBoxDevices";
            this.ComboBoxDevices.Size = new System.Drawing.Size(492, 45);
            this.ComboBoxDevices.TabIndex = 2;
            this.ComboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Web Camera";
            // 
            // button_StartCam
            // 
            this.button_StartCam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_StartCam.Location = new System.Drawing.Point(694, 28);
            this.button_StartCam.Name = "button_StartCam";
            this.button_StartCam.Size = new System.Drawing.Size(94, 45);
            this.button_StartCam.TabIndex = 4;
            this.button_StartCam.Text = "Start";
            this.button_StartCam.UseVisualStyleBackColor = true;
            this.button_StartCam.Click += new System.EventHandler(this.button_StartCam_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextBox_SoundPort);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Button_Stream);
            this.panel1.Controls.Add(this.TextBox_Port);
            this.panel1.Controls.Add(this.TextBox_Ip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(797, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 502);
            this.panel1.TabIndex = 6;
            // 
            // Button_Stream
            // 
            this.Button_Stream.Location = new System.Drawing.Point(3, 201);
            this.Button_Stream.Name = "Button_Stream";
            this.Button_Stream.Size = new System.Drawing.Size(94, 29);
            this.Button_Stream.TabIndex = 3;
            this.Button_Stream.Text = "Start";
            this.Button_Stream.UseVisualStyleBackColor = true;
            this.Button_Stream.Click += new System.EventHandler(this.Button_Stream_Click);
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(3, 110);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(105, 27);
            this.TextBox_Port.TabIndex = 2;
            // 
            // TextBox_Ip
            // 
            this.TextBox_Ip.Location = new System.Drawing.Point(3, 47);
            this.TextBox_Ip.Name = "TextBox_Ip";
            this.TextBox_Ip.Size = new System.Drawing.Size(163, 27);
            this.TextBox_Ip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(529, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Microphone";
            // 
            // Button_Microphone
            // 
            this.Button_Microphone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Microphone.Location = new System.Drawing.Point(694, 76);
            this.Button_Microphone.Name = "Button_Microphone";
            this.Button_Microphone.Size = new System.Drawing.Size(94, 45);
            this.Button_Microphone.TabIndex = 9;
            this.Button_Microphone.Text = "Start";
            this.Button_Microphone.UseVisualStyleBackColor = true;
            this.Button_Microphone.Click += new System.EventHandler(this.Button_Microphone_Click);
            // 
            // VideoSource_Pbox
            // 
            this.VideoSource_Pbox.Location = new System.Drawing.Point(12, 127);
            this.VideoSource_Pbox.Name = "VideoSource_Pbox";
            this.VideoSource_Pbox.Size = new System.Drawing.Size(779, 407);
            this.VideoSource_Pbox.TabIndex = 10;
            this.VideoSource_Pbox.Text = "videoSourcePlayer1";
            this.VideoSource_Pbox.VideoSource = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Video Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sound Port:";
            // 
            // TextBox_SoundPort
            // 
            this.TextBox_SoundPort.Location = new System.Drawing.Point(3, 168);
            this.TextBox_SoundPort.Name = "TextBox_SoundPort";
            this.TextBox_SoundPort.Size = new System.Drawing.Size(105, 27);
            this.TextBox_SoundPort.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 563);
            this.Controls.Add(this.VideoSource_Pbox);
            this.Controls.Add(this.Button_Microphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_StartCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxDevices);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "UDP Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_StartCam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_Stream;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.TextBox TextBox_Ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Microphone;
        private AForge.Controls.VideoSourcePlayer VideoSource_Pbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_SoundPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
