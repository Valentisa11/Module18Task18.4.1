using System;
using System.Text;


namespace Module18Task18._4._1
{
    internal class Program
    {
        static void Main()
        {
            string url;

            // Получаем ссылку на видео из консоли
            while (true)
            {
                Console.WriteLine("Введите ссылку видеоролика для загрузки:");
                url = Console.ReadLine();

                if (url.StartsWith("https://www.youtube")) break;

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Ссылка должна начинаться с https://www.youtube\n");

                Console.ForegroundColor = ConsoleColor.White;
            }

            // Получатель команд
            var youtubeService = new YoutubeService(url);

            // Создаем команды
            var downloadcommand = new DownloadVideoCommand(youtubeService);
            var infoCommand = new GetInfoForVideoCommand(youtubeService);

            Console.WriteLine("\nИнформация о видеоролике:\n");

            // Отправитель команд
            var diskSender = new DiskSender(infoCommand);

            // Запуск команды получения информации о видеофайле
            diskSender.ExecuteAsync();

            // Меняем команду
            diskSender.SetCommand(downloadcommand);

            Console.WriteLine("\nЗагрузка видеоролика...\n");

            // Запуск новой команды загрузки видеоролика
            diskSender.ExecuteAsync();

            Console.WriteLine("\nЗагрузка успешно завершилась.");
            Console.ReadLine();
        }
    }
}


