namespace AlbumGrid
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.imgListAlbums = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBgColor = new System.Windows.Forms.CheckBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.backColors = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseFolder
            // 
            this.browseFolder.Description = "Please choose a folder that contains a set of JPG, GIF, or PNG images";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(6, 19);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(247, 20);
            this.txtFolderPath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(259, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(340, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Images";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(455, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Location = new System.Drawing.Point(455, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 74);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Images will stretch\r\nto fit these dimensions.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(52, 45);
            this.nudHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(40, 20);
            this.nudHeight.TabIndex = 2;
            this.nudHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(52, 19);
            this.nudWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(40, 20);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(536, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Grid";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudCols
            // 
            this.nudCols.Location = new System.Drawing.Point(64, 19);
            this.nudCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCols.Name = "nudCols";
            this.nudCols.Size = new System.Drawing.Size(40, 20);
            this.nudCols.TabIndex = 8;
            this.nudCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pbGrid
            // 
            this.pbGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGrid.Location = new System.Drawing.Point(455, 274);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(244, 244);
            this.pbGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrid.TabIndex = 8;
            this.pbGrid.TabStop = false;
            // 
            // imgListAlbums
            // 
            this.imgListAlbums.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListAlbums.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListAlbums.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProgress);
            this.groupBox2.Controls.Add(this.txtFolderPath);
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browse for Images";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(437, 21);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 3;
            // 
            // pnlGrid
            // 
            this.pnlGrid.AllowDrop = true;
            this.pnlGrid.AutoScroll = true;
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGrid.Location = new System.Drawing.Point(12, 94);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(437, 424);
            this.pnlGrid.TabIndex = 10;
            this.pnlGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlGrid_DragDrop);
            this.pnlGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlGrid_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBgColor);
            this.groupBox3.Controls.Add(this.pnlColor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudCols);
            this.groupBox3.Location = new System.Drawing.Point(455, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grid Options";
            // 
            // chkBgColor
            // 
            this.chkBgColor.AutoSize = true;
            this.chkBgColor.Location = new System.Drawing.Point(110, 20);
            this.chkBgColor.Name = "chkBgColor";
            this.chkBgColor.Size = new System.Drawing.Size(106, 17);
            this.chkBgColor.TabIndex = 15;
            this.chkBgColor.Text = "Use Background";
            this.chkBgColor.UseVisualStyleBackColor = true;
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(223, 20);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(16, 16);
            this.pnlColor.TabIndex = 14;
            this.pnlColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColor_Paint);
            this.pnlColor.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Columns:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Image Preview:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "You can rearrange images by dragging and dropping them.";
            // 
            // saveImage
            // 
            this.saveImage.DefaultExt = "jpg";
            this.saveImage.Filter = "PNG Files|*.png";
            // 
            // backColors
            // 
            this.backColors.AnyColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCredits});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCredits
            // 
            this.lblCredits.IsLink = true;
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(140, 17);
            this.lblCredits.Text = "Created by Intrepid Studios";
            this.lblCredits.ToolTipText = "Visit Kamran\'s website";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbGrid);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Image Grid Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudCols;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.ImageList imgListAlbums;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.ColorDialog backColors;
        private System.Windows.Forms.CheckBox chkBgColor;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCredits;
    }
}

