using RedSuper_Player.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using TagLib;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.DirectX.AudioVideoPlayback;
namespace RedSuper_Player
{
    public partial class Form1: Form
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////// COLORS RELATED /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///// USES GET/SET METHOD TO GET COLOUR FROM SECOND FORM AND APPLY ON MAIN FORM 
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Get value, return it, set it on main form
        /// </summary>
        /// 
        public Image panelTopImage
        {
            get { return panelTop.BackgroundImage; }
            set { panelTop.BackgroundImage = value; }
        }

        public Color panelTopColor
        {
            get { return panelTop.BackColor; }
            set { panelTop.BackColor = value; }
        }

        public Color colorsButtonActiveForeColor
        {
            get { return bunifuThinButtonColors.ActiveForecolor; }
            set { bunifuThinButtonColors.ActiveForecolor = value; }
        }

        public Color colorsButtonIdleFillColor
        {
            get { return bunifuThinButtonColors.IdleFillColor; }
            set { bunifuThinButtonColors.IdleFillColor = value; }
        }

        public Color colorsButtonActiveFillColor
        {
            get { return bunifuThinButtonColors.ActiveFillColor; }
            set { bunifuThinButtonColors.ActiveFillColor = value; }
        }

        public Color colorsButtonActiveLineColor
        {
            get { return bunifuThinButtonColors.ActiveLineColor; }
            set { bunifuThinButtonColors.ActiveLineColor = value; }
        }

        public Color colorsButtonForeColor
        {
            get { return bunifuThinButtonColors.ForeColor; }
            set { bunifuThinButtonColors.ForeColor = value; }
        }

        public Color colorsButtonIdleForeColor
        {
            get { return bunifuThinButtonColors.IdleForecolor; }
            set { bunifuThinButtonColors.IdleForecolor = value; }
        }

        public Color colorsButtonIdleLineColor
        {
            get { return bunifuThinButtonColors.IdleLineColor; }
            set { bunifuThinButtonColors.IdleLineColor = value; }
        }

        //////////// Bunifu Related

        public Color aboutButtonActiveForeColor
        {
            get { return bunifuThinButtonAbout.ActiveForecolor; }
            set { bunifuThinButtonAbout.ActiveForecolor = value; }
        }

        public Color aboutButtonIdleFillColor
        {
            get { return bunifuThinButtonAbout.IdleFillColor; }
            set { bunifuThinButtonAbout.IdleFillColor = value; }
        }

        public Color aboutButtonActiveFillColor
        {
            get { return bunifuThinButtonAbout.ActiveFillColor; }
            set { bunifuThinButtonAbout.ActiveFillColor = value; }
        }

        public Color aboutButtonActiveLineColor
        {
            get { return bunifuThinButtonAbout.ActiveLineColor; }
            set { bunifuThinButtonAbout.ActiveLineColor = value; }
        }

        public Color aboutButtonForeColor
        {
            get { return bunifuThinButtonAbout.ForeColor; }
            set { bunifuThinButtonAbout.ForeColor = value; }
        }

        public Color aboutButtonIdleForeColor
        {
            get { return bunifuThinButtonAbout.IdleForecolor; }
            set { bunifuThinButtonAbout.IdleForecolor = value; }
        }

        public Color aboutButtonIdleLineColor
        {
            get { return bunifuThinButtonAbout.IdleLineColor; }
            set { bunifuThinButtonAbout.IdleLineColor = value; }
        }

        public Color topSideLabel
        {
            get { return bunifuCustomLabelVersionText.ForeColor; }
            set { bunifuCustomLabelVersionText.ForeColor = value; }
        }

        public Color topMainLabel
        {
            get { return bunifuCustomLabelTopText.ForeColor; }
            set { bunifuCustomLabelTopText.ForeColor = value; }
        }

        public Image browseButtonIcon
        {
            get { return bunifuFlatButtonBrowse.Iconimage; }
            set { bunifuFlatButtonBrowse.Iconimage = value; }
        }

