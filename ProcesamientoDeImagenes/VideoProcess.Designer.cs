namespace ProcesamientoDeImagenes
{
    partial class VideoProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoProcess));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.playBtn = new System.Windows.Forms.Button();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.RGBBox = new System.Windows.Forms.GroupBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.RGBBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(459, 13);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(320, 240);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 261);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(320, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(80, 312);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(50, 34);
            this.playBtn.TabIndex = 7;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // imagePic
            // 
            this.imagePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePic.ErrorImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.imagePic.InitialImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.imagePic.Location = new System.Drawing.Point(13, 13);
            this.imagePic.Margin = new System.Windows.Forms.Padding(4);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(320, 240);
            this.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePic.TabIndex = 4;
            this.imagePic.TabStop = false;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(136, 312);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(50, 34);
            this.pauseBtn.TabIndex = 7;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(192, 312);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(50, 34);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("TodaySHOP-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(704, 285);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 31);
            this.btnSaveImage.TabIndex = 19;
            this.btnSaveImage.Text = "Guardar";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // RGBBox
            // 
            this.RGBBox.Controls.Add(this.trackBarB);
            this.RGBBox.Controls.Add(this.trackBarG);
            this.RGBBox.Controls.Add(this.trackBarR);
            this.RGBBox.Location = new System.Drawing.Point(504, 261);
            this.RGBBox.Name = "RGBBox";
            this.RGBBox.Size = new System.Drawing.Size(183, 186);
            this.RGBBox.TabIndex = 18;
            this.RGBBox.TabStop = false;
            this.RGBBox.Text = "RGB";
            // 
            // trackBarB
            // 
            this.trackBarB.BackColor = System.Drawing.Color.SkyBlue;
            this.trackBarB.Location = new System.Drawing.Point(119, 24);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarB.Size = new System.Drawing.Size(45, 151);
            this.trackBarB.TabIndex = 12;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarG
            // 
            this.trackBarG.BackColor = System.Drawing.Color.ForestGreen;
            this.trackBarG.Location = new System.Drawing.Point(68, 24);
            this.trackBarG.Maximum = 100;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarG.Size = new System.Drawing.Size(45, 151);
            this.trackBarG.TabIndex = 11;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.BackColor = System.Drawing.Color.DarkRed;
            this.trackBarR.Location = new System.Drawing.Point(17, 24);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarR.Size = new System.Drawing.Size(45, 151);
            this.trackBarR.TabIndex = 10;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("TodaySHOP-Medium", 14F);
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilter.Location = new System.Drawing.Point(392, 271);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(49, 21);
            this.lblFilter.TabIndex = 17;
            this.lblFilter.Text = "Filter";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "",
            "Invertir",
            "Offset",
            "B/N",
            "Sepia",
            "Tint"});
            this.cboFilter.Location = new System.Drawing.Point(334, 295);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(164, 21);
            this.cboFilter.TabIndex = 16;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // VideoProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.imagePic);
            this.Name = "VideoProcess";
            this.Text = "VideoProcess";
            this.Load += new System.EventHandler(this.VideoProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.RGBBox.ResumeLayout(false);
            this.RGBBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.GroupBox RGBBox;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
    }
}