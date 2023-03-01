using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task18._4._1
{
    /// <summary>
    /// Класс реализует команду получения информации о видеоролике
    /// </summary>
    internal class GetInfoForVideoCommand : ICommand
    {
        public IVideoService VideoService { get; private set; }

        public GetInfoForVideoCommand(IVideoService videoService)
        {
            this.VideoService = videoService;
        }

        public async Task ExecuteAsync()
        {
            await VideoService.GetInfoForVideoAsync();
        }
    }
}