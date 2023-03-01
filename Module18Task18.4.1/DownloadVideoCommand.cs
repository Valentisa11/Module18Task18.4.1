using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task18._4._1
{
    /// <summary>
    /// Класс реализует команду загрузки видеоролика
    /// </summary>
    internal class DownloadVideoCommand : ICommand
    {
        public IVideoService VideoService { get; private set; }

        public DownloadVideoCommand(IVideoService videoService)
        {
            this.VideoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            await VideoService.DownLoadVideoAsync();
        }
    }
}

