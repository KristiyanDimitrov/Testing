using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsTesting
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("UnpackerService: Upacking the file {0}.....", e.File.FileName);
            Thread.Sleep(4000);
        }
    }
}
