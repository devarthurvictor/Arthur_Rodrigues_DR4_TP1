using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthur_Rodrigues_DR4_TP1
{
    internal class DownloadManager
    {
        public event EventHandler DownloadCompleted;

        public void StartDownload()
        {
            Console.WriteLine("Iniciando download...");
            Thread.Sleep(3000); 
            OnDownloadCompleted(); 
        }

        protected virtual void OnDownloadCompleted()
        {
            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
