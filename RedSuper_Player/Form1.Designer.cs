﻿namespace RedSuper_Player
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuFlatButtonPlaylists = new ns1.BunifuFlatButton();
            this.bunifuFlatButtonMySongs = new ns1.BunifuFlatButton();
            this.bunifuCustomLabelLibrary = new ns1.BunifuCustomLabel();
            this.bunifuFlatButtonYoutube = new ns1.BunifuFlatButton();
            this.bunifuFlatButtonVideo = new ns1.BunifuFlatButton();
            this.bunifuFlatButtonBrowse = new ns1.BunifuFlatButton();
            this.bunifuImageButton4 = new ns1.BunifuImageButton();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.panelText = new System.Windows.Forms.Panel();
            this.bunifuImageButtonSlideMenu = new ns1.BunifuImageButton();
            this.bunifuCustomTextboxSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuImageButtonSearch = new ns1.BunifuImageButton();
            this.bunifuCustomLabelMain = new ns1.BunifuCustomLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.bunifuCustomLabelVersionText = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabelTopText = new ns1.BunifuCustomLabel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bunifuImageButtonMute = new ns1.BunifuImageButton();
            this.bunifuImageButtonSettings = new ns1.BunifuImageButton();
            this.bunifuImageButtonEnd = new ns1.BunifuImageButton();
            this.bunifuImageButtonStart = new ns1.BunifuImageButton();
            this.bunifuImageButtonPlay = new ns1.BunifuImageButton();
            this.bunifuCustomLabelArtistExtraInfo = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabelArtistName = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabelEndTimer = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabelStartTimer = new ns1.BunifuCustomLabel();
            this.bunifuSliderVolume = new ns1.BunifuSlider();
            this.bunifuSliderMain = new ns1.BunifuSlider();
            this.pictureBoxCoverSlider = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.bunifuDragControlMenu = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControlText = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControlTop = new ns1.BunifuDragControl(this.components);
            this.bunifuTransitionSlidingMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSlideMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverSlider)).BeginInit();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelMenu.Controls.Add(this.bunifuFlatButton1);
            this.panelMenu.Controls.Add(this.bunifuFlatButtonPlaylists);
            this.panelMenu.Controls.Add(this.bunifuFlatButtonMySongs);
            this.panelMenu.Controls.Add(this.bunifuCustomLabelLibrary);
            this.panelMenu.Controls.Add(this.bunifuFlatButtonYoutube);
            this.panelMenu.Controls.Add(this.bunifuFlatButtonVideo);
            this.panelMenu.Controls.Add(this.bunifuFlatButtonBrowse);
            this.panelMenu.Controls.Add(this.bunifuImageButton4);
            this.panelMenu.Controls.Add(this.bunifuImageButton3);
            this.panelMenu.Controls.Add(this.bunifuImageButton2);
            this.panelMenu.Controls.Add(this.panelText);
            this.bunifuTransitionSlidingMenu.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  Placeholder";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 42D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 446);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "  Placeholder";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonPlaylists
            // 
            this.bunifuFlatButtonPlaylists.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonPlaylists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonPlaylists.BorderRadius = 0;
            this.bunifuFlatButtonPlaylists.ButtonText = "  Playlists";
            this.bunifuFlatButtonPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButtonPlaylists, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonPlaylists.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonPlaylists.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonPlaylists.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonPlaylists.Iconimage")));
            this.bunifuFlatButtonPlaylists.Iconimage_right = null;
            this.bunifuFlatButtonPlaylists.Iconimage_right_Selected = null;
            this.bunifuFlatButtonPlaylists.Iconimage_Selected = null;
            this.bunifuFlatButtonPlaylists.IconMarginLeft = 0;
            this.bunifuFlatButtonPlaylists.IconMarginRight = 0;
            this.bunifuFlatButtonPlaylists.IconRightVisible = true;
            this.bunifuFlatButtonPlaylists.IconRightZoom = 0D;
            this.bunifuFlatButtonPlaylists.IconVisible = true;
            this.bunifuFlatButtonPlaylists.IconZoom = 42D;
            this.bunifuFlatButtonPlaylists.IsTab = false;
            this.bunifuFlatButtonPlaylists.Location = new System.Drawing.Point(12, 401);
            this.bunifuFlatButtonPlaylists.Name = "bunifuFlatButtonPlaylists";
            this.bunifuFlatButtonPlaylists.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonPlaylists.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonPlaylists.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButtonPlaylists.selected = false;
            this.bunifuFlatButtonPlaylists.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButtonPlaylists.TabIndex = 10;
            this.bunifuFlatButtonPlaylists.Text = "  Playlists";
            this.bunifuFlatButtonPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonPlaylists.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonPlaylists.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonMySongs
            // 
            this.bunifuFlatButtonMySongs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonMySongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonMySongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonMySongs.BorderRadius = 0;
            this.bunifuFlatButtonMySongs.ButtonText = "  My Songs";
            this.bunifuFlatButtonMySongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButtonMySongs, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonMySongs.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonMySongs.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonMySongs.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonMySongs.Iconimage")));
            this.bunifuFlatButtonMySongs.Iconimage_right = null;
            this.bunifuFlatButtonMySongs.Iconimage_right_Selected = null;
            this.bunifuFlatButtonMySongs.Iconimage_Selected = null;
            this.bunifuFlatButtonMySongs.IconMarginLeft = 0;
            this.bunifuFlatButtonMySongs.IconMarginRight = 0;
            this.bunifuFlatButtonMySongs.IconRightVisible = true;
            this.bunifuFlatButtonMySongs.IconRightZoom = 0D;
            this.bunifuFlatButtonMySongs.IconVisible = true;
            this.bunifuFlatButtonMySongs.IconZoom = 42D;
            this.bunifuFlatButtonMySongs.IsTab = false;
            this.bunifuFlatButtonMySongs.Location = new System.Drawing.Point(12, 356);
            this.bunifuFlatButtonMySongs.Name = "bunifuFlatButtonMySongs";
            this.bunifuFlatButtonMySongs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonMySongs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonMySongs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButtonMySongs.selected = false;
            this.bunifuFlatButtonMySongs.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButtonMySongs.TabIndex = 9;
            this.bunifuFlatButtonMySongs.Text = "  My Songs";
            this.bunifuFlatButtonMySongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonMySongs.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonMySongs.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabelLibrary
            // 
            this.bunifuCustomLabelLibrary.AutoSize = true;
            this.bunifuCustomLabelLibrary.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelLibrary, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelLibrary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelLibrary.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelLibrary.Location = new System.Drawing.Point(0, 321);
            this.bunifuCustomLabelLibrary.Name = "bunifuCustomLabelLibrary";
            this.bunifuCustomLabelLibrary.Size = new System.Drawing.Size(60, 16);
            this.bunifuCustomLabelLibrary.TabIndex = 8;
            this.bunifuCustomLabelLibrary.Text = "LIBRARY";
            // 
            // bunifuFlatButtonYoutube
            // 
            this.bunifuFlatButtonYoutube.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonYoutube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonYoutube.BorderRadius = 0;
            this.bunifuFlatButtonYoutube.ButtonText = "  Youtube";
            this.bunifuFlatButtonYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButtonYoutube, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonYoutube.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonYoutube.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonYoutube.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonYoutube.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonYoutube.Iconimage")));
            this.bunifuFlatButtonYoutube.Iconimage_right = null;
            this.bunifuFlatButtonYoutube.Iconimage_right_Selected = null;
            this.bunifuFlatButtonYoutube.Iconimage_Selected = null;
            this.bunifuFlatButtonYoutube.IconMarginLeft = 0;
            this.bunifuFlatButtonYoutube.IconMarginRight = 0;
            this.bunifuFlatButtonYoutube.IconRightVisible = true;
            this.bunifuFlatButtonYoutube.IconRightZoom = 0D;
            this.bunifuFlatButtonYoutube.IconVisible = true;
            this.bunifuFlatButtonYoutube.IconZoom = 49D;
            this.bunifuFlatButtonYoutube.IsTab = false;
            this.bunifuFlatButtonYoutube.Location = new System.Drawing.Point(4, 248);
            this.bunifuFlatButtonYoutube.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButtonYoutube.Name = "bunifuFlatButtonYoutube";
            this.bunifuFlatButtonYoutube.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonYoutube.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonYoutube.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButtonYoutube.selected = false;
            this.bunifuFlatButtonYoutube.Size = new System.Drawing.Size(281, 59);
            this.bunifuFlatButtonYoutube.TabIndex = 7;
            this.bunifuFlatButtonYoutube.Text = "  Youtube";
            this.bunifuFlatButtonYoutube.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonYoutube.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonYoutube.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButtonVideo
            // 
            this.bunifuFlatButtonVideo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonVideo.BorderRadius = 0;
            this.bunifuFlatButtonVideo.ButtonText = "  Video";
            this.bunifuFlatButtonVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButtonVideo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonVideo.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.bunifuFlatButtonVideo.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonVideo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonVideo.Iconimage")));
            this.bunifuFlatButtonVideo.Iconimage_right = null;
            this.bunifuFlatButtonVideo.Iconimage_right_Selected = null;
            this.bunifuFlatButtonVideo.Iconimage_Selected = null;
            this.bunifuFlatButtonVideo.IconMarginLeft = 0;
            this.bunifuFlatButtonVideo.IconMarginRight = 0;
            this.bunifuFlatButtonVideo.IconRightVisible = true;
            this.bunifuFlatButtonVideo.IconRightZoom = 0D;
            this.bunifuFlatButtonVideo.IconVisible = true;
            this.bunifuFlatButtonVideo.IconZoom = 42D;
            this.bunifuFlatButtonVideo.IsTab = false;
            this.bunifuFlatButtonVideo.Location = new System.Drawing.Point(5, 203);
            this.bunifuFlatButtonVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButtonVideo.Name = "bunifuFlatButtonVideo";
            this.bunifuFlatButtonVideo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonVideo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonVideo.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButtonVideo.selected = false;
            this.bunifuFlatButtonVideo.Size = new System.Drawing.Size(281, 59);
            this.bunifuFlatButtonVideo.TabIndex = 6;
            this.bunifuFlatButtonVideo.Text = "  Video";
            this.bunifuFlatButtonVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonVideo.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonVideo.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonVideo.Click += new System.EventHandler(this.bunifuFlatButtonVideo_Click);
            // 
            // bunifuFlatButtonBrowse
            // 
            this.bunifuFlatButtonBrowse.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonBrowse.BorderRadius = 0;
            this.bunifuFlatButtonBrowse.ButtonText = "  Browse";
            this.bunifuFlatButtonBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuFlatButtonBrowse, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButtonBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonBrowse.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonBrowse.Iconimage")));
            this.bunifuFlatButtonBrowse.Iconimage_right = null;
            this.bunifuFlatButtonBrowse.Iconimage_right_Selected = null;
            this.bunifuFlatButtonBrowse.Iconimage_Selected = null;
            this.bunifuFlatButtonBrowse.IconMarginLeft = 0;
            this.bunifuFlatButtonBrowse.IconMarginRight = 0;
            this.bunifuFlatButtonBrowse.IconRightVisible = true;
            this.bunifuFlatButtonBrowse.IconRightZoom = 0D;
            this.bunifuFlatButtonBrowse.IconVisible = true;
            this.bunifuFlatButtonBrowse.IconZoom = 40D;
            this.bunifuFlatButtonBrowse.IsTab = false;
            this.bunifuFlatButtonBrowse.Location = new System.Drawing.Point(10, 170);
            this.bunifuFlatButtonBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButtonBrowse.Name = "bunifuFlatButtonBrowse";
            this.bunifuFlatButtonBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuFlatButtonBrowse.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuFlatButtonBrowse.selected = false;
            this.bunifuFlatButtonBrowse.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButtonBrowse.TabIndex = 5;
            this.bunifuFlatButtonBrowse.Text = "  Browse";
            this.bunifuFlatButtonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonBrowse.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonBrowse.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonBrowse.Click += new System.EventHandler(this.bunifuFlatButtonBrowse_Click_1);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(62, 6);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(25, 19);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 3;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(37, 6);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(25, 19);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(12, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 19);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // panelText
            // 
            this.panelText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelText.BackgroundImage")));
            this.panelText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelText.Controls.Add(this.bunifuImageButtonSlideMenu);
            this.panelText.Controls.Add(this.bunifuCustomTextboxSearch);
            this.panelText.Controls.Add(this.bunifuImageButtonSearch);
            this.panelText.Controls.Add(this.bunifuCustomLabelMain);
            this.bunifuTransitionSlidingMenu.SetDecoration(this.panelText, BunifuAnimatorNS.DecorationType.None);
            this.panelText.Location = new System.Drawing.Point(12, 31);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(182, 123);
            this.panelText.TabIndex = 0;
            // 
            // bunifuImageButtonSlideMenu
            // 
            this.bunifuImageButtonSlideMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonSlideMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonSlideMenu.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonSlideMenu.Image")));
            this.bunifuImageButtonSlideMenu.ImageActive = null;
            this.bunifuImageButtonSlideMenu.Location = new System.Drawing.Point(5, 0);
            this.bunifuImageButtonSlideMenu.Name = "bunifuImageButtonSlideMenu";
            this.bunifuImageButtonSlideMenu.Size = new System.Drawing.Size(45, 37);
            this.bunifuImageButtonSlideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSlideMenu.TabIndex = 8;
            this.bunifuImageButtonSlideMenu.TabStop = false;
            this.bunifuImageButtonSlideMenu.Zoom = 10;
            this.bunifuImageButtonSlideMenu.Click += new System.EventHandler(this.bunifuImageButtonSlideMenu_Click);
            // 
            // bunifuCustomTextboxSearch
            // 
            this.bunifuCustomTextboxSearch.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomTextboxSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomTextboxSearch, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomTextboxSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextboxSearch.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomTextboxSearch.Location = new System.Drawing.Point(45, 50);
            this.bunifuCustomTextboxSearch.Multiline = true;
            this.bunifuCustomTextboxSearch.Name = "bunifuCustomTextboxSearch";
            this.bunifuCustomTextboxSearch.Size = new System.Drawing.Size(98, 19);
            this.bunifuCustomTextboxSearch.TabIndex = 4;
            // 
            // bunifuImageButtonSearch
            // 
            this.bunifuImageButtonSearch.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonSearch, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonSearch.Image")));
            this.bunifuImageButtonSearch.ImageActive = null;
            this.bunifuImageButtonSearch.Location = new System.Drawing.Point(146, 49);
            this.bunifuImageButtonSearch.Name = "bunifuImageButtonSearch";
            this.bunifuImageButtonSearch.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSearch.TabIndex = 0;
            this.bunifuImageButtonSearch.TabStop = false;
            this.bunifuImageButtonSearch.Zoom = 10;
            // 
            // bunifuCustomLabelMain
            // 
            this.bunifuCustomLabelMain.AutoSize = true;
            this.bunifuCustomLabelMain.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelMain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelMain.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelMain.Location = new System.Drawing.Point(0, 110);
            this.bunifuCustomLabelMain.Name = "bunifuCustomLabelMain";
            this.bunifuCustomLabelMain.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabelMain.TabIndex = 4;
            this.bunifuCustomLabelMain.Text = "MAIN";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTop.Controls.Add(this.bunifuThinButton21);
            this.panelTop.Controls.Add(this.bunifuThinButton22);
            this.panelTop.Controls.Add(this.bunifuCustomLabelVersionText);
            this.panelTop.Controls.Add(this.bunifuCustomLabelTopText);
            this.bunifuTransitionSlidingMenu.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(200, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(715, 165);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 6;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Play Song";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 6;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(17, 106);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(126, 51);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 6;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Play Album";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 6;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(152, 106);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(126, 51);
            this.bunifuThinButton22.TabIndex = 8;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabelVersionText
            // 
            this.bunifuCustomLabelVersionText.AutoSize = true;
            this.bunifuCustomLabelVersionText.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelVersionText, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelVersionText.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.bunifuCustomLabelVersionText.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelVersionText.Location = new System.Drawing.Point(302, 78);
            this.bunifuCustomLabelVersionText.Name = "bunifuCustomLabelVersionText";
            this.bunifuCustomLabelVersionText.Size = new System.Drawing.Size(71, 17);
            this.bunifuCustomLabelVersionText.TabIndex = 3;
            this.bunifuCustomLabelVersionText.Text = "v1.0 (WIP)";
            // 
            // bunifuCustomLabelTopText
            // 
            this.bunifuCustomLabelTopText.AutoSize = true;
            this.bunifuCustomLabelTopText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelTopText, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelTopText.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelTopText.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabelTopText.Location = new System.Drawing.Point(9, 57);
            this.bunifuCustomLabelTopText.Name = "bunifuCustomLabelTopText";
            this.bunifuCustomLabelTopText.Size = new System.Drawing.Size(306, 42);
            this.bunifuCustomLabelTopText.TabIndex = 2;
            this.bunifuCustomLabelTopText.Text = "Red Super Player";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.bunifuImageButtonMute);
            this.panelBottom.Controls.Add(this.bunifuImageButtonSettings);
            this.panelBottom.Controls.Add(this.bunifuImageButtonEnd);
            this.panelBottom.Controls.Add(this.bunifuImageButtonStart);
            this.panelBottom.Controls.Add(this.bunifuImageButtonPlay);
            this.panelBottom.Controls.Add(this.bunifuCustomLabelArtistExtraInfo);
            this.panelBottom.Controls.Add(this.bunifuCustomLabelArtistName);
            this.panelBottom.Controls.Add(this.bunifuCustomLabelEndTimer);
            this.panelBottom.Controls.Add(this.bunifuCustomLabelStartTimer);
            this.panelBottom.Controls.Add(this.bunifuSliderVolume);
            this.panelBottom.Controls.Add(this.bunifuSliderMain);
            this.panelBottom.Controls.Add(this.pictureBoxCoverSlider);
            this.bunifuTransitionSlidingMenu.SetDecoration(this.panelBottom, BunifuAnimatorNS.DecorationType.None);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(200, 500);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(715, 111);
            this.panelBottom.TabIndex = 2;
            // 
            // bunifuImageButtonMute
            // 
            this.bunifuImageButtonMute.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonMute, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonMute.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMute.Image")));
            this.bunifuImageButtonMute.ImageActive = null;
            this.bunifuImageButtonMute.Location = new System.Drawing.Point(564, 60);
            this.bunifuImageButtonMute.Name = "bunifuImageButtonMute";
            this.bunifuImageButtonMute.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButtonMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonMute.TabIndex = 16;
            this.bunifuImageButtonMute.TabStop = false;
            this.bunifuImageButtonMute.Zoom = 10;
            // 
            // bunifuImageButtonSettings
            // 
            this.bunifuImageButtonSettings.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonSettings, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonSettings.Image")));
            this.bunifuImageButtonSettings.ImageActive = null;
            this.bunifuImageButtonSettings.Location = new System.Drawing.Point(505, 60);
            this.bunifuImageButtonSettings.Name = "bunifuImageButtonSettings";
            this.bunifuImageButtonSettings.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButtonSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSettings.TabIndex = 15;
            this.bunifuImageButtonSettings.TabStop = false;
            this.bunifuImageButtonSettings.Zoom = 10;
            // 
            // bunifuImageButtonEnd
            // 
            this.bunifuImageButtonEnd.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonEnd, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonEnd.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonEnd.Image")));
            this.bunifuImageButtonEnd.ImageActive = null;
            this.bunifuImageButtonEnd.Location = new System.Drawing.Point(358, 58);
            this.bunifuImageButtonEnd.Name = "bunifuImageButtonEnd";
            this.bunifuImageButtonEnd.Size = new System.Drawing.Size(34, 32);
            this.bunifuImageButtonEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEnd.TabIndex = 14;
            this.bunifuImageButtonEnd.TabStop = false;
            this.bunifuImageButtonEnd.Zoom = 10;
            // 
            // bunifuImageButtonStart
            // 
            this.bunifuImageButtonStart.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonStart, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonStart.Image")));
            this.bunifuImageButtonStart.ImageActive = null;
            this.bunifuImageButtonStart.Location = new System.Drawing.Point(272, 58);
            this.bunifuImageButtonStart.Name = "bunifuImageButtonStart";
            this.bunifuImageButtonStart.Size = new System.Drawing.Size(34, 32);
            this.bunifuImageButtonStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonStart.TabIndex = 13;
            this.bunifuImageButtonStart.TabStop = false;
            this.bunifuImageButtonStart.Zoom = 10;
            // 
            // bunifuImageButtonPlay
            // 
            this.bunifuImageButtonPlay.BackColor = System.Drawing.Color.Black;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuImageButtonPlay, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonPlay.Image")));
            this.bunifuImageButtonPlay.ImageActive = null;
            this.bunifuImageButtonPlay.Location = new System.Drawing.Point(305, 49);
            this.bunifuImageButtonPlay.Name = "bunifuImageButtonPlay";
            this.bunifuImageButtonPlay.Size = new System.Drawing.Size(54, 41);
            this.bunifuImageButtonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonPlay.TabIndex = 12;
            this.bunifuImageButtonPlay.TabStop = false;
            this.bunifuImageButtonPlay.Zoom = 10;
            this.bunifuImageButtonPlay.Click += new System.EventHandler(this.bunifuImageButtonPlay_Click);
            // 
            // bunifuCustomLabelArtistExtraInfo
            // 
            this.bunifuCustomLabelArtistExtraInfo.AutoSize = true;
            this.bunifuCustomLabelArtistExtraInfo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelArtistExtraInfo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelArtistExtraInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelArtistExtraInfo.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelArtistExtraInfo.Location = new System.Drawing.Point(107, 75);
            this.bunifuCustomLabelArtistExtraInfo.Name = "bunifuCustomLabelArtistExtraInfo";
            this.bunifuCustomLabelArtistExtraInfo.Size = new System.Drawing.Size(102, 17);
            this.bunifuCustomLabelArtistExtraInfo.TabIndex = 8;
            this.bunifuCustomLabelArtistExtraInfo.Text = "Artist Extra Info";
            // 
            // bunifuCustomLabelArtistName
            // 
            this.bunifuCustomLabelArtistName.AutoSize = true;
            this.bunifuCustomLabelArtistName.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelArtistName, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelArtistName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelArtistName.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelArtistName.Location = new System.Drawing.Point(106, 48);
            this.bunifuCustomLabelArtistName.Name = "bunifuCustomLabelArtistName";
            this.bunifuCustomLabelArtistName.Size = new System.Drawing.Size(97, 19);
            this.bunifuCustomLabelArtistName.TabIndex = 6;
            this.bunifuCustomLabelArtistName.Text = "Artist Name";
            // 
            // bunifuCustomLabelEndTimer
            // 
            this.bunifuCustomLabelEndTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabelEndTimer.AutoSize = true;
            this.bunifuCustomLabelEndTimer.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelEndTimer, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelEndTimer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelEndTimer.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelEndTimer.Location = new System.Drawing.Point(672, 19);
            this.bunifuCustomLabelEndTimer.Name = "bunifuCustomLabelEndTimer";
            this.bunifuCustomLabelEndTimer.Size = new System.Drawing.Size(29, 16);
            this.bunifuCustomLabelEndTimer.TabIndex = 7;
            this.bunifuCustomLabelEndTimer.Text = "5:00";
            // 
            // bunifuCustomLabelStartTimer
            // 
            this.bunifuCustomLabelStartTimer.AutoSize = true;
            this.bunifuCustomLabelStartTimer.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuCustomLabelStartTimer, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabelStartTimer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabelStartTimer.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabelStartTimer.Location = new System.Drawing.Point(106, 19);
            this.bunifuCustomLabelStartTimer.Name = "bunifuCustomLabelStartTimer";
            this.bunifuCustomLabelStartTimer.Size = new System.Drawing.Size(29, 16);
            this.bunifuCustomLabelStartTimer.TabIndex = 6;
            this.bunifuCustomLabelStartTimer.Text = "0:00";
            // 
            // bunifuSliderVolume
            // 
            this.bunifuSliderVolume.AllowDrop = true;
            this.bunifuSliderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSliderVolume.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSliderVolume.BorderRadius = 3;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuSliderVolume, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSliderVolume.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuSliderVolume.Location = new System.Drawing.Point(595, 60);
            this.bunifuSliderVolume.MaximumValue = 100;
            this.bunifuSliderVolume.Name = "bunifuSliderVolume";
            this.bunifuSliderVolume.Size = new System.Drawing.Size(105, 30);
            this.bunifuSliderVolume.TabIndex = 2;
            this.bunifuSliderVolume.Value = 100;
            this.bunifuSliderVolume.ValueChanged += new System.EventHandler(this.bunifuSliderVolume_ValueChanged);
            // 
            // bunifuSliderMain
            // 
            this.bunifuSliderMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSliderMain.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSliderMain.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSliderMain.BorderRadius = 5;
            this.bunifuTransitionSlidingMenu.SetDecoration(this.bunifuSliderMain, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSliderMain.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(1)))), ((int)(((byte)(15)))));
            this.bunifuSliderMain.Location = new System.Drawing.Point(140, 13);
            this.bunifuSliderMain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bunifuSliderMain.MaximumValue = 100;
            this.bunifuSliderMain.Name = "bunifuSliderMain";
            this.bunifuSliderMain.Size = new System.Drawing.Size(527, 30);
            this.bunifuSliderMain.TabIndex = 1;
            this.bunifuSliderMain.Value = 2;
            // 
            // pictureBoxCoverSlider
            // 
            this.bunifuTransitionSlidingMenu.SetDecoration(this.pictureBoxCoverSlider, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxCoverSlider.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoverSlider.Image")));
            this.pictureBoxCoverSlider.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCoverSlider.Name = "pictureBoxCoverSlider";
            this.pictureBoxCoverSlider.Size = new System.Drawing.Size(100, 108);
            this.pictureBoxCoverSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCoverSlider.TabIndex = 0;
            this.pictureBoxCoverSlider.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panelBack.Controls.Add(this.listBoxMusic);
            this.bunifuTransitionSlidingMenu.SetDecoration(this.panelBack, BunifuAnimatorNS.DecorationType.None);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(200, 165);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(715, 335);
            this.panelBack.TabIndex = 3;
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransitionSlidingMenu.SetDecoration(this.listBoxMusic, BunifuAnimatorNS.DecorationType.None);
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(17, 24);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(670, 290);
            this.listBoxMusic.TabIndex = 0;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // bunifuDragControlMenu
            // 
            this.bunifuDragControlMenu.Fixed = true;
            this.bunifuDragControlMenu.Horizontal = true;
            this.bunifuDragControlMenu.TargetControl = this.panelMenu;
            this.bunifuDragControlMenu.Vertical = true;
            // 
            // bunifuDragControlText
            // 
            this.bunifuDragControlText.Fixed = true;
            this.bunifuDragControlText.Horizontal = true;
            this.bunifuDragControlText.TargetControl = this.panelText;
            this.bunifuDragControlText.Vertical = true;
            // 
            // bunifuDragControlTop
            // 
            this.bunifuDragControlTop.Fixed = true;
            this.bunifuDragControlTop.Horizontal = true;
            this.bunifuDragControlTop.TargetControl = this.panelTop;
            this.bunifuDragControlTop.Vertical = true;
            // 
            // bunifuTransitionSlidingMenu
            // 
            this.bunifuTransitionSlidingMenu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransitionSlidingMenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransitionSlidingMenu.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 611);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.bunifuTransitionSlidingMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Red Super Player";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSlideMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverSlider)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMenu;
        private ns1.BunifuImageButton bunifuImageButton4;
        private ns1.BunifuImageButton bunifuImageButton3;
        private ns1.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panelText;
        private ns1.BunifuImageButton bunifuImageButtonSearch;
        private ns1.BunifuDragControl bunifuDragControlMenu;
        private ns1.BunifuDragControl bunifuDragControlText;
        private ns1.BunifuDragControl bunifuDragControlTop;
        private ns1.BunifuCustomLabel bunifuCustomLabelTopText;
        private ns1.BunifuCustomLabel bunifuCustomLabelVersionText;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextboxSearch;
        private ns1.BunifuCustomLabel bunifuCustomLabelMain;
        private ns1.BunifuFlatButton bunifuFlatButtonBrowse;
        private ns1.BunifuFlatButton bunifuFlatButtonVideo;
        private ns1.BunifuFlatButton bunifuFlatButtonYoutube;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton bunifuFlatButtonPlaylists;
        private ns1.BunifuFlatButton bunifuFlatButtonMySongs;
        private ns1.BunifuCustomLabel bunifuCustomLabelLibrary;
        private ns1.BunifuCustomLabel bunifuCustomLabelEndTimer;
        private ns1.BunifuCustomLabel bunifuCustomLabelStartTimer;
        private ns1.BunifuSlider bunifuSliderVolume;
        private ns1.BunifuSlider bunifuSliderMain;
        private System.Windows.Forms.PictureBox pictureBoxCoverSlider;
        private ns1.BunifuCustomLabel bunifuCustomLabelArtistExtraInfo;
        private ns1.BunifuCustomLabel bunifuCustomLabelArtistName;
        private ns1.BunifuImageButton bunifuImageButtonStart;
        private ns1.BunifuImageButton bunifuImageButtonPlay;
        private ns1.BunifuImageButton bunifuImageButtonEnd;
        private ns1.BunifuImageButton bunifuImageButtonMute;
        private ns1.BunifuImageButton bunifuImageButtonSettings;
        private BunifuAnimatorNS.BunifuTransition bunifuTransitionSlidingMenu;
        private ns1.BunifuImageButton bunifuImageButtonSlideMenu;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.ListBox listBoxMusic;
    }
}

