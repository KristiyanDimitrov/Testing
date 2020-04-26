using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsTesting
{
    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }
    }

    public class DownloadHelper
    {
        // Step1 - Create a delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args); // Option 1

        // Step 2 - Create an event based on delegate
        public event FileDownloadedEventHandler FileDownloadedEvent; // Option 1

        // Step 2 (alternative) Can use buit in event handler (delegate) for simple implentations like this. (Works if above 2 lines are removed)
        public event EventHandler<FileEventArgs> FileDownloadedEventAlternative; // Alternative Option 2


        // Step 3 - Raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloadedEvent != null)
            {
                FileDownloadedEvent(this, new FileEventArgs(){ File = file});
            }
        }

        public void Download (File file)
        {
            Console.WriteLine("Downloading File.....");
            Thread.Sleep(4000);

            // Step 3.1
            OnFileDownloaded(file);
        }
    }
}

