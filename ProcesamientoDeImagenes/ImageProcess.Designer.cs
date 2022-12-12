namespace ProcesamientoDeImagenes
{
    partial class ImageProcess
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
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.imageOut = new System.Windows.Forms.PictureBox();
            this.RGBBox = new System.Windows.Forms.GroupBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOut)).BeginInit();
            this.RGBBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.SuspendLayout();
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
            this.imagePic.TabIndex = 3;
            this.imagePic.TabStop = false;
            // 
            // imageOut
            // 
            this.imageOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageOut.ErrorImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.imageOut.InitialImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.imageOut.Location = new System.Drawing.Point(467, 13);
            this.imageOut.Margin = new System.Windows.Forms.Padding(4);
            this.imageOut.Name = "imageOut";
            this.imageOut.Size = new System.Drawing.Size(320, 240);
            this.imageOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageOut.TabIndex = 4;
            this.imageOut.TabStop = false;
            // 
            // RGBBox
            // 
            this.RGBBox.Controls.Add(this.trackBarB);
            this.RGBBox.Controls.Add(this.trackBarG);
            this.RGBBox.Controls.Add(this.trackBarR);
            this.RGBBox.Location = new System.Drawing.Point(483, 250);
            this.RGBBox.Name = "RGBBox";
            this.RGBBox.Size = new System.Drawing.Size(183, 186);
            this.RGBBox.TabIndex = 14;
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
            this.lblFilter.Location = new System.Drawing.Point(371, 260);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(49, 21);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "Filter";
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "",
            "Invertir",
            "Remolino",
            "B/N",
            "Sepia",
            "Tint",
            "Mirror",
            "Edge"});
            this.cboFilter.Location = new System.Drawing.Point(313, 284);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(164, 21);
            this.cboFilter.TabIndex = 12;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("TodaySHOP-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(712, 274);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 31);
            this.btnSaveImage.TabIndex = 15;
            this.btnSaveImage.Text = "Guardar";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // ImageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 437);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.imageOut);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.imagePic);
            this.Name = "ImageProcess";
            this.Text = "ImageProcess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageProcess_FormClosing);
            this.Load += new System.EventHandler(this.ImageProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOut)).EndInit();
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
        private System.Windows.Forms.PictureBox imageOut;
        private System.Windows.Forms.GroupBox RGBBox;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnSaveImage;
    }
}