using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task18._4._1
{
    /// <summary>
    /// Интерфейс получателя команд
    /// </summary>
    public interface IVideoService
    {
        public Task DownLoadVideoAsync();

        public Task GetInfoForVideoAsync();
    }
}
