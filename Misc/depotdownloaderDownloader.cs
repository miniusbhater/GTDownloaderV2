using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GTDownloaderV2.Misc
{
    public partial class depotdownloaderDownloader : Form
    {
        public depotdownloaderDownloader()
        {
            InitializeComponent();
        }

        private void depotdownloaderDownloader_Load(object sender, EventArgs e)
        {
            download();
        }

        private async void download()
        {
            
            string url = "https://github.com/SteamRE/DepotDownloader/releases/download/DepotDownloader_3.4.0/DepotDownloader-windows-x64.zip";
            string directoryPath = Environment.CurrentDirectory;
            string fileName = "DepotDownloader-windows-x64.zip";
            string fullPath = Path.Combine(directoryPath, fileName);
          
            using (WebClient webclient = new WebClient())
            {
              

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(fullPath, directoryPath);
                        File.Delete(fullPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}");
                    }

                    this.Close();
                };

                webclient.DownloadFileAsync(new Uri(url), fullPath);
            }



        }
    }
}
