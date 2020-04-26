using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTesting
{
    public class NotificationService
    {
        public void OnFileDownloaded (object source, FileEventArgs e)
        {
            Console.WriteLine("Notification: File {0} is Downloaded!", e.File.FileName);
        }
    }
}
