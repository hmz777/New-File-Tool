using SHDocVw;
using Shell32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewFileTool
{
    public class Tools
    {
        /// <summary>
        /// The main code for this method is from <see href="https://stackoverflow.com/questions/20960316/get-folder-path-from-explorer-window">StackOverflow</see>, i just made some modifications for better intellisense.
        /// </summary>
        /// <returns></returns>
        public static string LocatePath(string WindowName)
        {
            if (string.IsNullOrWhiteSpace(WindowName))
                return default;

            string DirectoryPath = null;

            IntPtr MyHwnd = NativeMethods.FindWindow(null, WindowName);

            if (MyHwnd == null)
                return default;

            var t = Type.GetTypeFromProgID("Shell.Application");
            Shell o = (Shell)Activator.CreateInstance(t);
            try
            {
                var ws = (ShellWindows)o.Windows();
                for (int i = 0; i < ws.Count; i++)
                {
                    var ie = (InternetExplorer)ws.Item(i);
                    if (ie == null || ie.HWND != (long)MyHwnd) continue;
                    var path = System.IO.Path.GetFileName((string)ie.FullName);
                    if (path.ToLower() == "explorer.exe")
                    {
                        if (!string.IsNullOrWhiteSpace(ie.LocationURL))
                        {
                            DirectoryPath = new Uri(ie.LocationURL).LocalPath;
                        }
                    }
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(o);
            }

            return DirectoryPath;
        }

        public static string GetActiveWindowTitle()
        {
            var Processes = Process.GetProcessesByName("explorer");
            IntPtr ActiveWindowHandle = NativeMethods.GetForegroundWindow();

            if (ActiveWindowHandle == null)
                return default;

            _ = NativeMethods.GetWindowThreadProcessId(new HandleRef(null, ActiveWindowHandle), out int processId);

            foreach (var process in Processes)
            {
                if (process.Id == processId)
                {
                    int length = NativeMethods.GetWindowTextLength(ActiveWindowHandle);
                    StringBuilder text = new StringBuilder(length + 1);
                    NativeMethods.GetWindowText(ActiveWindowHandle, text, text.Capacity);
                    return text.ToString();
                }
            }

            return default;
        }
    }
}
