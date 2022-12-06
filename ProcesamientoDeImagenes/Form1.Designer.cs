using Emgu.CV.UI;

namespace ProcesamientoDeImagenes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.RGBBox = new System.Windows.Forms.GroupBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.RGBBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("TodaySHOP-Medium", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 550);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCamera
            // 
            this.cboCamera.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(103, 548);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(4);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(302, 26);
            this.cboCamera.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.ErrorImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.Image = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.InitialImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.Location = new System.Drawing.Point(16, 16);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(640, 480);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(432, 544);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.cboFilter.Location = new System.Drawing.Point(662, 470);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(164, 26);
            this.cboFilter.TabIndex = 5;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("TodaySHOP-Medium", 14F);
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilter.Location = new System.Drawing.Point(663, 449);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(49, 21);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter";
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(556, 544);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(100, 32);
            this.btnPhoto.TabIndex = 3;
            this.btnPhoto.Text = "&Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.AutoSize = true;
            this.histogramBox1.Location = new System.Drawing.Point(668, 16);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(514, 269);
            this.histogramBox1.TabIndex = 8;
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
            // RGBBox
            // 
            this.RGBBox.Controls.Add(this.trackBarB);
            this.RGBBox.Controls.Add(this.trackBarG);
            this.RGBBox.Controls.Add(this.trackBarR);
            this.RGBBox.Location = new System.Drawing.Point(832, 470);
            this.RGBBox.Name = "RGBBox";
            this.RGBBox.Size = new System.Drawing.Size(183, 186);
            this.RGBBox.TabIndex = 11;
            this.RGBBox.TabStop = false;
            this.RGBBox.Text = "RGB";
            this.RGBBox.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("TodaySHOP-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.RGBBox.ResumeLayout(false);
            this.RGBBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnPhoto;
        private HistogramBox histogramBox1;
        private System.Windows.Forms.GroupBox RGBBox;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
    }
}

