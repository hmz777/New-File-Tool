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
        public static void ProcessFile(string FileName, Dictionary<string, bool> FileAttributes = null)
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

                if (!File.Exists(FilePath))
                {
                    var file = File.Create(FilePath);
                    file.Dispose();
                }

                if (FileAttributes != null)
                {
                    var flags = File.GetAttributes(FilePath);

                    if (FileAttributes["Hidden"] == true)
                        flags |= System.IO.FileAttributes.Hidden;

                    if (FileAttributes["Readonly"] == true)
                        flags |= System.IO.FileAttributes.ReadOnly;

                    if (FileAttributes["System"] == true)
                        flags |= System.IO.FileAttributes.System;

                    File.SetAttributes(FilePath, flags);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
