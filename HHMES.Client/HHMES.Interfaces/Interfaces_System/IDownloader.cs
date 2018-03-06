using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HHMES.Interfaces.Interfaces_System
{

    /// <summary> 
    /// 下载器接口 
    /// </summary> 
    public interface IDownloader
    {
        /// <summary> 
        /// 下载器名称 
        /// </summary> 
        string Name { get; }

        /// <summary> 
        /// 文件存放路径 
        /// </summary> 
        string DestinationPath { get; set; }

        /// <summary> 
        /// 本次下载文件清单 
        /// </summary> 
        IList FileList { get; }

        /// <summary> 
        /// 下载成功文件数 
        /// </summary> 
        int DownloadSuccess { get; }

        /// <summary> 
        /// 下载失败文件数 
        /// </summary> 
        int DownloadFailed { get; }

        /// <summary> 
        /// 获取下载文件清单 
        /// </summary> 
        IList GetFileList();

        void DownloadAll();
        void DownloadAll(IList files);
        bool DownloadFile(FileInfo file);

        IProgressUI ProgressUI { get; set; }
    }
}
