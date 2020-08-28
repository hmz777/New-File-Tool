using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFileTool
{
    public class FileProcessor
    {
        public static void ProcessFile(string FileName)
        {
            try
            {
                var path = Tools.LocatePath(Tools.GetActiveWindowTitle());

                //Path is null or in a special location like the "This PC" or "Recycle Bin" so we create the file on desktop instead.
                if (path == null)
                    path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                string FilePath = null;

                if (FileName.Contains("\\"))
                {
                    var dir = FileName.Substring(0, FileName.LastIndexOf("\\") + 1);
                    Directory.CreateDirectory(Path.Combine(path, dir));
                }

                FilePath = Path.Combine(path, FileName);

                var file = File.Create(FilePath);
                file.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
