using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task18._4._1
{
    /// <summary>
    /// Отправитель команды, для загрузки видео на диск
    /// </summary>
    internal class DiskSender : ISender
    {
        private ICommand command;

        public DiskSender(ICommand command)
        {
            this.command = command;
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteAsync()
        {
            var task = command.ExecuteAsync();
            task.Wait();
        }
    }
}