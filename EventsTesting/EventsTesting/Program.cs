using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsTesting
{


    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { FileName = "TestFile" };
            var downloadHelper = new DownloadHelper(); //publisher
            var unpackService = new UnpackService();
            var notificationService = new NotificationService();

            downloadHelper.FileDownloadedEvent += unpackService.OnFileDownloaded;
            downloadHelper.FileDownloadedEvent += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);

            Console.ReadKey();
        }
    }
}
