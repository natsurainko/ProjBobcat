﻿using System;
using ProjBobcat.Event;

namespace ProjBobcat.Class.Model
{
    public class DownloadFile
    {
        public string DownloadUri { get; set; }
        public string DownloadPath { get; set; }
        public string FileName { get; set; }
        public EventHandler<DownloadFileCompletedEventArgs> Completed { get; set; }
        public EventHandler<DownloadFileChangedEventArgs> Changed { get; set; }
    }
}