        public Color browseButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonBrowse.OnHoverTextColor; }
            set { bunifuFlatButtonBrowse.OnHoverTextColor = value; }
        }

        public Image videoButtonIcon
        {
            get { return bunifuFlatButtonVideo.Iconimage; }
            set { bunifuFlatButtonVideo.Iconimage = value; }
        }

        public Color videoButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonVideo.OnHoverTextColor; }
            set { bunifuFlatButtonVideo.OnHoverTextColor = value; }
        }

        public Image youtubeButtonIcon
        {
            get { return bunifuFlatButtonYoutube.Iconimage; }
            set { bunifuFlatButtonYoutube.Iconimage = value; }
        }

        public Color youtubeButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonYoutube.OnHoverTextColor; }
            set { bunifuFlatButtonYoutube.OnHoverTextColor = value; }
        }

        public Image mySongsButtonIcon
        {
            get { return bunifuFlatButtonMySongs.Iconimage; }
            set { bunifuFlatButtonMySongs.Iconimage = value; }
        }

        public Color mySongsButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonMySongs.OnHoverTextColor; }
            set { bunifuFlatButtonMySongs.OnHoverTextColor = value; }
        }

        public Image playlistsButtonIcon
        {
            get { return bunifuFlatButtonPlaylists.Iconimage; }
            set { bunifuFlatButtonPlaylists.Iconimage = value; }
        }

        public Color playlistsButtonOnHoverTextColor
        {
            get { return bunifuFlatButtonPlaylists.OnHoverTextColor; }
            set { bunifuFlatButtonPlaylists.OnHoverTextColor = value; }
        }

        public Image menuButtonIcon
        {
            get { return bunifuImageButtonSlideMenu.Image; }
            set { bunifuImageButtonSlideMenu.Image = value; }
        }

        public Image coverIcon
        {
            get { return pictureBoxCoverSlider.Image; }
            set { pictureBoxCoverSlider.Image = value; }
        }

        public Color trackBarIndicatorColor
        {
            get { return bunifuSliderMain.IndicatorColor; }
            set { bunifuSliderMain.IndicatorColor = value; }
        }

        public Image startButtonIcon
        {
            get { return bunifuImageButtonStart.Image; }
            set { bunifuImageButtonStart.Image = value; }
        }

        public Image playButtonIcon
        {
            get { return bunifuImageButtonPlay.Image; }
            set { bunifuImageButtonPlay.Image = value; }
        }

        public Image endButtonIcon
        {
            get { return bunifuImageButtonEnd.Image; }
            set { bunifuImageButtonEnd.Image = value; }
        }

        public Image settingsButtonIcon
        {
            get { return bunifuImageButtonSettings.Image; }
            set { bunifuImageButtonSettings.Image = value; }
        }

        public Image soundButtonIcon
        {
            get { return bunifuImageButtonMute.Image; }
            set { bunifuImageButtonMute.Image = value; }
        }

        public Image goButtonIcon
        {
            get { return bunifuImageButtonGo.Image; }
            set { bunifuImageButtonGo.Image = value; }
        }

        public Color volumeSliderIndicatorColor
        {
            get { return bunifuSliderVolume.IndicatorColor; }
            set { bunifuSliderVolume.IndicatorColor = value; }
        }

        public Image equalizer
        {
            get { return pictureBoxEqualizer.Image; }
            set { pictureBoxEqualizer.Image = value; }
        }

        ////////////Video Window

        public Image fullScreenIcon
        {
            get { return bunifuImageButtonFullScreenVideo.Image; }
            set { bunifuImageButtonFullScreenVideo.Image = value; }
        }

        public Image rewindIcon
        {
            get { return bunifuImageButtonRewindVideo.Image; }
            set { bunifuImageButtonRewindVideo.Image = value; }
        }

        public Image fastForwardIcon
        {
            get { return bunifuImageButtonFastForwardVideo.Image; }
            set { bunifuImageButtonFastForwardVideo.Image = value; }
        }

        public Image stopIcon
        {
            get { return bunifuImageButtonStopVideo.Image; }
            set { bunifuImageButtonStopVideo.Image = value; }
        }

        public Color trackBarVideoIndicatorColor
        {
            get { return bunifuSliderMainVideo.IndicatorColor; }
            set { bunifuSliderMainVideo.IndicatorColor = value; }
        }

        public Color volumeSliderVideoColor
        {
            get { return bunifuSliderVolumeVideo.IndicatorColor; }
            set { bunifuSliderVolumeVideo.IndicatorColor = value; }
        }

        public Image startVideoIcon
        {
            get { return bunifuImageButtonSkipToStartVideo.Image; }
            set { bunifuImageButtonSkipToStartVideo.Image = value; }
        }

        public Image playVideoIcon
        {
            get { return bunifuImageButtonPlayVideo.Image; }
            set { bunifuImageButtonPlayVideo.Image = value; }
        }

        public Image endVideoIcon
        {
            get { return bunifuImageButtonSkipToEndVideo.Image; }
            set { bunifuImageButtonSkipToEndVideo.Image = value; }
        }

        public Image soundVideoIcon
        {
            get { return bunifuImageButtonSoundVideo.Image; }
            set { bunifuImageButtonSoundVideo.Image = value; }
        }

        public Image optionsVideoIcon
        {
            get { return bunifuImageButtonOptionsVideo.Image; }
            set { bunifuImageButtonOptionsVideo.Image = value; }
        }
    }
}
