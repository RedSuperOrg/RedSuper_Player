namespace RedSuper_Player
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuDragControlTopAbout = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControlMainAbout = new ns1.BunifuDragControl(this.components);
            this.bunifuGradientPanelMain = new ns1.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanelTop = new ns1.BunifuGradientPanel();
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.bunifuImageButtonCloseAbout = new ns1.BunifuImageButton();
            this.bunifuDatepicker2 = new ns1.BunifuDatepicker();
            this.bunifuGradientPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonCloseAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControlTopAbout
            // 
            this.bunifuDragControlTopAbout.Fixed = true;
            this.bunifuDragControlTopAbout.Horizontal = true;
            this.bunifuDragControlTopAbout.TargetControl = this.bunifuGradientPanelTop;
            this.bunifuDragControlTopAbout.Vertical = true;
            // 
            // bunifuDragControlMainAbout
            // 
            this.bunifuDragControlMainAbout.Fixed = true;
            this.bunifuDragControlMainAbout.Horizontal = true;
            this.bunifuDragControlMainAbout.TargetControl = this.bunifuGradientPanelMain;
            this.bunifuDragControlMainAbout.Vertical = true;
            // 
            // bunifuGradientPanelMain
            // 
            this.bunifuGradientPanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelMain.BackgroundImage")));
            this.bunifuGradientPanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelMain.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanelMain.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanelMain.Controls.Add(this.bunifuGradientPanelTop);
            this.bunifuGradientPanelMain.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanelMain.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanelMain.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanelMain.GradientTopRight = System.Drawing.Color.Brown;
            this.bunifuGradientPanelMain.Location = new System.Drawing.Point(-8, -5);
            this.bunifuGradientPanelMain.Name = "bunifuGradientPanelMain";
            this.bunifuGradientPanelMain.Quality = 10;
            this.bunifuGradientPanelMain.Size = new System.Drawing.Size(339, 307);
            this.bunifuGradientPanelMain.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RedSuper_Player.Properties.Resources.ATT10008;
            this.pictureBox2.Location = new System.Drawing.Point(184, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RedSuper_Player.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(35, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanelTop
            // 
            this.bunifuGradientPanelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelTop.BackgroundImage")));
            this.bunifuGradientPanelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelTop.Controls.Add(this.bunifuDatepicker2);
            this.bunifuGradientPanelTop.Controls.Add(this.bunifuDatepicker1);
            this.bunifuGradientPanelTop.Controls.Add(this.bunifuImageButtonCloseAbout);
            this.bunifuGradientPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanelTop.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanelTop.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanelTop.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanelTop.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanelTop.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelTop.Name = "bunifuGradientPanelTop";
            this.bunifuGradientPanelTop.Quality = 10;
            this.bunifuGradientPanelTop.Size = new System.Drawing.Size(339, 56);
            this.bunifuGradientPanelTop.TabIndex = 0;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(20, 8);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(275, 45);
            this.bunifuDatepicker1.TabIndex = 3;
            this.bunifuDatepicker1.Value = new System.DateTime(2017, 5, 16, 16, 34, 31, 817);
            // 
            // bunifuImageButtonCloseAbout
            // 
            this.bunifuImageButtonCloseAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonCloseAbout.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonCloseAbout.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonCloseAbout.Image")));
            this.bunifuImageButtonCloseAbout.ImageActive = null;
            this.bunifuImageButtonCloseAbout.Location = new System.Drawing.Point(301, 8);
            this.bunifuImageButtonCloseAbout.Name = "bunifuImageButtonCloseAbout";
            this.bunifuImageButtonCloseAbout.Size = new System.Drawing.Size(25, 19);
            this.bunifuImageButtonCloseAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonCloseAbout.TabIndex = 2;
            this.bunifuImageButtonCloseAbout.TabStop = false;
            this.bunifuImageButtonCloseAbout.Zoom = 10;
            this.bunifuImageButtonCloseAbout.Click += new System.EventHandler(this.bunifuImageButtonCloseAbout_Click);
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(20, 8);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(275, 45);
            this.bunifuDatepicker2.TabIndex = 4;
            this.bunifuDatepicker2.Value = new System.DateTime(2017, 5, 16, 16, 43, 2, 374);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 299);
            this.Controls.Add(this.bunifuGradientPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.bunifuGradientPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonCloseAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuGradientPanel bunifuGradientPanelMain;
        private ns1.BunifuGradientPanel bunifuGradientPanelTop;
        private ns1.BunifuImageButton bunifuImageButtonCloseAbout;
        private ns1.BunifuDragControl bunifuDragControlTopAbout;
        private ns1.BunifuDragControl bunifuDragControlMainAbout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuDatepicker bunifuDatepicker1;
        private ns1.BunifuDatepicker bunifuDatepicker2;
    }
}