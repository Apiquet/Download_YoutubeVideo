﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace Download_YoutubeVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Download_Click(object sender, EventArgs e)
        {
            IEnumerable<VideoInfo> _video = DownloadUrlResolver.GetDownloadUrls(txtAddress.Text);
            VideoInfo _myVideo = _video.First(vid => vid.VideoType == VideoType.Mp4);
            if(_myVideo.RequiresDecryption) DownloadUrlResolver.DecryptDownloadUrl(_myVideo);
            VideoDownloader _downloader = new VideoDownloader(_myVideo, @"video.mp4");
            _downloader.Execute();
        }
    }
}
