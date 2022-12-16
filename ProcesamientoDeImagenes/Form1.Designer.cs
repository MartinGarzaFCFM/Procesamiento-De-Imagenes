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
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.RGBBox = new System.Windows.Forms.GroupBox();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.facesCheck = new System.Windows.Forms.CheckBox();
            this.facesCount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.MovCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.RGBBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
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
            this.btnPhoto.Location = new System.Drawing.Point(556, 583);
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
            this.histogramBox1.Location = new System.Drawing.Point(667, 83);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(380, 189);
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
            // facesCheck
            // 
            this.facesCheck.AutoSize = true;
            this.facesCheck.Font = new System.Drawing.Font("TodaySHOP-Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facesCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.facesCheck.Location = new System.Drawing.Point(270, 583);
            this.facesCheck.Name = "facesCheck";
            this.facesCheck.Size = new System.Drawing.Size(125, 25);
            this.facesCheck.TabIndex = 13;
            this.facesCheck.Text = "Contar Caras";
            this.facesCheck.UseVisualStyleBackColor = true;
            // 
            // facesCount
            // 
            this.facesCount.Location = new System.Drawing.Point(213, 583);
            this.facesCount.Name = "facesCount";
            this.facesCount.Size = new System.Drawing.Size(51, 25);
            this.facesCount.TabIndex = 14;
            this.facesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem,
            this.videoToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.imagenToolStripMenuItem.Text = "Imagen";
            this.imagenToolStripMenuItem.Click += new System.EventHandler(this.imagenToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.videoToolStripMenuItem.Text = "Video";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.ErrorImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.Image = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.InitialImage = global::ProcesamientoDeImagenes.Properties.Resources.webcamMissing;
            this.pic.Location = new System.Drawing.Point(16, 83);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(640, 480);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // MovCheck
            // 
            this.MovCheck.AutoSize = true;
            this.MovCheck.Font = new System.Drawing.Font("TodaySHOP-Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MovCheck.Location = new System.Drawing.Point(16, 583);
            this.MovCheck.Name = "MovCheck";
            this.MovCheck.Size = new System.Drawing.Size(191, 25);
            this.MovCheck.TabIndex = 13;
            this.MovCheck.Text = "Detectar Movimiento";
            this.MovCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.facesCount);
            this.Controls.Add(this.MovCheck);
            this.Controls.Add(this.facesCheck);
            this.Controls.Add(this.RGBBox);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("TodaySHOP-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.RGBBox.ResumeLayout(false);
            this.RGBBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnPhoto;
        private HistogramBox histogramBox1;
        private System.Windows.Forms.GroupBox RGBBox;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.CheckBox facesCheck;
        private System.Windows.Forms.TextBox facesCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.CheckBox MovCheck;
    }
}

