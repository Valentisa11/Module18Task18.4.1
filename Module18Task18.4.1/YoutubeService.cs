using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18Task18._4._1
{
    /// <summary>
    /// Сервис загрузки видеороликов из youtube
    /// </summary>
    internal class YoutubeService : IVideoService
    {
        private readonly YoutubeClient youtubeClient;
        private readonly string videoUrl;

        public YoutubeService(string videoUrl)
        {
            youtubeClient = new YoutubeClient();
            this.videoUrl = videoUrl;
        }

        /// <summary>
        /// Метод загрузки видео с сайта Youtube
        /// </summary>
        /// <returns></returns>
        public async Task DownLoadVideoAsync()
        {
            try
            {
                await youtubeClient.Videos.DownloadAsync(videoUrl, "video.mp4", o => o
                .SetPreset(ConversionPreset.UltraFast));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ex.Message);

                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Метод получает информацию о видеоролике и выводит ее в консоль
        /// </summary>
        /// <returns></returns>
        public async Task GetInfoForVideoAsync()
        {
            try
            {
                var video = await youtubeClient.Videos.GetAsync(videoUrl);

                if (video == null) { return; }

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(video.Title);

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(video.Description);

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ex.Message);

                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
            }
        }
    }
}
